﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Census
{
     internal class AddPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public DateOnly Birthsday { get; set; }

        public AddPerson()
        {

        }

        //time 44:54 21.09 Tuple
        //time 42:28 21.09 Lista obiektów
    }
}
