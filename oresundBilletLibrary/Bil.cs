﻿using System;
using System.Collections.Generic;
using System.Text;
using BilletLibrary;

namespace oresundBilletLibrary
{
    public class Bil : Køretøj
    {
        public Bil(string nummerplade, DateTime dato) : base(nummerplade, dato)
        {
        }

        /// <summary>
        /// Returnere prisen på en overkørsel
        /// Hvis der er anvendt brobizz gives der 5% rabat på overkørslen
        /// </summary>
        /// <returns></returns>

        public override decimal Pris(bool brobizz)
        {
            int pris = 410;
            
            if (brobizz == true)
            {
                decimal nyPris = 161;
                return nyPris;
            }

            return pris;
        }

        /// <summary>
        /// Retunerer køretøjstypen
        /// </summary>
        /// <returns></returns>
        public override string Køretøjstype()
        {
            return "Øresund Bil";
        }
    }
}
