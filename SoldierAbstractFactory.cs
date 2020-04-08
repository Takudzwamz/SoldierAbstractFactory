using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    //Creating the Abstract Factory
    //AbstractFactory declares an interface for operations that will create AbstractProduct objects.
    //this class contains two methods.
    public abstract class SoldierAbstractFactory
    {
        /*
         The GetSoldier method is an abstract method that is going to be implemented by the child factory classes. 
         The CreateSoldierFactory method takes an input parameter i.e. factory type and then creates and returns 
         the appropriate factory object to the caller.
        */
        public abstract Soldier GetSoldier(string SoldierType);
        public static SoldierAbstractFactory CreateSoldierFactory(string FactoryType)
        {
            if (FactoryType.Equals("Orcs"))
                return new OrcsSoldierFactory();
            else
                return new ElvesSoldierFactory();
        }
    }
}
