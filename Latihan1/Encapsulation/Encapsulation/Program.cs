using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    //PUBLIC 
    //class Rectangle
    //{
    //    //member variabel menggunakan akses public
    //    public double length;
    //    public double width;

        

    //    public double GetArea()
    //    {
    //        return length * width;
    //    }
    //    public void Display()
    //    {
    //        Console.WriteLine("Length : {0}", length);
    //        Console.WriteLine("Width :{0}", width);
    //        Console.WriteLine("Area : {0}", GetArea());
    //    }
    //} //end class Rectangle

    class Rectangle
    {
        private double length;
        private double width;

        public void Acceptdetails()
        {
            Console.WriteLine("Enter Length : ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width : ");
            width = Convert.ToDouble(Console.ReadLine());

        }
        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length : {0}", length);
            Console.WriteLine("Width : {0}", width);
            Console.WriteLine("Area : {0}", GetArea());
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            //Access PUBLIC 

            //Rectangle r = new Rectangle();           
            //r.length = 8;
            //r.width = 5;
            //r.Display();
            //Console.ReadKey();



            //Access PRIVATE

            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();


        }
    }
}
