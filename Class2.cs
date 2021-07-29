using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace vehicle121
{
    abstract class marks
    {
        abstract public float  getPercentage();

    }
    class A : marks
    {
        int[] ar = new int[3];
        internal A(int[] a) : base()
        {
            ar = a;
        }
        public override float getPercentage()
        {
            float sum = 0;
            for(int i = 0; i < 3; i++)
            {
                sum = sum + ar[i];
                //Console.WriteLine(sum);
            }
            Console.WriteLine(sum);
            float c = (sum /300) * 100;
            return c;

        }

    }
    class B : marks
    {
        int[] br = new int[4];
        internal B(int[] b) : base()
        {
            br = b;
        }
        public override float getPercentage()
        {
            float sum = 0;
            for (int i = 0; i <4; i++)
            {
                sum = sum + br[i];
            }
            Console.WriteLine(sum+" "+sum/400);
            float d = (sum / 400) * 100;
            return d;
        }
    }
    class Class2
    {
        static void Main(String[] args)
        {
            int[] n = new int[10];
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("enter marks A");
                n[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            A stuA = new A(n);
            float amarks = stuA.getPercentage();
            Console.WriteLine("percentage of A is----------" + amarks + " %");

            int[] w = new int[10];
            
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("enter marks B");
                w[i] = Convert.ToInt32(Console.ReadLine());
               
            }
            B stuB = new B(w);

           
            float bmarks = stuB.getPercentage();
            Console.WriteLine("percentage of B is----------" + bmarks + " %");

        }


    }
}
