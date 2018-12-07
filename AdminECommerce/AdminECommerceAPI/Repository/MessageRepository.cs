using AdminECommerceModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminECommerceAPI.Repository
{
    public class MessageRepository : BaseRepository<Message>
    {
        public MessageRepository(MStoreContext dataContext) : base(dataContext)
        {
        }
    }
}