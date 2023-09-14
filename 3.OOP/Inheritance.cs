namespace _3.OOP
{
    public class BaseClass
    {
        public int Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public void DoSth()
        {
            Console.WriteLine("Base Class Method");
        }
    }

    public class DerivedClass : BaseClass
    {
    }

    public class SecondDerivedClass : DerivedClass
    {
        public string Size { get; set; }
    }

}
