using System.Collections.Generic;

List<string> employees = new List<string>() { "adam", "amy" };
employees.Add("barbara");
employees.Add("billy");

Console.WriteLine("My employees include {0}, {1}, {2}, {3}", employees[0], employees[1], employees[2], employees[3]);