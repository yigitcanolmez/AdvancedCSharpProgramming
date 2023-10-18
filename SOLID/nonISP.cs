using System;
namespace SOLID
{
    //public interface IAnimal
    //{
    //    void Fly();
    //    void Bark();
    //    void Run();
    //}
    public interface IFly
    {
        void Fly();
    }
    public interface IBark
    {
        void Bark();
    }
    public interface IRun
    {
        void Run();
    }
    public class Cat : IRun
    {
        public void Run()
        {
            Console.WriteLine("Cat is running");
        }
    }

}

