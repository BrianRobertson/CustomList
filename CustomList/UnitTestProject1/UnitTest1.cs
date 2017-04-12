using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_IntToList_1Added()
        {
            //Arrange
            MyList<int> testList = new MyList<int>();
            int number = 1;
            //Act
            testList.Add(number);
            //Assert
            Assert.AreEqual(number, testList[0]);
        }
        [TestMethod]
             public void Add_StringToList_1Added()
        {
            //Arrange
            MyList<string> testList = new MyList<string>();
            string item = "Test string 1.";
            //Act
            testList.Add(item);
            //Assert
            Assert.AreEqual(item, testList[0]);
        }
        [TestMethod]
        public void Add_ObjectToList_1Added()
        {
            //Arrange
            MyList<Guitar> testList = new MyList<Guitar>();
            Guitar guitar = new Guitar("Fender", "Jaguar", 1964);
            //Act
            testList.Add(guitar);
            //Assert
            Assert.AreEqual(guitar, testList[0]);
        }
        [TestMethod]
        public void Add_MultipleIntToList_3Added()
        {
            //Arrange & Act
            MyList<int> testList = new MyList<int>(1, 2, 3);
            int expected = 2;

            //Assert     
                Assert.AreEqual(expected, testList[1]);

        }
        [TestMethod]
        public void Add_MultipleObjectsToList_3ObjectsAdded()
        {
            //Arrange
            MyList<Guitar> testList = new MyList<Guitar>();
            Guitar guitar1 = new Guitar("Fender", "Jaguar", 1964);
            Guitar guitar2 = new Guitar("Gibson", "Les Paul", 1965);
            Guitar guitar3 = new Guitar("Fender", "Stratocaster", 1961);

            //Act
            testList.Add(guitar1);
            testList.Add(guitar2);
            testList.Add(guitar3);

            //Assert
            Assert.AreEqual(guitar2, testList[1]);//how to reference object in a list?
        }












    }
}
