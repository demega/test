using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Test.Library.Tests
{
    [TestFixture]
    public class FizzBusserTests
    {
        [Test]
        public void Buzzer_whenDefault_returnsInput([Values(1, 2, 4, 7, 8, 11, 13, 14, 16, 17, 19)] int input)
        {
            string output = FizzBusser.GetValue(input);
            Assert.AreEqual(input.ToString(), output);
        }

        [Test]
        public void Buzzer_whenDiv3_returnsFizz([Values(3, 6, 9, 12, 18)] int input)
        {
            string output = FizzBusser.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void Buzzer_whenDiv5_returnsBuzz([Values(5, 10, 20)] int input)
        {
            string output = FizzBusser.GetValue(input);
            Assert.AreEqual("Buzz", output);
        }
        
        [Test]
        public void Buzzer_whenDiv3andDiv5_returnsFizzBuzz([Values(15)] int input)
        {
            string output = FizzBusser.GetValue(input);
            Assert.AreEqual("FizzBuzz", output);
        }
    }
}
