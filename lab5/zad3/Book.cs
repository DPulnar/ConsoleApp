using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.zad3
{
    public class Book: IData,IEntity<int>
    {
   
        public string title { get; }
        public  string author { get; }
        public int Id { get; set; }
        public DateTime releaseDate { get; set; }
       
 

        public Book(int Id ,string title, string author, DateTime releaseDate)
        {
            this.Id = Id;
            this.title = title;
            this.author = author;
            this.releaseDate = releaseDate;
        }

       
    }
}
