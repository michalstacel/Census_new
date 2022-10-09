﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Census
{ 
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public DateOnly Birthsday { get; set; }

        public Person(int Id1, string Name1, string Surname1, int Age1)
        {
            Id = Id1;
            Name = Name1;
            Surname = Surname1;
            Age = Age1;
        }

        // time 44:54 21.09 Tuple
        // time 42:28 21.09 Lista obiektów
    }
}
