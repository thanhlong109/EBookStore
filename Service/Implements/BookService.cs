using BusinessObjects.Models;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implements
{
    public class BookService : GenericService<Book>, IBookService
    {
        public BookService(IGenericRepository<Book> repository) : base(repository)
        {
        }
    }
}
