using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    //Concrete Product
    // it implements the reportTo method of the Soldier interface.
    public class OrcsGeneral : Soldier
    {
        public string reportTo()
        {
            return "Reports to Orcs Commander";
        }
    }
}
