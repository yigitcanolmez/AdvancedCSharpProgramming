using _3.OOP;
using System;

Console.WriteLine("dsadasd :");
int a = Convert.ToInt16(Console.ReadLine());

//var a = (double)241 / (300 * 0.01);
//Console.WriteLine(string.Format("{0:0.0000}", a)
//);
Console.WriteLine("sssssssssssssssss");

Encapsulation encapsulation = new Encapsulation() { Id = Guid.NewGuid(), Identity = "12312312312", Name = "Yılmaz" };

encapsulation.SetPersonSalary(12000);
var salary = encapsulation.GetSalary();

Console.WriteLine(salary);

Console.ReadKey();