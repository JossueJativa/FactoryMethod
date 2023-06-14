// See https://aka.ms/new-console-template for more information
using FactoryMethod_V1 . Class ;

namespace FactoryMethod_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new RoadLogistics();

            //ingresar un metodo de entrega
            Console.WriteLine("Ingrese el metodo de transporte que va a llevar: ");
            Console.WriteLine("1. Truck");
            Console.WriteLine("2. Ship");

            string x =Console.ReadLine();

            if (x == "1")
            {
                creator.DeliverByTruck();
            }
            else if (x == "2")
            {
                creator.DeliverByShip();
            }
            else
            {
                Console.WriteLine("Opcion no valida");
            }
        }
    }
}