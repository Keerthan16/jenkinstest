using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle121
{
    abstract class Car1
    {
        public string regno { get; set; }
        internal Car1(string r)
        {
            regno = r;
        }
        public static void OpenTank()
        {
            Console.WriteLine("open tank to fill petrol/diesel");
        }
        abstract public void steering(int d, int a);
        abstract public void braking(int f);

    }
    class Mahindra:Car1
    {
        internal Mahindra(string r) : base(r)
        {

        }
        public override void steering(int d, int a)
        {
            Console.WriteLine("direction:{0},angle:{1}",d,a);
        }
        public override void braking(int f)
        {
            Console.WriteLine("force:{0}", f);
        }

    }
    class Tata :Car1
    {
        internal Tata(string r1) : base(r1)
        {

        }
        public override void braking(int f)
        {
            Console.WriteLine("force:{0}", f);
        }
        public override void steering(int d, int a)
        {
            Console.WriteLine("direction:{0},angle:{1}", d, a);
        }
    }
    
    
    class Class1
    {
        
        static void Main()
        {
            Tata t1 = new Tata("MH42BD1197");
            t1.braking(21);
            t1.steering(2, 35);
            Car1.OpenTank();
            Mahindra m1 = new Mahindra("MH32AC1867");
            m1.braking(45);
            m1.steering(3, 45);
            Mahindra.OpenTank();      //you can also access static method of parent classs with child class name

        }

    }
}
