using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    //This interface declares the method of the Product. In our example, it is the reportTo method of the soldier object.
    public interface Soldier
    {
        string reportTo();
    }
}
