using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Animal
    {
        public string Name { get; set; }
        public string Eat { get; set; }
        public BiomType Biom { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }

        public double Area { get; set; }

        public string[] WhatDoesHeEat { get; set; }

        public bool IsPradator { get; protected set; }

        protected string _sound;

        public void ToEat(string eat, double kg)
        {
            if (eat.Contains(eat))
            {
                Console.WriteLine($"{Name}ate{kg}kilogram{eat}");
            }
        }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }


    }
}

 

