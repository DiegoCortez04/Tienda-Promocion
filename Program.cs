using Practica2.Entities;
using Practica2.Services;
using System;

namespace Practica2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cliente persona = new Cliente();
            Descuentos compra = new Descuentos();
            persona.PedirDatos();
            compra.Descuento();
            persona.ImprimirDatos();
        }
    }
}
