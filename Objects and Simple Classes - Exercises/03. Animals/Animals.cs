namespace _03.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Dog
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int NumberOfLegs { get; set; }

        public static void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }
    }

    public class Cat
    {
        public string Name{ get; set; }

        public int Age { get; set; }

        public int IntelligenceQuotient { get; set; }

        public static void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }
    }

    public class Snake
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int CrueltyCoefficient { get; set; }

        public static void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }
    }

    public class Animals
    {
        public static void Main()
        {
            List<Dog> dogs = new List<Dog>();
            List<Cat> cats = new List<Cat>();
            List<Snake> snakes  = new List<Snake>();

            
            string[] userInput = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            while (userInput[0] != "I'm")
            {
                string name = userInput[1];

                if (userInput[0] != "talk")
                {
                    string clas = userInput[0].ToLower();
                    int age = int.Parse(userInput[2]);
                    int lastParameter = int.Parse(userInput[3]);
                    
                    //Add the params to the classes
                #region Add the Paramiters to the classes                  
                    switch (clas)
                    {
                        case "dog":
                            Dog newDog = new Dog()
                            {
                                Name = name,
                                Age = age,
                                NumberOfLegs = lastParameter
                            };
                            dogs.Add(newDog);
                            break;
                        case "cat":
                            Cat newCat = new Cat()
                            {
                                Name = name,
                                Age = age,
                                IntelligenceQuotient = lastParameter
                            };
                            cats.Add(newCat);
                            break;
                        case "snake":
                            Snake newSnake = new Snake()
                            {
                                Name = name,
                                Age = age,
                                CrueltyCoefficient = lastParameter
                            };
                            snakes.Add(newSnake);
                            break;

                    }
#endregion
                }
                else
                {
                    CheckForTheNameInLists(dogs, cats, snakes, name);
                }

                userInput = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            }

            PrintThemAll(dogs,cats,snakes);

        }

        static void PrintThemAll(List<Dog> dogs, List<Cat> cats, List<Snake> snakes)
        {
            foreach (var dog in dogs)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }

            foreach (var cat in cats)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IntelligenceQuotient}");
            }

            foreach (var snake in snakes)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
            }
        }

        static void CheckForTheNameInLists(List<Dog> dogs, List<Cat> cats, List<Snake> snakes, string name)
        {
            foreach (var dog in dogs)
            {
                if (dog.Name == name)
                {
                    Dog.ProduceSound();
                    break;
                }
            }

            foreach (var cat in cats)
            {
                if (cat.Name == name)
                {
                    Cat.ProduceSound();
                    break;
                }
            }

            foreach (var snake in snakes)
            {
                if (snake.Name == name)
                {
                    Snake.ProduceSound();
                    break;
                }
            }
        }
    }
}
