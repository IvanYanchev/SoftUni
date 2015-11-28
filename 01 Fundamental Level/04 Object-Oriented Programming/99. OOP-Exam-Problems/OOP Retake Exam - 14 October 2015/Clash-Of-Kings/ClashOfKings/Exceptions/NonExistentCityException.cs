﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfKings.Exceptions
{
    public class NonExistentCityException : GameException
    {
        public NonExistentCityException(string message)
            : base(message)
        {
        }
    }
}
