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
            if (count >= capacity)// the == operator should suffice, it should never be over.
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
        public static MyList<T> operator + (MyList<T> oneArray, MyList<T> twoArray)
        {
            MyList<T> combinedArray = new MyList<T>();

            if (oneArray.count != 0)
            {
                for (int i = 0; i < oneArray.count; i++)
                    combinedArray.Add(oneArray[i]);
            }
            if (twoArray.count != 0)
            {
                for (int i = 0; i < twoArray.count; i++)
                    combinedArray.Add(twoArray[i]);
            }
            return combinedArray;
        }

        //Overload Minus Operator.
        public static MyList<T> operator - (MyList<T> oneArray, MyList<T> twoArray)
        {
            MyList<T> resultingSubtractedArray = new MyList<T>();
            MyList<T> valuesToRemoveArray = new MyList<T>();

            if (twoArray.count != 0)
            {
                if (oneArray.count != 0)
                {
                    for (int i = 0; i < twoArray.count; i++)
                    {
                        for (int oneArrayIndex = 0; oneArrayIndex < oneArray.count; oneArrayIndex++)
                        {
                            if (twoArray[i].Equals(oneArray[oneArrayIndex]))
                            {
                                valuesToRemoveArray.Add(twoArray[i]);
                                oneArrayIndex = oneArray.count;
                            }
                        }
                    }
                }
            }
            if (oneArray.count != 0 && valuesToRemoveArray.count != 0)
            {
                for (int i = 0; i < oneArray.count; i++)
                {
                    bool addThis = true;
                    for (int j = 0; j < valuesToRemoveArray.count; j++)
                    {
                        if (oneArray[i].Equals(valuesToRemoveArray[j]))
                        {
                            addThis = false;
                            j = valuesToRemoveArray.count;
                        }
                    }
                    if (addThis)
                        resultingSubtractedArray.Add(oneArray[i]);
                }
            }
            else if (oneArray.count != 0 && valuesToRemoveArray.count == 0)
            {
                for (int i = 0; i < oneArray.count; i++)
                    resultingSubtractedArray.Add(oneArray[i]);
            }
            return resultingSubtractedArray;
        }

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

