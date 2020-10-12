using System;
using System.Collections.Generic;

namespace graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<string> cities = new Graph<string>();

            cities.Add("Sofiq");
            cities.Add("Ruse");
            cities.Add("Burgas");
            cities.Add("Varna");
            cities.Add("Plovdiv");
            cities.Add("Asenovgrad");

            cities.Connect("Sofiq", "Plovdiv");
            cities.Connect("Plovdiv", "Asenovgrad");
            cities.Connect("Asenovgrad", "Burgas");
            cities.Connect("Plovdiv", "Burgas");           
            cities.Connect("Burgas", "Varna");
            cities.Connect("Sofiq", "Varna");
            cities.Connect("Burgas", "Ruse");
            cities.Connect("Varna", "Ruse");
            //sofia plovdiv asenovgrad burgas varna ruse

            var result = cities.ToplogicalSort();

            foreach (var res in result)
            {
                Console.WriteLine(res.ToString());
            }
           






        }
    }
}
