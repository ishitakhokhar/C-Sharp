using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Create a class Furniture with material, price as data members.
//Createanother class Table with Height, surface_area as data members. Write a
//program to implement single inheritance.
namespace Lab_3
{
    internal class Furniture
    {
        public string material;
        public double price;
    }
    class Table:Furniture
    {
        public double height;
        public double surfaceArea;

        public Table(String material,double price,double height, double surfaceArea)
        {
            this.material = material;
            this.price = price;
            this.height = height;
            this.surfaceArea = surfaceArea;
        }
        public void Display()
        {
            Console.WriteLine("Material : "+material);
            Console.WriteLine("Price : "+price);
            Console.WriteLine("Height : " + height);
            Console.WriteLine("SurfaceArea : "+surfaceArea);
        }
    }
}
