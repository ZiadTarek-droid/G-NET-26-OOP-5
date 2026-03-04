using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.ComponentModel;

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

            #region Q2
            //a) What is the problem with this design?

            //Both interfaces(IEnglishSpeaker and IArabicSpeaker) contain a method called Greet().
            
            //Currently, the class implements one public method:
            
            //public void Greet()
            //        {
            //            Console.WriteLine("Hello / Ahlan");
            //        }
            
            //        This single implementation satisfies both interfaces.
            
            //        Problem:
            //We cannot provide different behavior for each interface. Both will call the same method.
            
            //b) How to fix it?
            
            //We use Explicit Interface Implementation.
            
            //class Translator : IEnglishSpeaker, IArabicSpeaker
            //        {
            //            void IEnglishSpeaker.Greet()
            //            {
            //                Console.WriteLine("Hello");
            //            }
            
            //            void IArabicSpeaker.Greet()
            //            {
            //                Console.WriteLine("Ahlan");
            //            }
            //        }
            
            //        This technique is called:
            // Explicit Interface Implementation
            
            //c) Can we call translator.Greet() directly?
            
            // No.
            
            //Because explicit implementations are not public methods of the class itself.
            
            //You must cast to the interface:
            
            //Translator translator = new Translator();
            
            //        ((IEnglishSpeaker) translator).Greet();  Hello
            //        ((IArabicSpeaker) translator).Greet();   Ahlan
        #endregion
    }
    }
}
