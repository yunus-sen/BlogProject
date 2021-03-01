using BlogProject.Entities.Concrete;
using BlogProject.Shared.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Entities.Dtos
{
   public class UserListDto : DtoGetBase
    {
        public IList<User>Users { get; set; }
    }
}
