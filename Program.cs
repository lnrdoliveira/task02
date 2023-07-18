using System;
using System.Globalization;
using task02;
class Program{
    static void Main(String [] args){
        Employee firstEmployee, secondEmployee;
        firstEmployee = new Employee();
        secondEmployee = new Employee();

        System.Console.WriteLine("Infos about first employee: ");
        System.Console.Write("Name: ");
        firstEmployee.Name = Console.ReadLine();
        System.Console.Write("Wage: ");
        firstEmployee.Wage = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Infos about second employee: ");
        System.Console.Write("Name: ");
        secondEmployee.Name = Console.ReadLine();
        System.Console.Write("Wage: ");
        secondEmployee.Wage = double.Parse(Console.ReadLine());

        double averagePay = (firstEmployee.Wage + secondEmployee.Wage)/2;
        System.Console.WriteLine("Average pay: $"+ averagePay.ToString("F2", CultureInfo.InvariantCulture));
    }
}