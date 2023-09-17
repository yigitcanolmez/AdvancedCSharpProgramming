using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Design_Patterns.Creational_Design_Pattern.BuilderPattern
{
    public class BuilderDesignPattern
    {
        public enum FoodType
        {
            FastFood,
            ItalianFood,
            VeggieFood,
            ChineseFood
        }
        public class Food
        {
            public FoodType FoodType { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public bool IsSpicy { get; set; }
        }
        public class Builder
        {
            protected Food _food = new();

            public Builder SetFoodType(FoodType foodType)
            {
                _food.FoodType = foodType;
                return this;
            }

            public Builder SetName(string name)
            {
                _food.Name = name;
                return this;
            }

            public Builder SetPrice(double price)
            {
                _food.Price = price;
                return this;
            }

            public Builder SetIsSpicy(bool isSpicy)
            {
                _food.IsSpicy = isSpicy;
                return this;
            }

            public Food Build()
            {
                return _food;
            }
        }

        public class ItalianFood : Food
        {
            public class ItalianFoodBuilder : Builder
            {
                public ItalianFoodBuilder()
                {
                }
            }
        }   
        public class FastFood : Food
        {
            public class FastFoodBuilder : Builder
            {
                public FastFoodBuilder()
                {
                }
            }
        }


    }
}
