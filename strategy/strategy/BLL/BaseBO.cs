using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using strategy.Common;
using System.Collections.Generic;
using System.Linq;

namespace strategy.BLL
{
    public class BaseBO
    {
        
        public int Update<C, T>(C context, T item)
            where C : DbContext
            where T : class
        {
            context.Update(item);
            return context.SaveChanges();

        }

        
    }
}
