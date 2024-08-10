using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public abstract class Telefono
    {
        

        public abstract void Vendido();
       

        public abstract void Vendido(string cliente);
        

        public abstract void Vendido(string cliente, double cantidad);
       
        public abstract void Vendido(string cliente, double cantidad, double descuento);
       

        public abstract double TotalTelefonos();
       
        public abstract double TotalTelefonos(double descuento);
       


    }

 }
