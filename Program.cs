using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoTotal
{

    public class Product
    {
        private string nome;
        private double price;
        private int quantity;

        public Product(string nome, double price, int quantity)
        {
            this.nome = nome;
            this.Price = price;
            this.Quantity = quantity;
        }

        public double CalculateTotalPrice()
        {
            return quantity * price;
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    throw new ArgumentException("O preço não pode ser menor que zero.");
                }
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value > 0)
                {
                    quantity = value;
                }
                else
                {
                    throw new ArgumentException("A quantidade de produtos não pode ser menor que zero.");
                }
            }
        }

        public string Nome
        {
            get { return nome; }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    Product product = new Product("alisson", 8, 10);
                    double total = product.CalculateTotalPrice();
                    Console.WriteLine($"O produto: {product.Nome}, Quantidade: {product.Quantity}, Valor total: {total}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
