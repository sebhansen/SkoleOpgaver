﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademiet
{
    public class Academy : Subject
    {
        public string Name { get; set; }
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value;
                  Notify();
                }
        }


        public Academy(string name)
        {
            Name = name;
        }
    }
}
