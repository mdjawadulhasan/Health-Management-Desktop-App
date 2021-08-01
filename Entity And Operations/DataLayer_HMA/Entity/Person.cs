﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_HMA.Entity
{
    public class Person
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Password { get; set; }
        public String UserName { get; set; }
        public int Age { get; set; }
        public double HeightInCm { get; set; }
        public double WeightInKg { get; set; }

        public string Gender { get; set; }

        public string BloodGroup { get; set; }

        public string Phone { get; set; }

        //public enum PersonTypeEnum { Patient = 1, Doctor, Admin }
        public int PersonType { get; set; }

        public Address address;
        public Person()
        {

        }
        public Person(Address address)
        {
            this.address = address;
        }
        public Person(string firstName, string lastName, string phone, string BloodGroup, Address address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.BloodGroup = BloodGroup;
            this.address = address;
        }
        public Person(string firstName, string lastName, string password, string userName, int age, double heightInCm, double weightInKg, string gender, string bloodGroup, string phone, int personType)
        {
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            UserName = userName;
            Age = age;
            HeightInCm = heightInCm;
            WeightInKg = weightInKg;
            Gender = gender;
            BloodGroup = bloodGroup;
            Phone = phone;
            PersonType = personType;
        }





    }
}