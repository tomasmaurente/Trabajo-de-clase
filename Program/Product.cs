using System;

namespace ProductNamespace
{
    class Product
    {
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                this.name = value;
                }
                else
                {
                    Console.WriteLine("El valor no es correcto");
                }
            }
        }

        private int cost;

        public int Cost
        {
            get
            {
                return this.cost;
            }
            set
            {
                this.cost = value;
                
            }
        }
        private string code;

        public string Code
        {
            get
            {
                return this.code;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.code = value;
                }
                else
                {
                    Console.WriteLine("El valor no es correcto");
                }
            }
        }

        public Product(string name, int cost, string code)
        {
            Name = name;
            Cost = cost;
            Code = code;
        }
        

    }
}