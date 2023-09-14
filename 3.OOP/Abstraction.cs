using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.OOP
{
    public class Abstraction
    {
        abstract class BaseModel
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Save()
            {
                return ($"adı :{Name} \nsoyadı:{Surname} olarak kaydedildi");
            }
            public abstract string Delete();
        }

        class Teacher : BaseModel
        {
            public override string Delete()
            {
                throw new NotImplementedException();
            }
        }

        interface IDatabaseOperation
        {
            void Ekle();
            void Guncelle();
        }
        class Customer : IDatabaseOperation
        {
            public void Ekle()
            {
                throw new NotImplementedException();
            }

            public void Guncelle()
            {
                throw new NotImplementedException();
            }
        }
    }
}
