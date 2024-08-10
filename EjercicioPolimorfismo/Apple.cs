using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Iphone : Telefono
    {

       
        public Iphone(string Modelo, string TipoCompania, int Numero, double Precio, string Cliente, double Cantidad)
        {
            this.Cantidad = Cantidad;
           this.Modelo = Modelo;
            this.Cliente = Cliente;
            this.Numero = Numero;
            this.Precio = Precio;
            this.TipoCompania = TipoCompania;
        }

        public Iphone() { }

        public string Modelo { get; set; }

        public string TipoCompania { get; set; }

        public int Numero { get; set; }

        public double Precio { get; set; }

        public string Cliente { get; set; }

        public double Cantidad { get; set; }

        public double Descuento { get; set; }
     

       
        public override void Vendido()
        {
            Console.WriteLine($"El telefono modelo: {Modelo} de la compañia: {TipoCompania} con numero: {Numero} con precio de: {Precio}");

        }

        public override void Vendido(string cliente)
        {
            Console.WriteLine($"El telefono modelo: {Modelo} de la compañia: {TipoCompania} con numero: {Numero} lleva una cantidad de: {Cantidad} con un precio de: {Precio} al cliente: {Cliente}");

        }

        public override void Vendido(string cliente, double cantidad)
        {
            Console.WriteLine($"El telefono modelo: {Modelo} de la compañia: {TipoCompania} con numero: {Numero} lleva una cantidad de: {Cantidad} con un precio de: {Precio} al cliente: {Cliente} con un total de: {TotalTelefonos()} ");

        }
        public override void Vendido(string cliente, double cantidad, double descuento)
        {
            Console.WriteLine($"El telefono modelo: {Modelo} de la compañia: {TipoCompania} con numero: {Numero} lleva una cantidad de: {Cantidad} con un precio de: {Precio} al cliente: {Cliente} con un total y con descuento aplicado: {TotalTelefonos(Descuento)} ");

        }

        public override double TotalTelefonos()
        {
            double cantidad = this.Cantidad * this.Precio;
            return cantidad;

        }
        public override double TotalTelefonos(double descuento)
        {
            double cantidad = (this.Cantidad * this.Precio) * this.Descuento;
            return cantidad;

        }



    }
}
