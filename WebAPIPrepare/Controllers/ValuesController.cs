using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIPrepare.Models;

using System.Web;
using System.Web.Http;

namespace WebAPIPrepare.Controllers
{
    public class ValuesController : ApiController
    {
        public static List<Book> list = new List<Book>{
            new Book { Author = "Stephen King", Title = "IT", Description = "Horror", ISBN = "111", ID = 1 },
            new Book { Author = "Stephen King", Title = "Cujo", Description = "Horror", ISBN = "112", ID = 2 },
            new Book { Author = "Stephen King", Title = "Scream", Description = "Horror", ISBN = "113", ID = 3 },
            new Book { Author = "Michael Conelly", Title = "The Poet", Description = "Crime" ,ISBN = "114", ID = 4 },
            new Book { Author = "Patricia Cornwall", Title = "Alice", Description = "Crime", ISBN = "115", ID = 5 }
        };

               
        // GET api/values
       //[Route("api/Values/Get")]
        public IEnumerable<Book> Get()
        {
            return list;
            //return new string[] { "value1", "value2" };
        }

        //[Route("api/Values/GetOneBook/{id}")]
        public Book Get(int id)
        {

            return list.SingleOrDefault(b=>b.ID==id);
            //return new string[] { "value1", "value2" };
        }

        [HttpPost]
        public void Remove(Book b)
        {
            Book found = list.SingleOrDefault(x => x.ID ==b.ID);
            list.Remove(found);
            /*Book found = list.SingleOrDefault(x => x.ID == id);
            if (found != null)
                list.Remove(found);
            */
        }
        
  /*      //[Route("api/Values/Remove")]
        [HttpPost]
        public void Remove(Book b)
        {
            Book found = list.SingleOrDefault(x => x.Title.Equals(b.Title));
            list.Remove(found);
           
        }*/
        [HttpGet]
        public void Add(string Title, string Author, string ISBN, string Description)
        {
            Book b = new Book();
            b.Title = Title;
            b.Author = Author;
            b.ISBN = ISBN;
            b.Description = Description;
            int max = list.Max(x => x.ID);
            b.ID = max + 1;
            list.Add(b);

            //Get();
        }
        
        [HttpPost]
        public void Add(Book b)
        {
            int max = list.Max(x => x.ID);
            b.ID = max + 1;
            list.Add(b);
           
            //Get();
        }


        /*
        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }*/
    }
}
