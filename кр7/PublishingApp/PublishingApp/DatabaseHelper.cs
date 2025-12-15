using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using PublishingApp.Models;

namespace PublishingApp
{
    public class DatabaseHelper : IDisposable
    {
        private string connectionString = @"Data Source=DESKTOP-3CVUA48\SQLEXPRESS;Initial Catalog=Publishing;Integrated Security=True;Connect Timeout=30";

        public List<Book> GetBooks()
        {
            var books = new List<Book>();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            p.PublicationID as id_Publication, 
                            p.Title as Name, 
                            p.AuthorID as Author,
                            a.FirstName + ' ' + a.LastName as AuthorName,
                            YEAR(p.PublishDate) as ReleaseYear,
                            300 as VolumeOfSheets,
                            1000 as Circulation,
                            p.Price
                        FROM Publications p
                        LEFT JOIN Authors a ON p.AuthorID = a.AuthorID
                        ORDER BY p.Title";

                    using (var command = new SqlCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.Add(new Book
                            {
                                Id = Convert.ToInt32(reader["id_Publication"]),
                                Title = reader["Name"].ToString(),
                                AuthorId = reader["Author"] != DBNull.Value ?
                                    Convert.ToInt32(reader["Author"]) : 0,
                                AuthorName = reader["AuthorName"].ToString(),
                                ReleaseYear = reader["ReleaseYear"] != DBNull.Value ?
                                    Convert.ToInt32(reader["ReleaseYear"]) : DateTime.Now.Year,
                                Pages = 300,
                                Circulation = 1000,
                                Price = Convert.ToDecimal(reader["Price"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при загрузке книг: {ex.Message}");
            }

            return books;
        }

        public List<Office> GetOffices()
        {
            var offices = new List<Office>();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            OfficeID as id_Office, 
                            OfficeName as Office, 
                            Address, 
                            Phone 
                        FROM Offices 
                        ORDER BY OfficeName";

                    using (var command = new SqlCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            offices.Add(new Office
                            {
                                Id = Convert.ToInt32(reader["id_Office"]),
                                Name = reader["Office"].ToString(),
                                Address = reader["Address"].ToString(),
                                Phone = reader["Phone"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при загрузке офисов: {ex.Message}");
            }

            return offices;
        }

        public int CreateOrder(Order order)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        INSERT INTO Orders (CustomerID, PublicationID, OrderDate, Quantity, TotalAmount, OfficeID)
                        VALUES (@Customer, @Publication, @DateOfAdmission, @Quantity, @Price, @Office);
                        SELECT SCOPE_IDENTITY();";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Customer", order.CustomerId);
                        command.Parameters.AddWithValue("@Publication", order.BookId);
                        command.Parameters.AddWithValue("@DateOfAdmission", order.OrderDate);
                        command.Parameters.AddWithValue("@Quantity", 1);
                        command.Parameters.AddWithValue("@Price", order.Price);
                        command.Parameters.AddWithValue("@Office", order.OfficeId);

                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при создании заказа: {ex.Message}");
            }
        }

        public int CreateCustomer(Customer customer)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        INSERT INTO Customers (FirstName, LastName, Email, Phone, Address)
                        VALUES (@FirstName, @LastName, @Email, @Phone, @Address);
                        SELECT SCOPE_IDENTITY();";

                    using (var command = new SqlCommand(query, connection))
                    {
                        var names = customer.Name.Split(' ');
                        string firstName = names.Length > 0 ? names[0] : customer.Name;
                        string lastName = names.Length > 1 ? names[1] : "";

                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Email",
                            string.IsNullOrEmpty(customer.Email) ?
                            (object)DBNull.Value : customer.Email);
                        command.Parameters.AddWithValue("@Phone",
                            string.IsNullOrEmpty(customer.Phone) ?
                            (object)DBNull.Value : customer.Phone);
                        command.Parameters.AddWithValue("@Address",
                            string.IsNullOrEmpty(customer.Address) ?
                            (object)DBNull.Value : customer.Address);

                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при создании клиента: {ex.Message}");
            }
        }

        public Order GetOrderDetails(int orderId)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // ИСПРАВЛЕННЫЙ ЗАПРОС: заменен "off" на "offic" (не зарезервированное слово)
                    string query = @"
                        SELECT 
                            o.OrderID as id_Order, 
                            CONCAT('Заказ №', o.OrderID) as OrderName,
                            o.OrderDate as DateOfAdmission,
                            o.TotalAmount as Price,
                            p.Title as BookTitle,
                            CONCAT(c.FirstName, ' ', c.LastName) as CustomerName,
                            offic.OfficeName
                        FROM Orders o
                        LEFT JOIN Publications p ON o.PublicationID = p.PublicationID
                        LEFT JOIN Customers c ON o.CustomerID = c.CustomerID
                        LEFT JOIN Offices offic ON o.OfficeID = offic.OfficeID
                        WHERE o.OrderID = @OrderId";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderId", orderId);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Order
                                {
                                    Id = Convert.ToInt32(reader["id_Order"]),
                                    OrderName = reader["OrderName"].ToString(),
                                    BookTitle = reader["BookTitle"].ToString(),
                                    CustomerName = reader["CustomerName"].ToString(),
                                    OfficeName = reader["OfficeName"].ToString(),
                                    OrderDate = Convert.ToDateTime(reader["DateOfAdmission"]),
                                    Price = Convert.ToDecimal(reader["Price"])
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при получении деталей заказа: {ex.Message}");
            }

            return null;
        }

        public bool TestConnection()
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    return connection.State == ConnectionState.Open;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка подключения: {ex.Message}");
                return false;
            }
        }

        public void Dispose()
        {
            // Реализация интерфейса IDisposable
        }
    }
}