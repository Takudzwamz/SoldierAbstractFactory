﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    ////Concrete Product
    // it implements the reportTo method of the Soldier interface.
    public class ElvesLieutenant : Soldier
    {
        public string reportTo()
        {
            return "Reports to Elves General";
        }
    }
}
