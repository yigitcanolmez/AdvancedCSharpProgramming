//using static _4.Design_Patterns.Creational_Design_Pattern.FactoryMethodAbstract;

//Console.WriteLine("Hello, World!");

#region Factory Method Abstract Class
/*
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
*/
#endregion

#region Factory Method Interface

//using static _4.Design_Patterns.Creational_Design_Pattern.FactoryMethodDesignPattern.FactoryMethodInterface;

//Creater creater = new Creater();

//IUrun patso = creater.FactoryMethod(Ürünler.Patso);
//IUrun ıslakHamburger = creater.FactoryMethod(Ürünler.IslakHamburger);

//patso.Siparis();
//ıslakHamburger.Siparis();   



#endregion

#region WhyBuilder



#endregion








using static _4.Design_Patterns.Creational_Design_Pattern.BuilderPattern.BuilderDesignPattern;

Food italinaFood = new ItalianFood.ItalianFoodBuilder().SetName("Pizza")
                                                   .SetPrice(79.99)
                                                   .SetIsSpicy(true)
                                                   .SetFoodType(FoodType.ItalianFood)
                                                   .Build();

Food fastFood = new FastFood.FastFoodBuilder().SetName("Hamburger")
                                              .SetFoodType(FoodType.ItalianFood)
                                              .SetPrice(129.99)
                                              .Build();

Console.WriteLine($"{fastFood.Name} {fastFood.Price} {fastFood.FoodType}");

var spicy = italinaFood.IsSpicy ? "spicy" : string.Empty;
Console.WriteLine($"{italinaFood.Name} {italinaFood.Price} {italinaFood.FoodType} {spicy}");











