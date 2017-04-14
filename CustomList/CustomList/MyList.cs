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
        //Class (template) for MyList.
        private int count;
        private int capacity;
        private T[] myArray;
        public int Count { get { return count; } }
        public int Capacity { get { return capacity; } set { capacity = value; } }

        public T this[int i]// This indexer returns or sets the corresponding element from the internal array.
        {
            get
            {
                return myArray[i];
            }
            set
            {
                myArray[i] = value;
            }
        }

        public MyList()
        {
            count = 0;
            capacity = 4;
            myArray = new T[capacity];
        }

        public void Add(T item)
        {
            if (count >= capacity)// the == operator should suffice, it will never be over.
            {
                capacity += 4;//change varible of myArray.
                T[] newArray = new T[capacity];//declare array size.

                //add contents of myArray into newArray
                for (int i = 0; i < count; i++)
                {
                    newArray[i] = myArray[i];
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
        
        public bool Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (myArray[i].Equals(item))
                {
                    count--;
                    ShiftMyArray(i);
                    return true;
                }
            }
            return false;
        }
        private void ShiftMyArray(int currentIndex)
        {
            for (int i = currentIndex; i < count; i++)
            {
                myArray[i] = myArray[i + 1];
            }
            myArray[count + 1] = default(T);//Attempting to overwrite the last unused index with a default value. But it doesn't do anything.
        }




        //Iterator. Is this the function of the indexer? If so, check!



        //public override string ToString()
        //{

        //}

        //Overload Plus Operator.
        public static MyList<T> operator +(MyList<T> list1, MyList<T> list2)
        {
            //Needs logic.
            MyList<T> combinedList = new MyList<T>();

            if (list1.count != 0)
            {
                for (int i = 0; i < list1.count; i++)
                    combinedList.Add(list1[i]);
            }
            if (list2.count != 0)
            {
                for (int i = 0; i < list2.count; i++)
                    combinedList.Add(list2[i]);
            }
            return combinedList;
        }

        //Overload Minus Operator.
        //public static MyList<T> operator -(MyList<T> list1, MyList<T> list2)
        //{
        //    //Needs logic.
        //}

        public MyList<T> ZipWith(MyList<T> listToBeZippedIn)
        {
            //needs logic.
            MyList<T> zippedList = new MyList<T>();
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

