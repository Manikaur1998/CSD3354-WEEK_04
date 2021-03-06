﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0730406_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Countryside c = new Countryside();
            c.run();
            c.Travel();
            //new Test().forTest();             // Anonymous Object Reference
            Console.ReadLine();
        }
    }

    class Village
    {
        public bool isAstrilde = false;
        public Village nextVillage;
        public Village prevVillage;
        public string villageName;
    }

    class Countryside
    {
        Village Toronto, Ajax, Maple;

        public Village CurrentVillage { get; private set; }

        public void run()
        {
            Maple = new Village();
            Maple.villageName = "Maple";
            Toronto = new Village();
            Toronto.villageName = "Toronto";
            Ajax = new Village();
            Ajax.isAstrilde = true;
            Ajax.villageName = "Ajax";

            Maple.nextVillage = Toronto;
            Toronto.nextVillage = Ajax;
            Ajax.nextVillage = null;
        }

        public void Travel()
        {
            CurrentVillage = Toronto;
            while (true)
            {
                if (CurrentVillage.isAstrilde)
                {


                    Console.WriteLine("Astrilde is in : " + CurrentVillage.villageName);
                    Console.ReadLine();
                }
                else
                    CurrentVillage = CurrentVillage.nextVillage;
            }
        }


    }
}