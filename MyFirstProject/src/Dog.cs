using System;

namespace MyFirstProject
{
    public class Dog
    {
        private int weight;
        private string color;

        public string breed;
        public string name;

        public Dog()
        {
            this.color = "black";
            this.breed = "German Sheppard";
            this.name = "Bob";
        }

        //Don't do this - StackOverflow
        //Dog Bobby = new Dog();
    }
}
