using System;
using System.Collections.Generic;
using System.Text;

namespace Co_ContravarianceDemo
{
    class Planet
    {
        public Planet CallingPlanet()
        {
            Console.WriteLine("Displaying a planet base class");
            return this;
        }
    }
    class Earth : Planet
    {
        public Earth CallingEarth()
        {
            Console.WriteLine("Displaying earth derived class");
            return this;
        }
    }
    class Program
    {
        public delegate Planet CovariantDelegate();
        public delegate void ContravariantDelegate(Earth objEarth);

        private static void PlanetParamMethod(Planet objPlanet)
        {
            Console.WriteLine("Method for Planet object");
        }

        private static void EarthParamMethod(Earth objEarth)
        {
            Console.WriteLine("Method for Earth object");
        }

        static void Main1(string[] args)
        {
            Planet p = new Planet();
            Earth e = new Earth();

            CovariantDelegate varCovariantDelegate = new CovariantDelegate(p.CallingPlanet);
            varCovariantDelegate();

            varCovariantDelegate = new CovariantDelegate(e.CallingEarth);
            varCovariantDelegate();

            ContravariantDelegate varContravariantDelegate = new ContravariantDelegate(PlanetParamMethod);
            varContravariantDelegate(e);

            varContravariantDelegate = new ContravariantDelegate(EarthParamMethod);
            varContravariantDelegate(e);
        }
    }
}