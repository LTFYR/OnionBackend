using OnionBackend.Application.Interfaces.Repositories;
using OnionBackend.Domain.Entities;
using OnionBackend.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionBackend.Persistance.Repositories
{
    public class CategoryRepository:GenericRepository<Category>
    {
        public CategoryRepository(AppDbContext context):base(context)
        {

        }
    }
}
