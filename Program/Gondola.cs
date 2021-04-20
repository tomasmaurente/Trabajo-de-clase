using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ProductNamespace;

namespace GondolaNamespace
{
    class Gondola
    {
        private List<Product> listOne;
        public ReadOnlyCollection<Product> ListOne
        {
            get
            {
                return this.listOne.AsReadOnly();
            }
        }

        public Gondola()
        {
            this.listOne = new List<Product>();
        }

        public void AddProduct(Product newProduct)
        {
            this.listOne.Add(newProduct);
        }

        public void CutProduct(string codeProduct)
        {
            int counter = 0;
            foreach (Product i in listOne)
            {

                if (i.Code == codeProduct)
                {
                    listOne.RemoveAt(counter);
                    Console.WriteLine("Producto eliminado");
                    break;
                }
                counter += 1;

            }
            
        }
    }
}