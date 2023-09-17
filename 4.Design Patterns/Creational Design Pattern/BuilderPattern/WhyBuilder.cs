using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _4.Design_Patterns.Creational_Design_Pattern.BuilderPattern
{
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

  
}
