using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    //Creating Concrete Factory
    //This is a class that implements the Abstract Factory(Soldier Factory) class.
    public class ElvesSoldierFactory : SoldierAbstractFactory
    {

        /*This class is going to implement the GetAnimal method of Animal factory class.
         There are two types of concrete abstract factories in our example i.e. ElvesSoldierfactory and OrcsSoldierfactory. */
        public override Soldier GetSoldier(string SoldierType)
        {
            if (SoldierType.Equals("ElvesCommander"))
            {
                return new ElvesCommander();
            }
            else if (SoldierType.Equals("ElvesGeneral"))
            {
                return new ElvesGeneral();
            }
            else if (SoldierType.Equals("ElvesLieutenant"))
            {
                return new ElvesLieutenant();
            }
            else
                return null;
        }
    }
}
