﻿using System;
using Entities;
using System.Collections.Generic;
namespace EXERCISE_01___COMPARISON_LINQ_LAMBDA {
    class Program {
        static void Main(string[] args) {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            list.Sort();

            foreach(Product p in list) {
                Console.WriteLine(p);
            }

        }
    }
}
