

using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace _4.Design_Patterns.Creational_Design_Pattern
{
    public class FactoryMethodDesignPattern
    {
        //public class IslakHamburger
        //{
        //    public List<string> Malzemeler { get; set; }
        //    public double Fiyat { get; set; }
        //    public string ÜrünAdı { get; set; }
        //}
        //public void Siparis(IslakHamburger istek)
        //{
        //    //ürün adı boş ise throw atılacaktır.
        //    ArgumentNullException.ThrowIfNullOrEmpty(istek.ÜrünAdı);

        //    Console.WriteLine($"{istek.ÜrünAdı} siparişiniz {istek.Fiyat} TL tutarında hazırlanmıştır.");
        //}

        public abstract class Ürün
        {
            public abstract void Siparis();
            public List<string> Malzemeler { get; set; }
            public double Fiyat { get; set; }
            public string ÜrünAdı { get; set; }
        }
        public class IslakHamburger : Ürün
        {
            public override void Siparis()
            {
                Console.WriteLine($"{ÜrünAdı} IslakHamburger siparişiniz {Fiyat} TL tutarında hazırlanmıştır.");
            }
        }
        public class Patso : Ürün
        {         
            public override void Siparis()
            {
                 Console.WriteLine($"{ÜrünAdı} Patso siparişiniz {Fiyat} TL tutarında hazırlanmıştır.");
            }
        }
        public class Creater
        {
            public Ürün FactoryMethod(Ürünler ürünTipi)
            {
                Ürün ürün;

                _ = ürünTipi switch
                {
                    Ürünler.Patso =>  ürün = new Patso(),
                    Ürünler.IslakHamburger => ürün = new IslakHamburger(),
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
