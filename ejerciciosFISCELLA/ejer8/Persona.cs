﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer8
{
    class Persona
    {
        string nombre = "";
        int edad = 0;
        char sexo = 'M';
        int faltas = 0;
        public int Faltas { get { return faltas; } set { value = faltas; } }
        public string Nombre { get { return nombre; } set { value = nombre; } }
        public int Edad { get { return edad; } set { value = edad; } }
        public char Sexo { get { return sexo; } set { value = sexo; } }
        public Persona(string nombre, int edad, char sexo)
        {
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
        }
        public virtual void justificadas(){}
        public void faltar()
        {
            faltas++;
        }
    }
}
