using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

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

            #region Q3
            //Difference between Shallow Copy and Deep Copy

            //Shallow Copy Deep Copy
            //Copies value types normally Copies value types normally
            //Copies reference types by reference Creates new independent copies of reference objects
            //Both objects share same reference fields    Objects are fully independent

            //When to use each?

            //Use Shallow Copy when object contains only value types.

            //Use Deep Copy when object contains reference types and you need full independence.

            //Risk of Shallow Copy

            //If object has reference - type fields, both copies will reference the same object.

            //Changing one will affect the other.
            #endregion

            #region Q4
            //Code Analysis
            //var e1 = new Employee { Title = "Dev", Dept = new Department { Name = "IT" } };
            //            var e2 = e1.ShallowCopy();
            //            e2.Title = "QA";
            //            e2.Dept.Name = "Testing";
            
            //            ShallowCopy() uses MemberwiseClone() → shallow copy.
            
            //So:
            
            //            Title(string reference but reassigned) → independent
            
            //Dept(reference type) → shared between e1 and e2
            
            //Output:
            //Dev - Testing
            //QA - Testing
            //Why?
            
            //e2.Title = "QA" only affects e2.
            
            //e2.Dept.Name = "Testing" affects both objects because Dept is shared.
            #endregion

        }
    }
}
