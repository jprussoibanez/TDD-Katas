﻿using NUnit.Framework;

namespace TDD_Katas_project.FizzBuzzKata.Rx
{
    [TestFixture]
    [Category("TheFizzBuzzRxKata")]
    public class TestFizzBuzzRx
    {
        [Test]
        public void GivenNumberBelowOne_ReturnEmptyString()
        {
            var result = FizzBuzzRx.Generate(-1);

            Assert.That(result, Is.Empty);
        }

        [TestCase(1, ExpectedResult = "1,")]
        [TestCase(2, ExpectedResult = "1,2,")]
        public string GivenNumberUpTo2_ReturnNumbersCommaDelimited(int input)
        {
            return FizzBuzzRx.Generate(input);
        }

        [TestCase(3, ExpectedResult = "1,2,Fizz,")]
        [TestCase(6, ExpectedResult = "1,2,Fizz,4,Buzz,Fizz,")]
        [TestCase(9, ExpectedResult = "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,")]
        public string GivenNumberDividedBy_ReturnFizzInstead(int input)
        {
            return FizzBuzzRx.Generate(input);
        }

        [TestCase(5, ExpectedResult = "1,2,Fizz,4,Buzz,")]
        [TestCase(10, ExpectedResult = "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,")]
        public string GivenNumberDividedBy5_ReturnBuzzInstead(int input)
        {
            return FizzBuzzRx.Generate(input);
        }

        [Test]
        public void GivenNumberDividedBy3And5_ReturnFizzBuzzInstead()
        {
            var result = FizzBuzzRx.Generate(15);

            Assert.That(result, Is.EqualTo("1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz,"));
        }

    }
}
