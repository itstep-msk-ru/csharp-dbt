﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectEmployees {
    public class Employee {
        public int ID { get; }
        public string FirstName { get; }
        public string? Patronymic { get; }
        public string LastName { get; }
        public DateTime BirthDate { get; }
        public string Position { get; }
        public int Salary { get; }

        public Employee (int id, string firstName, string? patronymic, string lastName, DateTime birthDate, string position, int salary) {
            ID = id;
            FirstName = firstName;
            Patronymic = patronymic;
            LastName = lastName;
            BirthDate = birthDate;
            Position = position;
            Salary = salary;
        }
    }
}
