using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        //Add To List Tests

        [TestMethod]
        public void Add_IntToList_Add1Int()
        {
            //Arrange
            MyList<int> testList = new MyList<int>();
            int testNumber = 1;
            int expected = 1;

            //Act
            testList.Add(testNumber);

            //Assert
            Assert.AreEqual(expected, testList(0));
        }
        [TestMethod]
             public void Add_StringToList_Add1String()
        {
            //Arrange
            MyList<string> testList = new MyList<string>();
            string item = "Test string 1.";

            //Act
            testList.Add(item);

            //Assert
            Assert.AreEqual(item, testList(0));
        }
        [TestMethod]
        public void Add_ObjectToList_Add1Object()
        {
            //Arrange
            MyList<Guitar> testList = new MyList<Guitar>();
            Guitar guitar = new Guitar("Fender", "Jaguar", 1964);

            //Act
            testList.Add(guitar);

            //Assert
            Assert.AreEqual(guitar, testList(0));
        }
        [TestMethod]
        public void Add_MultipleIntToList_Add3Int()
        {
            //Arrange & Act
            MyList<int> testList = new MyList<int>() {1, 2, 3};
            int expected = 2;

            //Assert     
                Assert.AreEqual(expected, testList(1));
        }
        [TestMethod]
        public void Add_ObjectsToList_Add3Objects()
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
            Assert.AreEqual(guitar2, testList(1));//how to reference object in a list?
        }


        //Remove From List Tests

        [TestMethod]
        public void Remove_IntFromList_Remove1Int()
        {
            //Arrange
            MyList<int> testList = new MyList<int>() {1, 2, 3, 4, 5};
            int expected = 2;

            //Act
            testList.RemoveAt(0);//Is this how to remove item at index 0?

            //Assert
            Assert.AreEqual(expected, testList(0));//Is this how to reference an object in a list?
        }
        [TestMethod]
        public void Remove_StringFromList_Remove1String()
        {
            //Arrange
            MyList<string> testList = new MyList<string>();//add to list.
            testList.Add("Test string 1.");
            testList.Add("Test string 2.");
            testList.Add("Test string 3.");
            testList.Add("Test string 4.");
            string expected = "Test string 2.";

            //Act
            testList.RemoveAt(0);

            //Assert
            Assert.AreEqual(expected, testList(0));
        }
        [TestMethod]
        public void Remove_ObjectsFromList_Remove1Object()
        {
            //Arrange
            MyList<Guitar> testList = new MyList<Guitar>();
            Guitar guitar1 = new Guitar("Fender", "Jaguar", 1964);
            Guitar guitar2 = new Guitar("Gibson", "Les Paul", 1965);
            Guitar guitar3 = new Guitar("Fender", "Stratocaster", 1961);
            testList.Add(guitar1);
            testList.Add(guitar2);
            testList.Add(guitar3);
            Guitar expectedGuitar = new Guitar("Gibson", "Les Paul", 1965);

            //Act
            testList.RemoveAt(0);//Is this how to remove an object via index in a list.?

            //Assert
            Assert.AreEqual(expectedGuitar, testList(0));//Is this how to reference object in a list?
        }


        //To String Tests

        [TestMethod]
        public void ToString_IntInList_ToString()
        {
            //Arrange
            MyList<int> testList = new MyList<int>() {1, 2, 3, 4, 5, 6};//issue? slides show it working.
            string expected = "123456";// single int?

            //Act
            string result = testList.ToString();//how to string entire list?

            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
       public void ToString_ObjectInList_ToString()
        {
            //Arrange
            MyList<Guitar> testList = new MyList<Guitar>();
            Guitar guitar1 = new Guitar("Fender", "Jaguar", 1964);
            string expected = "FenderJaguar1964";

            //Act
            testList.Add(guitar1);
            string result = testList.ToString();//string the whole object?

            //Assert
            Assert.AreEqual(expected, result);
        }


        //Counting Tests

        [TestMethod]
        public void Count_IntList_Match()
        {
            //Arrange
            MyList<int> testList = new MyList<int>() {1, 2, 3, 4, 5, 6 };//Issue, slides show this working?
            int expected = 5;

            //Act
            int result = testList.Count();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Count_StringList_Match()
        {
            //Arrange
            MyList<string> testList = new MyList<string>() {"This", "is", "a", "test"};//issue?
            int expected = 3;

            //Act
            int result = testList.Count();//custom count method?

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Count_ObjectsList_Match()
        {
            //Arrange
            MyList<Guitar> testList = new MyList<Guitar>();
            Guitar guitar1 = new Guitar("Fender", "Jaguar", 1964);
            Guitar guitar2 = new Guitar("Gibson", "Les Paul", 1965);
            Guitar guitar3 = new Guitar("Fender", "Stratocaster", 1961);
            testList.Add(guitar1);
            testList.Add(guitar2);
            testList.Add(guitar3);
            int expected = 2;

            //Act
            int result = testList.Count();//custom count method?

            //Assert
            Assert.AreEqual(expected, result);
        }


        //Testing Zipper Method

        [TestMethod]
        public void Zipper_TwoIntLists_OneList()
        {
            //Arrange
            MyList<int> testList1 = new MyList<int>() {1, 3, 5, 7, 9};//issue?
            MyList<int> testList2 = new MyList<int>() {2, 4, 6, 8, 10};//issue?
            MyList<int> expectedList = new MyList<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};//issue?

            //Act
            MyList<int> resultList = myListManager.ZipLists(testList1, testList2);//zipper method?

            //Assert
            Assert.AreEqual(expectedList, resultList);//unsure if this will work on whole list
        }

        [TestMethod]
        public void Zipper_TwoStringLists_OneList()
        {
            //Arrange
            MyList<string> testList1 = new MyList<string>() {"This", "a", "of", "two", "into"};//issue?
            MyList<string> testList2 = new MyList<string>() {"is", "test", "joining", "lists", "one."};//issue?
            MyList<string> expectedList = new MyList<string>() {"This", "is", "a", "test", "of", "joining", "two", "lists", "into", "one." };//issue?

            //Act
            MyList<string> resultList = myListManager.ZipLists(testList1, testList2);//zipper method?

            //Assert
            Assert.AreEqual(expectedList, resultList);//unsure if this will work?
        }

        [TestMethod]
        public void Zipper_ObjectLists_OneList()
        {
            //Arrange
            MyList<Guitar> fenderList = new MyList<Guitar>();
            MyList<Guitar> gibsonList = new MyList<Guitar>();
            MyList<Guitar> expectedGuitarList = new MyList<Guitar>();
            Guitar guitar1 = new Guitar("Fender", "Jaguar", 1964);
            Guitar guitar2 = new Guitar("Gibson", "Les Paul", 1965);
            Guitar guitar3 = new Guitar("Fender", "Stratocaster", 1961);
            Guitar guitar4 = new Guitar("Gibson", "Firebird", 1972);
            Guitar guitar5 = new Guitar("Fender", "Telecaster", 1967);
            Guitar guitar6 = new Guitar("Gibson", "SG", 1969);
            fenderList.Add(guitar1);
            gibsonList.Add(guitar2);
            fenderList.Add(guitar3);
            gibsonList.Add(guitar4);
            fenderList.Add(guitar5);
            gibsonList.Add(guitar6);
            expectedGuitarList.Add(guitar1);
            expectedGuitarList.Add(guitar2);
            expectedGuitarList.Add(guitar3);
            expectedGuitarList.Add(guitar4);
            expectedGuitarList.Add(guitar5);
            expectedGuitarList.Add(guitar6);

            //Act
            MyList<Guitar> resultGuitarList = myListManager.ZipLists(fenderList, gibsonList);//zipper method?

            //Assert
            Assert.AreEqual(expectedGuitarList, resultGuitarList);//compare whole list?
        }
    }
}
