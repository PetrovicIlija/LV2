using System;
using System.Collections.Generic;

namespace LV2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //prvi zadatak
            //DiceRoller MyRoller = new DiceRoller();
            //for (int i = 0; i < 20; i++)
            //    MyRoller.InsertDie(new Die(6));
            //MyRoller.RollAllDice();
            //IList<int> results = MyRoller.GetRollingResults();
            //printResults(results);
            
            //2.zadatak
            //Random theRandomGenerator = new Random();
            //DiceRoller MyRoller = new DiceRoller();
            //for (int i = 0; i < 20; i++)
            //    MyRoller.InsertDie(new Die(6, ref theRandomGenerator));
            //for (int i = 0; i < 20; i++)
            //    MyRoller.RollAllDice();
            //IList<int> results = MyRoller.GetRollingResults();
            //printResults(results);
        }
        static public void printResults(IList<int> results)
        {
            foreach (int result in results)
                Console.WriteLine(result);
        }
    }
}
