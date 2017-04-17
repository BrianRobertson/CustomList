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
            int testNumber = 9;
            int expected = 9;

            //Act
            testList.Add(testNumber);

            //Assert
            Assert.AreEqual(expected, testList[0]);
        }
        [TestMethod]
             public void Add_StringToList_Add1String()
        {
            //Arrange
            MyList<string> testList = new MyList<string>();
            string testString = "Test string 1.";

            //Act
            testList.Add(testString);

            //Assert
            Assert.AreEqual(testString, testList[0]);
        }
        [TestMethod]
        public void Add_ObjectToList_Add1Object()
        {
            //Arrange
            MyList<Guitar> testList = new MyList<Guitar>();
            Guitar testGuitar = new Guitar("Fender", "Jaguar", 1964);

            //Act
            testList.Add(testGuitar);

            //Assert
            Assert.AreEqual(testGuitar, testList[0]);
        }
        [TestMethod]
        public void Add_MultipleIntToList_Add3Int()
        {
            //Arrange & Act
            MyList<int> testList = new MyList<int>() {1, 2, 3};
            int expected = 3;

            //Assert     
                Assert.AreEqual(expected, testList[2]);
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
            Assert.AreEqual(guitar2, testList[1]);
        }


        //Remove From List Tests

        [TestMethod]
        public void Remove_IntFromList_Remove1Int()
        {
            //Arrange
            MyList<int> testList = new MyList<int>() {1, 2, 3, 4, 5};
            int expected = 4;

            //Act
            testList.Remove(3);//Removes matching item and remaining content shifts forward on list.

            //Assert
            Assert.AreEqual(expected, testList[2]);//Content at index after removing one item.
        }
        [TestMethod]
        public void Remove_StringFromList_Remove1String()
        {
            //Arrange
            MyList<string> testList = new MyList<string>();
            testList.Add("Test string 1.");
            testList.Add("Test string 2.");
            testList.Add("Test string 3.");
            testList.Add("Test string 4.");
            string expected = "Test string 2.";

            //Act
            testList.Remove("Test string 1.");//Removes matching item and remaining content shifts forward on list.

            //Assert
            Assert.AreEqual(expected, testList[0]);//Content at index after removing one item.
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
            Guitar expectedGuitar = guitar3;

            //Act
            testList.Remove(guitar2);//Removes matching item and remaining content shifts forward on list.

            //Assert
            Assert.AreEqual(expectedGuitar, testList[1]);//Content at index after removing one item.
        }


        //ToString Tests

        [TestMethod]
        public void ToString_IntInList_ToString()
        {
            //Arrange
            MyList<int> testList = new MyList<int>() {1, 2, 3, 4, 5, 6};
            string expected = "123456";

            //Act
            string result = testList.ToString();

            //Assert
            Assert.AreEqual(expected, result);//Compare strings.
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
            string result = testList.ToString();//ToString the whole object into one string?

            //Assert
            Assert.AreEqual(expected, result);
        }


        //Overload Plus Operator Tests
        [TestMethod]
        public void OperatorOverride_PlusSign_AddTwoListsTogether()
        {
            //Arrange
            MyList<int> testList1 = new MyList<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            MyList<int> testList2 = new MyList<int>() { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            int expected = 6;

            //Act
            MyList<int> resultList = testList1 + testList2;

            //Assert     
            Assert.AreEqual(expected, resultList[15]);
        }
        //other similair test with different datatypes etc.




        //Overload Minus Operator Tests
        [TestMethod]
        public void OperatorOverride_MinusSign_SubtractListAnotherList()
        {
            //Arrange
            MyList<int> testList1 = new MyList<int>() { 0, 1, 2, 3, 4, 4, 5, 6, 7, 8, 9, 10 };
            MyList<int> testList2 = new MyList<int>() { 1, 3, 4, 5 };
            int expected = 8;

            //Act
            MyList<int> resultList = testList1 - testList2;

            //Assert     
            Assert.AreEqual(expected, resultList[4]);
        }
        //other similair test with different datatypes etc.










        //Count Tests

        [TestMethod]
        public void Count_IntList_Match()
        {
            //Arrange
            MyList<int> testList = new MyList<int>() {1, 2, 3, 4, 5, 6 };
            int expected = 6;

            //Act
            int result = testList.Count;//Count property on this list.

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Count_StringList_Match()
        {
            //Arrange
            MyList<string> testList = new MyList<string>() {"This", "is", "a", "test"};
            int expected = 4;

            //Act
            int result = testList.Count;//Count property on this list.

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
            int expected = 3;

            //Act
            int result = testList.Count;//Count property on this list.

            //Assert
            Assert.AreEqual(expected, result);
        }


        //Zipper Method Tests

        [TestMethod]
        public void Zipper_TwoIntLists_OneList()
        {
            //Arrange
            MyList<int> oddList1 = new MyList<int>() {1, 3, 5, 7, 9};
            MyList<int> evenList2 = new MyList<int>() {2, 4, 6, 8, 10};
            MyList<int> expectedList = new MyList<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            //Act
            MyList<int> resultList = oddList1.ZipWith(evenList2);//zipper method.

            //Assert
            Assert.AreEqual(expectedList, resultList);//unsure how to compare lists, whole list or spot check?
        }

        [TestMethod]
        public void Zipper_TwoStringLists_OneList()
        {
            //Arrange
            MyList<string> testList1 = new MyList<string>() {"This", "a", "of", "two", "into"};
            MyList<string> testList2 = new MyList<string>() {"is", "test", "joining", "lists", "one."};
            MyList<string> expectedList = new MyList<string>() {"This", "is", "a", "test", "of", "joining", "two", "lists", "into", "one." };

            //Act
            MyList<string> resultList = testList1.ZipWith(testList2);//zipper method.

            //Assert
            Assert.AreEqual(expectedList, resultList);//unsure how to compare lists, whole list or spot check?
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
            MyList<Guitar> resultGuitarList = fenderList.ZipWith(gibsonList);//zipper method.

            //Assert
            Assert.AreEqual(expectedGuitarList, resultGuitarList);//unsure how to compare lists, whole list or spot check?
        }
    }
}
