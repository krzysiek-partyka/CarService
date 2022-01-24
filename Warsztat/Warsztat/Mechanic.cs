﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warsztat
{
    public class Mechanic : Worker
    {
        public readonly string specialization;//myslalem o fiat bmw itp
        public readonly int repairMade;
        public readonly int complaints;


        

        public Mechanic(string specialization, int repairMade, int complaints) 
        {
            this.specialization = specialization;
            this.repairMade = repairMade;
            this.complaints = complaints;
        }

        public Mechanic(string firstName, string lastName, int age, double salary, int seniority) : base(firstName, lastName, age, salary, seniority)
        {
        
        
        }
        public Mechanic()
         {
            // nie wiem o co z tym chodzi ale jak sie chce wywołać funkcje w innej klasie bez podawania jej parametrów to VS podpowiada Create constructor in Klasa 
         }
    }
}
