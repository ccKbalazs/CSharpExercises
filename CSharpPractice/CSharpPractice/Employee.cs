﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Employee : Person, ICloneable
    {

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.Number);
            return newEmployee;
        }

        public Room Room;
        private int salary;
        private string profession;

        public Employee()
        {
            Room = null;
        }

        public Employee(string name, DateTime birthDate, int salary, string profession) : base(name, birthDate)
        {
            this.salary = salary;
            this.profession = profession;
            Room = null;
        }

        public int Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }

        public string Profession
        {
            get
            {
                return profession;
            }

            set
            {
                profession = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(", salary: {0},  profession: {1}, room: {2}", salary, profession, Room.Number);
        }
    }
}