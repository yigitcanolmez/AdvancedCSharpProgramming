using _3.OOP;

Encapsulation encapsulation = new Encapsulation() { Id = Guid.NewGuid(), Identity = "12312312312", Name = "Yılmaz" };

encapsulation.SetPersonSalary(12000);
var salary = encapsulation.GetSalary();

Console.WriteLine(salary);

Console.ReadKey();