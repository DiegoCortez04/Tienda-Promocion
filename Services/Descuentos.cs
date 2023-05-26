using Practica2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Practica2.Services
{
    public class Descuentos
    {
        //DESCUENTOS POR COMPRAS GRANDES
        public void Descuento()
        {
            Console.Clear();
            Descuentos desc = new Descuentos();
            Articulo articulo= new Articulo();
            double total = articulo.Compra();

            if (total >= 5000 && total < 8000)
            {
                desc.DescuentoDiez(total);
            }

            else if (total >= 8000 && total < 10000)
            {
                Console.Clear();
                desc.TresMSI(total);
                Console.WriteLine($"EL TOTAL FINAL A PAGAR ES DE: {total}");
            }
            else if(total >= 10000)
            {
                Console.Clear();
                desc.SeisMSI(total);
                Console.WriteLine($"EL TOTAL FINAL A PAGAR ES DE: {total}");
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"EL TOTAL ES: {total}");
            }
        }
        public void DescuentoDiez(double total)
        {
            Console.WriteLine("TIENES UN 10% DE DESCUENTO POR TU COMPRA MAYOR A $5000");
            total = total * 0.9;
            Console.WriteLine("TU TOTAL ES DE: " + total);
            
        }
        public void TresMSI(double total)
        {
            Console.WriteLine("TIENES 3 MESES SIN INTERESES POR TU COMPRA MAYOR A $8000");
            total = total / 3;
            Console.WriteLine("TU TOTAL MENSUAL A 3 MESES ES DE: " + total);
        }
        public void SeisMSI(double total)
        {
            Console.WriteLine("TIENES 6 O 12 MESES SIN INTERESES POR TU COMPRA MAYOR A $10,000");
            double seism = total / 6;
            Console.WriteLine("TU TOTAL MENSUAL A 6 MESES ES DE: " + seism);
            double docem = total / 12;
            Console.WriteLine("TU TOTAL MENSUAL A 12 MESES ES DE: " + docem);
        }
    }
}
