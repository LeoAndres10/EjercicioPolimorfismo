



using EjercicioPolimorfismo;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;

Samsung telefonos = new Samsung();
Iphone celulares = new Iphone();

Console.WriteLine("Ingrese el modelo de celular(samsung o iphone): ");
string Modelo = Console.ReadLine();


if (Modelo=="samsung")
{
    telefonos.Modelo = Modelo;  
    Console.WriteLine("Ingrese la cantidad de telefonos: ");
    int Cantidad= Convert.ToInt32(Console.ReadLine());
    telefonos.Cantidad = Cantidad;
    Console.WriteLine("Ingrese nombre del cliente: ");
    string Cliente= Console.ReadLine();
    telefonos.Cliente = Cliente;
    Console.WriteLine("Ingrese el numero telefonico: ");
    telefonos.Numero=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el precio del Samsung: ");
    telefonos.Precio= Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese la compañia de Samsung: ");
    telefonos.TipoCompania = Console.ReadLine();

    telefonos.Vendido();
    Console.WriteLine();
    telefonos.Vendido(Cliente, Cantidad);
    
}
else if (Modelo=="iphone")
{   
    celulares.Modelo = Modelo;
    Console.WriteLine("Ingrese la cantidad de telefonos: ");
    int Cantidad = Convert.ToInt32(Console.ReadLine());
    celulares.Cantidad = Cantidad;
    Console.WriteLine("Ingrese nombre del cliente: ");
    string Cliente = Console.ReadLine();
    celulares.Cliente = Cliente;
    Console.WriteLine("Ingrese el numero telefonico: ");
    celulares.Numero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el precio del iphone: ");
    celulares.Precio = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese la compañia de iphone: ");
    celulares.TipoCompania = Console.ReadLine();
    Console.WriteLine("A los telefonos iphone se les aplica un descuento de 15%(0.15)");
    Console.WriteLine("Ingrese descuento: ");
    double Descuento=Convert.ToDouble(Console.ReadLine());
    celulares.Descuento= Descuento;
    celulares.Vendido();
    Console.WriteLine();    
    celulares.Vendido(Cliente, Cantidad,Descuento);


}


