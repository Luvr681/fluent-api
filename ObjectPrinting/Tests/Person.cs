﻿using System;

namespace ObjectPrinting.Tests
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }

        public Person Friend { get; set; } 
        
        public int Weight { get; set; }
        
        public string Country { get; set; }
    }
}