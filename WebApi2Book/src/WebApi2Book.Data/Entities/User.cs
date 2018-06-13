using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi2Book.Data.Entities
{
    class User
    {
        public virtual long UserId { get; set; }
        public virtual string FristName { get; set; }
        public virtual string LastName { get; set; }

        public virtual string UserName { get; set; }

        public virtual byte[] Version { get; set; }
    }
}
