using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        public Person(string name , int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            StringBuilder Sb = new StringBuilder();

            Sb.AppendLine($"Name: {this.Name}, Age: {this.Age}");


            return Sb.ToString();
        }
    }
}
