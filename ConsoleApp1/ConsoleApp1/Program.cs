using System;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        new Application();
    }
}

public class Application
{
    public Application()
    {

        Dictionary<string, Car> dvla = new Dictionary<string, Car>();

        Car a = new Car();
        a.manufacturer = "Audi";
        a.year = 2008;
        dvla.Add("EN08YGL", a );
        Car r = new Car();
        r.manufacturer = "Audi";
        r.year = 2021;
        r.model = "RS3";
        dvla.Add("RS3FLY", r);
        
        while (true)

        {
            Console.WriteLine("PLEASE ENTER REG OR CLICK x TO ADD");
            string input = Console.ReadLine();

            if (input == "") break;

            if (dvla.ContainsKey(input))
            {

                Car info = dvla[input];  
                Console.WriteLine(info.manufacturer );
                Console.WriteLine(info.year);
                Console.WriteLine(info.model);
            }
            if (input == "x")
            {
                Console.WriteLine("PLEASE ENTER REG");
                string reg = Console.ReadLine();
                Console.WriteLine("PLEASE ENTER YEAR");
                int year = Convert.ToInt32(Console.ReadLine());
                Car d = new Car();
                d.year = year;
                dvla.Add(reg, d);
            }
        }
    }

    class Car
    {
        public string manufacturer;
        public int year;
        public string model; 
        
    }
 }
