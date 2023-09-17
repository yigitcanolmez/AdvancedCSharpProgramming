//const double pi = 3.14;

//Console.Write("Radius Value :");
//int radius = int.Parse(Console.ReadLine());

//var area = pi * radius * radius;

//Console.WriteLine(area);

//Console.Read();

Console.WriteLine();
//https://medium.com/@yigitcanolmez/jenkins-nedir-ne-i%CC%87%C5%9Fe-yrar-47964526a968







//Food pasta = new Food(foodType: FoodType.FastFood,
//                      name: "Yiqido Special",
//                      price: 99.90,
//                      isSpicy: false);

//Food sushi = new Food(FoodType.ChineseFood,
//                      "SUSHİ",
//                      129.99,
//                      true);

//pasta.Prepare();
//sushi.Prepare();









//public class Food
//{
//    private FoodType _foodType { get; set; }
//    private string _name { get; set; }
//    private double _price { get; set; }
//    private bool _isSpicy { get; set; }

//    public Food(FoodType foodType, string name, double price, bool isSpicy)
//    {
//        _foodType = foodType;
//        _name = name;
//        _price = price;
//        _isSpicy = isSpicy;
//    }

//    public void Prepare()
//    {
//        var spicy = _isSpicy ? "Spicy" : string.Empty;

//        _ = _foodType switch
//        {
//            FoodType.FastFood => Console.WriteLine($"{nameof(FoodType.FastFood)} {_name} {_price} {spicy}"),
//            FoodType.ItalianFood => Console.WriteLine($"{nameof(FoodType.ItalianFood)} {_name} {_price} {spicy}"),
//            FoodType.VeggieFood => Console.WriteLine($"{nameof(FoodType.VeggieFood)} {_name} {_price} {spicy}"),
//            FoodType.ChineseFood => Console.WriteLine($"{nameof(FoodType.ChineseFood)} {_name} {_price} {spicy}"),
//            _ => Console.WriteLine("Error")
//        };
//    }
//}

//public enum FoodType
//{
//    FastFood,
//    ItalianFood,
//    VeggieFood,
//    ChineseFood
//}
