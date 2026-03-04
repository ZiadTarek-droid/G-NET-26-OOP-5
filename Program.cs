using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //What is an interface in C#?

            //An interface in C# is a contract that defines a set of methods, properties, or events that a class must implement.
            //It contains only method/property signatures (no implementation).
            //------------------------------------------------------
            //Example:
            //interface IPrintable
            //        {
            //            void Print();
            //        }
            //        Any class that implements this interface must provide an implementation for Print().
            //-------------------------------------------------------
            //Why do we use interfaces instead of concrete classes directly?
            //We use interfaces to reduce tight coupling and depend on abstractions instead of implementations.
            //At least three benefits of using interfaces:
            //Loose Coupling
            //Classes depend on abstractions, not concrete implementations → easier to modify or replace components.
            //Polymorphism
            //Multiple classes can implement the same interface and be treated uniformly.
            //Testability
            //Interfaces allow mocking in unit testing.
            //Multiple Inheritance Support
            //C# does not support multiple class inheritance, but a class can implement multiple interfaces.
            #endregion
        }
    }
}
