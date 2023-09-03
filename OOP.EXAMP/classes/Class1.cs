using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.EXAMP.classes
{
    
        public class Book
        {
            public int narx, betlari;
           public string kitobnomi { get; set; }
          public  string kitobmuallifi { get; set; }
            public Book(string BookName, string Name)
            {
                kitobnomi = BookName;
                kitobmuallifi = Name;
            }
        public void narxOzgarish(int a)
        {
            narx = a;
        } 
        }
    
}
