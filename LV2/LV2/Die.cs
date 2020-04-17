﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    class Die
    {
        //prvi zadatak
        //private int numberOfSides;
        //private Random randomGenerator;
        //public Die(int numberOfSides)
        //{
        //    this.numberOfSides = numberOfSides;
        //    this.randomGenerator = new Random();
        //}
        //public int Roll()
        //{
        //    int rolledNumber = randomGenerator.Next(1, numberOfSides + 1);
        //    return rolledNumber;

        //drugi zadatak
        private int numberOfSides;
        private Random randomGenerator;
        public Die(int numberOfSides, ref Random theRandomGenerator)
        {
            this.numberOfSides = numberOfSides;
            randomGenerator = theRandomGenerator;
        }
        public int Roll()
        {
            int rolledNumber = randomGenerator.Next(1, numberOfSides + 1);
            return rolledNumber;
        }

        //treci zadatak
        //private int numberOfSides;
        //private RandomGenerator randomGenerator;
        //public Die(int numberOfSides)
        //{
        //    this.numberOfSides = numberOfSides;
        //    this.randomGenerator = RandomGenerator.GetInstance();
        //}
        //public int Roll()
        //{
        //    int rolledNumber = randomGenerator.NextInt(1, numberOfSides + 1);
        //    return rolledNumber;
        //}
    }
}
