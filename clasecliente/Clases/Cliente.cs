﻿using clasecliente.BaseDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasecliente.NewFolder1
{
    public class Cliente
    {
        private int id;
        private string cedula;
        private string nombres;
        private string apellidos;
        private string nombres_completos;

        public Cliente(string cedula, string nombres, string apellidos)
        {
            int secuencialGenerado = BaseDeDatos.BaseDatosCliente.Count() + 1;
        
            this.id = secuencialGenerado;
            this.cedula = cedula;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.nombres_completos = nombres + " " + apellidos;

            BaseDeDatos.BaseDatosCliente.Add(this);

        }

        public void imprimir()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Cédula: " + this.cedula);
            Console.WriteLine("Nombres: " + this.nombres);
            Console.WriteLine("Apellidos: " + this.apellidos);
            Console.WriteLine("Nombres Completos: " + this.nombres_completos);
            Console.WriteLine("=========================================");
        }

    }
}
