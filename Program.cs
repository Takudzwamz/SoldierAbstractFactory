using System;

namespace AbstractFactory
{
    //The Program uses the Abstract Factory and Abstract Product interfaces to create a family of related objects.
    class Program
    {
        static void Main(string[] args)
        {
            Soldier soldier = null;
            SoldierAbstractFactory soldierAbstractFactory = null;
            string AnswersTo = null;
            // Create the Orcs Factory object by passing the factory type as Orcs
            soldierAbstractFactory = SoldierAbstractFactory.CreateSoldierFactory("Orcs");
            Console.WriteLine("Soldier Factory type : " + soldierAbstractFactory.GetType().Name);
            Console.WriteLine();
            // Get Orcs Soldier object by passing the soldier type as OrcsCommander
            soldier = soldierAbstractFactory.GetSoldier("OrcsCommander");
            Console.WriteLine("Soldier Type : " + soldier.GetType().Name);
            AnswersTo = soldier.reportTo();
            Console.WriteLine(soldier.GetType().Name + " reports to : " + AnswersTo);
            Console.WriteLine();
            //  Get Orcs Soldier object by passing the soldier type as OrcsGeneral
            soldier = soldierAbstractFactory.GetSoldier("OrcsGeneral");
            Console.WriteLine("Soldier Type : " + soldier.GetType().Name);
            AnswersTo = soldier.reportTo();
            Console.WriteLine(soldier.GetType().Name + " reports to : " + AnswersTo);
            Console.WriteLine();
            //  Get Orcs Soldier object by passing the soldier type as OrcsLieutenant
            soldier = soldierAbstractFactory.GetSoldier("OrcsLieutenant");
            Console.WriteLine("Soldier Type : " + soldier.GetType().Name);
            AnswersTo = soldier.reportTo();
            Console.WriteLine(soldier.GetType().Name + " reports to : " + AnswersTo);
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            // Create Elves Factory object by passing the factory type as Elves
            soldierAbstractFactory = SoldierAbstractFactory.CreateSoldierFactory("Elves");
            Console.WriteLine("Soldier Factory type : " + soldierAbstractFactory.GetType().Name);
            Console.WriteLine();
            // Get Eloves Soldier object by passing the soldier type as ElvesCommander
            soldier = soldierAbstractFactory.GetSoldier("ElvesCommander");
            Console.WriteLine("Soldier Type : " + soldier.GetType().Name);
            AnswersTo = soldier.reportTo();
            Console.WriteLine(soldier.GetType().Name + " reports to : " + AnswersTo);
            Console.WriteLine();
            // Get Eloves Soldier object by passing the soldier type as ElvesGeneral
            soldier = soldierAbstractFactory.GetSoldier("ElvesGeneral");
            Console.WriteLine("Soldier Type : " + soldier.GetType().Name);
            AnswersTo = soldier.reportTo();
            Console.WriteLine(soldier.GetType().Name + " reports to : " + AnswersTo);
            Console.WriteLine();
            // Get Eloves Soldier object by passing the soldier type as ElvesLieutenant
            soldier = soldierAbstractFactory.GetSoldier("ElvesLieutenant");
            Console.WriteLine("Soldier Type : " + soldier.GetType().Name);
            AnswersTo = soldier.reportTo();
            Console.WriteLine(soldier.GetType().Name + " reports to : " + AnswersTo);
            Console.Read();
        }
    }
}