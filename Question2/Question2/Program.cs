using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to ");
            Employee employee1 = new Employee ("Name Unknown", 0, 0);

            
            Console.WriteLine("\nPlease enter in the employee's name");
            employee1.Name = Console.ReadLine();

            Console.WriteLine("\nPlease enter in their annual gross salary");
            employee1.Gross = float.Parse(Console.ReadLine());

            Console.WriteLine("\nPlease enter in their tax rate");
            employee1.Tax = float.Parse(Console.ReadLine());

            Console.WriteLine($"\nThe employees name is: {employee1.Name}");
            Console.WriteLine($"The employees annual gross salary is: {employee1.Gross}");
            Console.WriteLine($"The employees tax rate is: {employee1.Tax}%");
            Console.WriteLine($"The employees net salary is: {employee1.CalcNet()}");

            Console.ReadLine();


        }

        class Employee
        {
            //private properties
            private string name;
            private float gross;
            private float tax;

            //Public getters and setters
            public string Name { get { return name; } set { name = value; } }
            public float Gross { get { return gross; } set { gross = value; } }
            public float Tax { get { return tax; } set { tax = value; } }

            
            //Public constructor
            public Employee(string _name, float _gross, float _tax)
            {
                Name = _name;
                Gross = _gross;
                Tax = _tax;

                Console.WriteLine("\nEmployee record created...");

            }


            //Public method
            public float CalcNet()
            {
                return gross*(1-tax/100);
            }



        }
    }
}
