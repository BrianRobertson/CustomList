using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class Program
    {
        static void Main(string[] args)
        {
            //MyListManager myListManager = new MyListManager();
            //myListManager.MainMenu();
            //Console.Read();

            //MyList<int> list = new MyList<int>();
            //list.Add(81);
            //list.Add(82);
            //list.Add(83);
            //list.Add(84);
            //list.Add(91);
            //list.Add(92);
            //list.Add(93);
            //list.Add(94);
            //list.Add(100);
            //list.Remove(91);
            MyList<int> testList1 = new MyList<int>() { 0, 1, 2, 3, 4, 4, 5, 6, 7, 8, 9, 10 };
            MyList<int> testList2 = new MyList<int>() { 1, 3, 4, 5 };
//            int expected = 8;

            //Act
            MyList<int> resultList = testList1 - testList2;
            //Arrange
            //MyList<int> testList = new MyList<int>() { 1, 2, 3, 4, 5, 6 };
            //string expected = "123456";// single int? whole list? new data type list? What is expected return?

            //Act
            //string result = testList.ToString();//how to string entire list? new list with string data type?

            //Assert
            //Assert.AreEqual(expected, result);//Compare strings.

            //Arrange
            //MyList<int> oddList1 = new MyList<int>() { 1, 3, 5, 7, 9 };
            //MyList<int> evenList2 = new MyList<int>() { 2, 4, 6, 8, 10 };
            //MyList<int> expectedList = new MyList<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            ////Act
            //MyList<int> resultList = oddList1.ZipWith(evenList2);//zipper method.
            //for (int i = 0; i < resultList.Count; i++)
            //{
            //    Console.WriteLine(resultList[i]);
            //}
            //Console.Read();



        }
    }
}
