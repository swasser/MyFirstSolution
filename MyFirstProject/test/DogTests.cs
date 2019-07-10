using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.test
{
    public class DogTests
    {
        [Test]
        public void Dog_has_a_name()
        {
            Dog Sparky = new Dog();

            Assert.That(Sparky.name.Length == 0, "Expect a dog to have a name, longer than 1 char");
        }
    }
}
