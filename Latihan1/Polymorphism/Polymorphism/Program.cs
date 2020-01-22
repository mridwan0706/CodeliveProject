using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Shape
    {
        protected int length;
        protected int width;
        protected int height;
        protected int side;
        protected double Radius;
        protected double phi;
        protected double Base;

        public void setWidth(int width)
        {
            this.width = width;
        }
        public void setHeight(int height)
        {
            this.height = height;
        }
        public void setLength(int length) => this.length = length;
        public void setSide(int side) => this.side = side;
        public void setRadius(double Radius) => this.Radius = Radius;
        public double getPhi()
        {
            return 3.14;
        }
        public void setBase(double Base)=>this.Base =Base;

        
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Rectangle Rect = new Rectangle();
            //Rect.setWidth(5);
            //Rect.setHeight(7);
            //Console.WriteLine("Area : " + Rect.getArea());


            //Interpolasi String
            //string nama = "Muhammad Ridwan";
            //var date = DateTime.Now;            
            //Console.WriteLine("Hello {0} dan sekarang hari {1} sekarang pukul {2:HH:mm}", nama, date.DayOfYear, date);
            //Console.WriteLine($"Hallo, {nama} sekarang hari {date.DayOfWeek} sekarang pukul {date:HH:mm}");
            //Console.ReadKey();

            var retry = true;
            while (retry)
            {
                


                Console.WriteLine("Choose [1] - Calculate Area & Around Rectangle. ");
                Console.WriteLine("Choose [2] - Calculate Area & Around Square. ");
                Console.WriteLine("Choose [3] - Calculate Area & Around Circle. ");
                Console.WriteLine("Choose [4] - Calculate Area & Around Right Triangle. ");
                Console.WriteLine("Choose [5] - Calculate Area & Around Scalene Angle. ");
                retry = false;
                Console.Write("Input Your Choose: ");
                int pil = Convert.ToInt32(Console.ReadLine());
                switch (pil)
                {
                    case 1:
                        Rectangle Rect = new Rectangle();
                        Console.Write("Input Height : ");
                        Rect.setHeight(Convert.ToInt32(Console.ReadLine()));
                        Console.Write("Input Width : ");
                        Rect.setWidth(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Reactangle Area: {0}", Rect.getArea());
                        Console.WriteLine("Rectangle Around: {0}", Rect.getAround());
                        break;
                    case 2:
                        Square Squ = new Square();
                        Console.Write("Input Side  : ");
                        Squ.setSide(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Square Area: {0}", Squ.getArea());
                        Console.WriteLine("Square Around: {0}", Squ.getAround());
                        break;
                    case 3:
                        Circle Cir = new Circle();
                        Console.Write("Input Radius  : ");
                        Cir.setRadius(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Circle Area: {0}", Cir.getArea());
                        Console.WriteLine("Circle Around: {0}", Cir.getAround());
                        break;                    
                    default:                
                        Console.WriteLine("Sorry, Your Choose is not Available. Please, Try Again.");                      
                        retry = true;
                        break;
                }
                Console.ReadKey();
            
            }
        }
    }

  
}
