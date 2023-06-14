namespace FactoryMethod_V1.Class
{
    abstract class Transport
    {
        public abstract void Deliver();
    }

    class Truck : Transport
    {
        public override void Deliver()
        {
            System.Console.WriteLine("Deliver by Truck");
        }
    }

    //clase creada para el ejemplo
    /*
    class Ship : Transport
    {
        public override void Deliver()
        {
            System.Console.WriteLine("Deliver by Ship");
        }
    }
    */

    abstract class Creator
    {
        public abstract Transport CreateTransport();

        public void Deliver()
        {
            Transport transport = CreateTransport();
            transport.Deliver();
        }
    }

    class RoadLogistics : Creator
    {
        public override Transport CreateTransport()
        {
            return new Truck();
        }
    }
}