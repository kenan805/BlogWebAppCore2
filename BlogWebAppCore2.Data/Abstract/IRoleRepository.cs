using BlogWebAppCore2.Entites.Concrete;
using BlogWebAppCore2.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebAppCore2.Data.Abstract
{
    public interface IRoleRepository : IEntityRepository<Role>
    {
    }
}
