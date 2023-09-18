using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Design_Patterns.Creational_Design_Pattern.Prototype_Pattern
{
    internal class PrototypePattern
    {
        public abstract class EmployeePrototype
        {
            public string Name { get; set; }
            public int EmployeeId { get; set; }
            public DateTime HireDate { get; set; }

            public abstract EmployeePrototype Clone();
            public abstract void DisplayInfo();
        }

        // ConcretePrototype (Somut Prototip)
        public class Employee : EmployeePrototype
        {
            public string Position { get; set; }
            public decimal Salary { get; set; }

            public override EmployeePrototype Clone()
            {
                // MemberwiseClone ile yeni bir nesne oluşturulur.
                return (Employee)this.MemberwiseClone();
            }

            public override void DisplayInfo()
            {
                Console.WriteLine($"Çalışan Bilgileri: {Name}, ID: {EmployeeId}, Pozisyon: {Position}, Maaş: {Salary:C}, İşe Giriş Tarihi: {HireDate:d}");
            }
        }
        class Program
        {
            static void Main()
            {
                // Örnek bir çalışan oluştur
                Employee originalEmployee = new Employee
                {
                    Name = "John Doe",
                    EmployeeId = 12345,
                    Position = "Mühendis",
                    Salary = 75000.0m,
                    HireDate = DateTime.Parse("2020-05-15")
                };
                originalEmployee.DisplayInfo();

                // Çalışanın bir kopyasını oluştur
                Employee clonedEmployee = (Employee)originalEmployee.Clone();
                clonedEmployee.Name = "Jane Doe"; // Kopyalanan çalışanın özelliklerini değiştir
                clonedEmployee.DisplayInfo();

                // İstemci, prototip nesnesini kullanarak yeni çalışanları kopyalayabilir
            }
        }
    }
}
