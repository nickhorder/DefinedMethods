using System;

namespace DefinedMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //DEFINED METHOD - VISITPLANETS
            {
                VisitPlanets();
            }

            static void VisitPlanets()
            {
                Console.WriteLine("You visited many new planets...");
            }
            //DEFINED METHOD WITH STATIC PARAMETER AND DEFAULT VALUE (0)
            {
                VisitPlanetsTwo(3);
                VisitPlanetsTwo(4);
                VisitPlanetsTwo(5);
                VisitPlanetsTwo();
            }
            static void VisitPlanetsTwo(int numberOfPlanets = 0)
            {
                Console.WriteLine($"You visited {numberOfPlanets} new planets...");
            }
            //DEFINED METHOD WITH NAMED ARGUMENTS
            {
                // AddSomeNumbers(); // Will return the defined parms
                AddSomeNumbers(intro: "Here is zero", small: 0); //overriding value of small to be 0
            }
            static void AddSomeNumbers(string intro = "The Number Is:",
                                       int small = 1)
            {
                Console.WriteLine($"{intro} {small}");
            }
            // METHOD OVERLOAD 
            /*
       * Though they have the same name, the overloads are different because they have either 
       * (i) different parameter types or 
       * (ii) different number of parameters.
       * This is useful if you want the same method to have different behavior based on its inputs.
       */            
// Note the lack of } here
                NamePets("Laika", "Albert");
                NamePets("Albert", "Puddy", "Bucket");
                NamePets();
            }
            static void NamePets(string pet1, string pet2)
            {
             Console.WriteLine($"Your pets {pet1} and {pet2} will be joining your voyage " +
                 $"across space!");
            }
            static void NamePets(string pet1, string pet2, string pet3)
            {
             Console.WriteLine($"Your pets {pet1}, {pet2}, and {pet3} will be joining your " +
                 $"voyage across space!");
            }
        static void NamePets()
        {
            Console.WriteLine("Aw, you have no spacefaring pets :(");
        }
    }
    }

    
