using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeAreTrvlrs.DAL.Data;
using WeAreTrvlrs.Model;

namespace WeAreTrvlrs.DAL.Repositories
{
    public class OnlineUsersRepository : RepositoryBase<OnlineUsers>
    {
        public OnlineUsersRepository(DataContext context) :base(context)
        {
            if(context == null)
            {
                throw new ArgumentNullException();
            }
        }

    }
}
