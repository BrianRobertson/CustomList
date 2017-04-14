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

            MyList<int> list = new MyList<int>();
            list.Add(81);
            list.Add(82);
            list.Add(83);
            list.Add(84);
            list.Add(91);
            list.Add(92);
            list.Add(93);
            list.Add(94);
            list.Add(100);
            list.Remove(91);
        }
    }
}
