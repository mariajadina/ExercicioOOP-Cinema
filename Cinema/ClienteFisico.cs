﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class ClienteFisico
    {
        //Atributos
        private string beneficio;

        //Acessadores get e set
        public string Beneficio
        {
            get
            {
                return beneficio;
            }
            set
            {
                if (PossuiBeneficio())
                {
                    beneficio = value; //ver como isso vai funcionar tbm, é pra garantir meia entrada na teoria.
                } //não sei o que fazer com o else, ver depois.
            }
        }
        static bool PossuiBeneficio()
        {
            bool beneficio = true;
            if (beneficio)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}