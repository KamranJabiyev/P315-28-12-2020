using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSealed
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Abstract
            //Eagle eagle = new Eagle();
            //eagle.Eat();
            #endregion

            #region Interface
            #endregion

            #region Sealed
            Student student = new Student("Kenan", "Memmedli");
            Software sd = new Software("Mehemmedeli","Abbaszade");
            sd.GetInfo();
            #endregion
        }
    }

    #region Sealed
    public abstract class Person 
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Person(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"{Name} {Surname}");
        }
    }

    class Engineer:Person
    {
        public Engineer(string name, string surname) : base(name, surname)
        {
        }

        public sealed override void GetInfo()
        {
            Console.WriteLine("in Engineer class");
        }
    }

    class Software : Engineer
    {
        public Software(string name, string surname) : base(name, surname)
        {
        }

        //public override void GetInfo()
        //{
        //    Console.WriteLine("in Software class");
        //}
    }

    //sealed class- can not get inheretance from sealed class
    public sealed class Student:Person
    {
        public Student(string name,string surname):base(name,surname)
        {
        }
    }
    #endregion

    #region Interface
    //interface IRun
    //{
    //    void Run();
    //    void RunSpeed(int speed);
    //}

    //interface IEat
    //{
    //    void Eat();
    //}

    //class Test
    //{

    //}

    //class Person : Test,IRun,IEat
    //{
    //    public void Eat()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Run()
    //    {
    //        Console.WriteLine("Run as Person");
    //    }

    //    public void RunSpeed(int speed)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //class Rabbit : IRun
    //{
    //    public void Run()
    //    {
    //        Console.WriteLine("Run as Rabbit");
    //    }

    //    public void RunSpeed(int speed)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    #endregion

    #region Abstract
    //abstract class-can not get instance,abstract method and abstract property contains
    //abstract class Animal
    //{

    //    public Animal()
    //    {
    //        Console.WriteLine("Animal created");
    //    }
    //    public abstract int MyProperty { get; set; }
    //    public abstract void Eat();

    //    public virtual void Test()
    //    {
    //        Console.WriteLine("Test in abstract");
    //    }
    //}

    //abstract class Bird:Animal
    //{
    //    public abstract void Fly();
    //}

    //class Eagle : Bird
    //{
    //    public override int MyProperty { get ; set; }

    //    public override void Eat()
    //    {
    //        Console.WriteLine("Eat as eagle");
    //    }

    //    public override void Fly()
    //    {
    //        Console.WriteLine("Fly as Eagle");
    //    }

    //    public override void Test()
    //    {
    //        Console.WriteLine("Test in Eagle");
    //    }
    //}
    #endregion
}
