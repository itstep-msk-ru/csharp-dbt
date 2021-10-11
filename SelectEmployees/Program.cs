using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SelectEmployees {
    class Program {
        static void Main (string[] args) {
            IList<Employee> employees = new List<Employee> ();

            string connectionString = @"Server=localhost\SQLEXPRESS; Database=company; Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection (connectionString)) {
                string query =
                    "SELECT ID, firstName, patronymic, lastName, birthDate, position, salary " +
                    "FROM employees " +
                    "ORDER BY firstName, lastName";
                SqlCommand command = new SqlCommand (query, connection);
                connection.Open ();
                using (SqlDataReader reader = command.ExecuteReader ()) {
                    while (reader.Read ()) {
                        int id = reader.GetInt32 (0);
                        string firstName = reader.GetString (1);
                        string? patronymic = reader.IsDBNull (2) ? null : reader.GetString (2);
                        string lastName = reader.GetString (3);
                        DateTime birthDate = reader.GetDateTime (4);
                        string position = reader.GetString (5);
                        int salary = reader.GetInt32 (6);

                        Employee employee = new Employee (id, firstName, patronymic, lastName, birthDate, position, salary);
                        employees.Add (employee);
                    }
                }
            }

            foreach (Employee employee in employees)
                Console.WriteLine ($"{employee.FirstName} {employee.LastName}");
        }
    }
}
