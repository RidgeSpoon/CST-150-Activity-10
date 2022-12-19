//Corrected by Ridge D Witherspoon
//Ridge D Witherspoon CST-150 12/18/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here I found a fundamental error when creating a set object. It is necessary
            //to attach a namespace from where to pull the information from. 
            //"make some sets"
            //Set A = new Set();
            //Set B = new Set();
            Activity_10.Set A = new Activity_10.Set();
            Activity_10.Set B = new Activity_10.Set();

            //put some stuff in the sets
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                A.addElement(r.Next(4));
                B.addElement(r.Next(12));
            }

            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine("A union B: " + A.union(B));

            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);

        }
    }
}