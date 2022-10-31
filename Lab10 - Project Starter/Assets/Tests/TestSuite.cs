using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestSuite
    {
        private float result = 0.0f;
        [Test]
        public void TestAddition()
        {
            //Use the Assert class to test conditions
            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);       
        }

        //Test for Addition
        [UnityTest]
        public IEnumerator TestUnityAddition()
        {
            //Use the Assert class to test conditions
            //Use yield to skip a frame
            yield return null;

            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }

        //Test for Subtraction
        [UnityTest]
        public IEnumerator TestUnitySubtraction()
        {
            //Use the Assert class to test conditions
            //Use yield to skip a frame
            yield return null;

            result = Calculator.CalculatePair(5, 2, "-");
            Assert.AreEqual(result, 3);
        }

        //Test for Multiplication
        [UnityTest]
        public IEnumerator TestUnityMultiplication()
        {
            //Use the Assert class to test conditions
            //Use yield to skip a frame
            yield return null;

            result = Calculator.CalculatePair(5, 2, "*");
            Assert.AreEqual(result, 10);
        }

        //Test for Division
        [UnityTest]
        public IEnumerator TestUnityDivision()
        {
            //Use the Assert class to test conditions
            //Use yield to skip a frame
            yield return null;

            result = Calculator.CalculatePair(20, 2, "/");
            Assert.AreEqual(result, 10);
        }
    }
}
