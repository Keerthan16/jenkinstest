using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle121
{
    class vehicle1
    {
        protected string regnNumber { get; set; }
        protected int  speed { get; set; }
        protected string colour { get; set; }

        protected string ownername { get; set; }

        public vehicle1(string r,int s,string c,string o)
        {
            regnNumber = r;
            speed = s;
            colour = c;
            ownername = o;
        }

        public static void showMethod()
        {
            Console.WriteLine("this is a vehicle class");
        }

        public void showdata()
        {
            
            Console.WriteLine("registration no--:{0}", regnNumber);
            Console.WriteLine("max speed--" + speed);
            Console.WriteLine("colour--" + colour);
            Console.WriteLine("onwername--" + ownername);
        }


    }
    class Bus:vehicle1
    {
        private int Routenumber { get; set; }
        internal Bus( int ro,string r, int s1, string c, string o):base(r,s1,c,o)
        {
            Routenumber = ro;
        }
        public void showData()
        {
            vehicle1.showMethod();
            showdata();
            Console.WriteLine("bus route no is:{0} ", Routenumber);
        }
    }
    class Car : vehicle1
    {
        private string ManufacturersName{ get; set; }
        internal Car(string r, int s, string c, string o, string Mn) : base(r,s,c,o)
        {
            ManufacturersName = Mn;
           
        }
        public void showData()
        {
            //base.showdata();
            vehicle1.showMethod();
            showdata();
            Console.WriteLine("manufacturers name no is:{0} ", ManufacturersName);
        }
    }
    class info
    {
        static void Main()
        {
            Console.WriteLine("enter registration number");
            string r = Console.ReadLine();
            Console.WriteLine("enter speed");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter colour");
            string c = Console.ReadLine();
            Console.WriteLine("owner name");
            string o = Console.ReadLine();
            Console.WriteLine("enter Bus route no");
            int bs= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter manufacturers name");
            string mn= Console.ReadLine();

            Bus b1 = new Bus(bs, r, s, c, o);
            b1.showData();
            Car c1 = new Car(r, s, c, o, mn);
            c1.showData();

        }
    }

}
