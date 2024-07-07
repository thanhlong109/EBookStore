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
    public class UserService : GenericService<User>, IUserService
    {
        public UserService(IGenericRepository<User> repository) : base(repository)
        {
        }
    }
}
