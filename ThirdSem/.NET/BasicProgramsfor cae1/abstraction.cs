using System;

namespace AbstractionExample
{
    // Abstract class
    abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void MakeSound();

        // Regular method
        public void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }
    }

    // Derived class (inheriting from Animal)
    class Dog : Animal
    {
        // Providing the implementation of the abstract method
        public override void MakeSound()
        {
            Console.WriteLine("Woof Woof");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();

            myDog.MakeSound(); // Outputs: Woof Woof
            myDog.Sleep();     // Outputs: Sleeping...

            // You cannot create an instance of an abstract class
            // Animal myAnimal = new Animal(); // This will cause a compile-time error
        }
    }
}
