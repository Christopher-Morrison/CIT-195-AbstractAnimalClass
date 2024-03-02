using System;
namespace AbastractAnimalClass
{
    class Program
    { 
        abstract class Animal
        {
            // Property
            public abstract string Name { get; set; }
            // Methods
            public abstract string Describe();
            public string WhatAmI()
            {
                return "I am an animal";
            }
        }
        class Giraffe : Animal
        {
            public override string Name { get; set; }
            public double Height { get; set; }
            public string Sex { get; set; }
            public Giraffe()
            {
                Name = string.Empty;
                Height = 0;
                Sex = string.Empty;
            }
            public Giraffe(string name, double height, string sex)
            {
                Name=name;
                Height = height;
                Sex = sex;
            }
            public override string Describe()
            {
                return $"{Name} is a mammal with a long neck. {Name} is a {Sex} and is {Height} feet tall.";
            }
            public string WhatTypeAmI()
            {
                return "I am a giraffe";
            }
        }
        public static void Main(string[] args)
        {
            Giraffe doug = new Giraffe();
            doug.Name = "Doug";
            doug.Height = 16;
            doug.Sex = "Male";
            Giraffe forest = new Giraffe("Forest",18.6, "Male");
            // Displaying inherited and overridden methods
            Console.WriteLine(doug.WhatAmI());
            Console.WriteLine(doug.WhatTypeAmI());
            Console.WriteLine(doug.Describe());

            Console.WriteLine(forest.WhatAmI());
            Console.WriteLine(forest.WhatTypeAmI());
            Console.WriteLine(forest.Describe());
        }
    }
}