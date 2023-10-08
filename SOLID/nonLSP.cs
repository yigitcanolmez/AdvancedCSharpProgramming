using System;
namespace SOLID
{
    public abstract class Bird
    {
        public abstract void Move();
    }
    public class Sparrow : Bird
    {
        public override void Move()
        {
            Console.WriteLine("Sparrow Flying");
        }
    }
    public class Canary : Bird
    {
        public override void Move()
        {
            Console.WriteLine("Canary Flying");
        }
    }
    public class Ostrich : Bird
    {
        public override void Move()
        {
            Console.WriteLine("Ostrich Running!");
        }
    }
    //public abstract class Bird
    //{
    //	public abstract void Fly();
    //}
    //   public class Sparrow : Bird
    //   {
    //       public override void Fly()
    //       {
    //           Console.WriteLine("Sparrow Flying");
    //       }
    //   }
    //   public class Canary : Bird
    //   {
    //       public override void Fly()
    //       {
    //           Console.WriteLine("Canary Flying");
    //       }
    //   }
    //   public class Ostrich : Bird
    //   {
    //       public override void Fly()
    //       {
    //           Console.WriteLine("Ostrich Flying");
    //       }
    //   }
}

