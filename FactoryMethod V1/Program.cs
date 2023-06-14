// See https://aka.ms/new-console-template for more information
using FactoryMethod_V1 . Class ;

namespace FactoryMethod_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new RoadLogistics();
            creator.Deliver();
        }
    }
}