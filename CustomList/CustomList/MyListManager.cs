using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyListManager
    {
        public MyList<Guitar> guitarList;
        public MyListManager()
        {
            guitarList = new MyList<Guitar>();
        }
        public void MainMenu()
        {
            Console.WriteLine("Welcome to myListManager!");
        }
        public void ManageMyList()
        {
            //do stuff.
        }
    }
}
