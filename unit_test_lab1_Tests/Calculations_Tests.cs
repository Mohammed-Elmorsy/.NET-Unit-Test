using unit_test_lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace unit_test_lab1_Tests
{
    [TestClass]
    public class Calaculation_Tests
    {
        //-----------------------------------int sum method------------------------------------------

        [TestMethod]
        public void Sum_Recieve_X_Y_When_X_LT_Y_Return_0()
        {
            //Arrange
            Calculations caller = new Calculations();
            int first_number = 10, second_number = 20;
            int expected = 0, actual;

            //Act
            actual = caller.Sum(first_number, second_number);

            //Assert
            //Assert.AreEqual(expected, actual);
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void Sum_Recieve_X_Y_When_X_GT_Y_Return_Summation()
        {
            //Arrange
            Calculations caller = new Calculations();
            int first_number = 20, second_number = 10;
            int expected = 30, actual;

            //Act
            actual = caller.Sum(first_number, second_number);

            //Assert
            //Assert.AreEqual(expected, actual);
        }
        //-----------------------------------string sum method------------------------------------------
        [TestMethod]
        public void Sum_Recieve_StringX_StringY_When_X_AND_Y_NotNULL_Return_X__Y()
        {
            //Arrange
            Calculations caller = new Calculations();
            string first_word = "hello", second_word = "world";
            //string expected = "hello world";
            string actual;

            //Act
            actual = caller.Sum(first_word, second_word);

            //Assert
            //Assert.AreEqual(expected, actual);
            //StringAssert.StartsWith(actual, "hello");
            //StringAssert.EndsWith(actual, "world");
            StringAssert.Contains(actual, " ");
        }

        [TestMethod]
        public void Sum_Recieve_StringX_StringY_When_X_IsNULL_Return_NULL()
        {
            //Arrange
            Calculations caller = new Calculations();
            string first_word = "hello", second_word = null;
            string actual;

            //Act
            actual = caller.Sum(first_word, second_word);

            //Assert
            StringAssert.Equals(actual, null);
        }

        [TestMethod]
        public void Sum_Recieve_StringX_StringY_When_Y_IsNULL_Return_NULL()
        {
            //Arrange
            Calculations caller = new Calculations();
            string first_word = null, second_word = "world";
            string actual;

            //Act
            actual = caller.Sum(first_word, second_word);

            //Assert
            StringAssert.Equals(actual, null);
        }

        //-----------------------------------subtract method------------------------------------------

        [TestMethod]
        public void Subtract_Receive_X_AND_Y_When_X_GT_Y_Return_Absolute_Value()
        {
            //Arrange
            Calculations caller = new Calculations();
            int first_number = 35, second_number = 15;
            int expected = 20, actual;

            //Act
            actual = caller.Subtract(first_number, second_number);

            //Assert
            //Assert.AreEqual(expected, actual);
            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void Subtract_Receive_X_AND_Y_When_X_LT_Y_Return_Absolute_Value()
        {
            //Arrange
            Calculations caller = new Calculations();
            int first_number = 10, second_number = 15;
            int expected = 5, actual;

            //Act
            actual = caller.Subtract(first_number, second_number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Subtract_Receive_X_AND_Y_When_X_Equals_Y_Return_Zero()
        {
            //Arrange
            Calculations caller = new Calculations();
            int first_number = 10, second_number = 10;
            int expected = 0, actual;

            //Act
            actual = caller.Subtract(first_number, second_number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //------------------------------------CMtoInch Method----------------------------------------
        [TestMethod]
        public void CMtoInch_Should_Receieve_CM_GT_Zero_Return_Inch()
        {
            //Arrange
            double cm = 10;
            double expected = 4, actual;

            //Act
            actual = Calculations.CMToInch(cm);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CMtoInch_Should_Receieve_CM_LT_OR_Equals_Zero_Return_Zero()
        {
            //Arrange
            double cm = -1;
            double expected = 0, actual;

            //Act
            actual = Calculations.CMToInch(cm);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        //-----------------------------------Divide Method------------------------------------------
        [TestMethod]
        public void Divide_Receives_X_Y_When_Y_Equals_Zero_Return_Zero()
        {
            //Arrange
            Calculations caller = new Calculations();
            double first_number = 5416, second_number = 0;
            double expected = 0, actual;

            //Act
            actual = caller.Divide(first_number, second_number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Divide_Receives_X_Y_When_Y_NOTEquals_Zero_Return_X_Divide_Y()
        {
            //Arrange
            Calculations caller = new Calculations();
            double first_number = 15, second_number = -1.3;
            double actual;

            //Act
            actual = caller.Divide(first_number, second_number);

            //Assert
            Assert.IsFalse(actual == 0);
        }
        //-------------------------------GetOdd Method-----------------------------------------
        [TestMethod]
        public void GetOdd_Receives_List_of_int__When_NULL_Return_NULL()
        {
            //Arrange
            Calculations caller = new Calculations();

            List<int> empty = null ,actual;

            //Act
            actual = caller.GetOdd(empty);

            //Assert
            Assert.IsTrue(actual == null);
        }

        [TestMethod]
        public void GetOdd_Receives_List_of_int__When_NotNULL_Return_List_of_odd_numbers()
        {
            //Arrange
            Calculations caller = new Calculations();

            List<int> numbers = new List<int>() { 2, 84, 6, 5, 4, 9, 3, 10 };
            List<int> expected = new List<int>() { 5, 3 , 9 } , actual;

            //Act
            actual = caller.GetOdd(numbers);

            //Assert
            //Assert.AreEqual(expected, actual);
            //CollectionAssert.AreEqual(expected, actual);
            CollectionAssert.AreEquivalent(expected, actual);
        }
        //---------------------------------------------------------------------------------------------

    }
}
