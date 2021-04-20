using System;
using GondolaNamespace;
using ProductNamespace;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Tallarines = new Product("Tallarines",123,"123456");
            Gondola Fideos     = new Gondola();
            Fideos.AddProduct(Tallarines);
        }
    }
}
