using EMP;
using MNG;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello World, This Is Somesh Prem, Live From Planet Earth ! ");

//int id,string name,double salary,string email,string address

Employee E1 = new Employee(101,"XYZ",15000,"xyz@g.com","Pune");

Manager M1 = new Manager(500,500,201,"LMN",25000,"lmn@g.com","Mumbai");

Console.WriteLine(E1);
Console.WriteLine(M1);

Console.WriteLine(E1.ComputeSalary());
Console.WriteLine(M1.ComputeSalary());




