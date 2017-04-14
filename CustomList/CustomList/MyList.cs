using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyList<T> : IEnumerable<T>
    {
        //template for MyList.
        private int count;
        private int capacity;
        private T[] myArray;
        public int Count { get { return count; } }
        public int Capacity { get { return capacity; } set { capacity = value; } }

        public MyList()
        {
            count = 0;
            capacity = 4;
            myArray = new T[capacity];
        }

        public void Add(T item)
        {
            if (count >= capacity)// the == operator would suffice.
            {
                T[] oldArray = myArray;
                T[] newArray = new T[capacity + 4];//declare array size.
                capacity += 4;//change varible.

                //add contents of oldArray into newArray
                for (int i = 0; i < count; i++)
                {
                    newArray[i] = oldArray[i];
                }

                myArray = newArray;
                myArray[count] = item;
                count++;
            }
            else
            {
                myArray[count] = item;
                count++;
            }
        }
        




        public void Remove(T item)
        {

        }

        //Iterator.



        public override string ToString()
        {

        }

        //Overload Plus Operator.
        public static MyList<T> operator + (MyList<T> list1, MyList<T> list2)
        {

        }

        //Overload Minus Operator.
        public static MyList<T> operator - (MyList<T> list1, MyList<T> list2)
        {

        }

        public MyList<T> ZipWith(MyList<T> listToBeZippedIn)
        {
            MyList<T> zippedList;
            return zippedList;
        }
        public void Sort()
        {
            //bonus.
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                yield return myArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

