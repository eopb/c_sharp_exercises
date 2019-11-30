using System;
using System.Collections.Generic;


namespace animals
{
    interface Animal : Sound, Size { }
    interface Sound
    {
        String noise();
    }
    interface Size
    {
        String size();
    }
    class Dog : Sound, Size, Animal
    {
        public String noise() => "Bark";
        public String size() => "Small";

    }
    class Cow : Sound, Size, Animal
    {
        public String noise() => "Moo";
        public String size() => "Big";
    }
    class Duck : Sound, Size, Animal
    {
        public String noise() => "Quack";
        public String size() => "Very small";
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            animals.Add(new Duck()); animals.Add(new Cow()); animals.Add(new Dog());

            foreach (Animal animal in animals)
            {
                Console.WriteLine($"The animal makes the noise {animal.noise()} it is a {animal.size()} animal");
            }
        }
    }
}
