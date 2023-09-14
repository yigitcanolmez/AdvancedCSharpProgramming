using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.OOP
{

    public class Language
    {
        public virtual void Speak()
        {
            Console.WriteLine("HELLO!");
        }
    }

    public class Turkish : Language
    {
        public override void Speak()
        {
            Console.WriteLine("Merhaba");
        }

    }

    public class German : Language
    {
        public override void Speak()
        {
            Console.WriteLine("Hallo");
        }

    }
    public class Italian : Language
    {
        public override void Speak()
        {
            Console.WriteLine("Ciao");
        }

    }

}
