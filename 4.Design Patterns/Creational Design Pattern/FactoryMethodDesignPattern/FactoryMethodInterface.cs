using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _4.Design_Patterns.Creational_Design_Pattern.FactoryMethodAbstract;

namespace _4.Design_Patterns.Creational_Design_Pattern.FactoryMethodDesignPattern
{
    public class FactoryMethodInterface
    {
        public interface IUrun
        {
            void Siparis();

        }
        public class Patso : IUrun
        {
            public void Siparis()
            {
                Console.WriteLine("Patso siparişi hazırlandı!");
            }
        }
        public class IslakHambuger : IUrun
        {
            public void Siparis()
            {
                Console.WriteLine("Islak Hambuger siparişi hazırlandı!");
            }
        }
        public class Creater
        {
            public IUrun FactoryMethod(Ürünler ürünTipi)
            {
                IUrun ürün;

                _ = ürünTipi switch
                {
                    Ürünler.Patso => ürün = new Patso(),
                    Ürünler.IslakHamburger => ürün = new IslakHambuger(),
                    _ => throw new ArgumentException("error")
                };

                return ürün;
            }
        }
        public enum Ürünler
        {
            IslakHamburger,
            Patso
        }
    }
}
