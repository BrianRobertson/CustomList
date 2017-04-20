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
        private int count;
        private int capacity;
        private T[] myArray;
        public int Count { get { return count; } }
        public int Capacity { get { return capacity; } set { capacity = value; } }

        public T this[int i]// This indexer returns or sets the corresponding element from the internal array. Thus making the list iterable.
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

        //Add method
        public void Add(T item)//Add method.
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

        //Remove method
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

        //ToString
        public override string ToString()
        {
            string resultString = "";
            if (count != 0)
                for (int i = 0; i < count; i++)
                    resultString = ConvertValuesToString();

            return resultString;
        }
        private string ConvertValuesToString()
        {
            string myString = "";
            for (int i = 0; i < count; i++)
            {
                myString += myArray[i];
            }
            return myString;
        }

        //Overload Plus Operator.
        public static MyList<T> operator +(MyList<T> oneArray, MyList<T> twoArray)
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
        public static MyList<T> operator -(MyList<T> oneArray, MyList<T> twoArray)
        {
            MyList<T> resultingSubtractedArray = new MyList<T>();
            MyList<T> valuesToRemoveArray = new MyList<T>();

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

            if (oneArray.count != 0 && valuesToRemoveArray.count != 0)
            {
                for (int i = 0; i < oneArray.count; i++)
                {
                    bool addThis = true;
                    for (int index = 0; index < valuesToRemoveArray.count; index++)
                    {
                        if (oneArray[i].Equals(valuesToRemoveArray[index]))
                        {
                            addThis = false;
                            index = valuesToRemoveArray.count;
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

        //Zip Method
        public MyList<T> ZipWith(MyList<T> listToBeZippedIn)
        {
            MyList<T> zipArray = new MyList<T>();

            if (count != 0 && listToBeZippedIn.Equals(0))
            {
                if (count >= listToBeZippedIn.Count)
                {
                    for (int i = 0; i < count; i++)
                    {
                        zipArray.Add(myArray[i]);
                        if (i < listToBeZippedIn.Count)
                            zipArray.Add(listToBeZippedIn[i]);
                    }
                }
                else
                {
                    for (int i = 0; i < listToBeZippedIn.Count; i++)
                    {
                        if (i < count)
                            zipArray.Add(myArray[i]);
                        zipArray.Add(listToBeZippedIn[i]);
                    }
                }
            }
            else if (count != 0 && listToBeZippedIn.Equals(0))
            {
                for (int i = 0; i < count; i++)
                    zipArray.Add(myArray[i]);
            }
            else if (count == 0 && !listToBeZippedIn.Equals(0))
            {
                for (int i = 0; i < listToBeZippedIn.Count; i++)
                    zipArray.Add(listToBeZippedIn[i]);
            }
            return zipArray;
        }

        public void Sort()
        {
            //bonus, not done.
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

