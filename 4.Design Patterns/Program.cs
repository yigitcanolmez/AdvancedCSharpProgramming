// See https://aka.ms/new-console-template for more information
using static _4.Design_Patterns.Creational_Design_Pattern.FactoryMethodDesignPattern;

//Console.WriteLine("Hello, World!");


Creater creater = new Creater();

Ürün ıslakHamburger = creater.FactoryMethod(Ürünler.IslakHamburger);
Ürün patso = creater.FactoryMethod(Ürünler.Patso);

ıslakHamburger.ÜrünAdı = "Meksika Acılı";
ıslakHamburger.Fiyat = 80;

ıslakHamburger.Siparis();

patso.ÜrünAdı = "Amerikan Salatalı";
patso.Fiyat = 70;

patso.Siparis();

//IslakHamburger ıslak = new IslakHamburger();
//Patso patso =new Patso();