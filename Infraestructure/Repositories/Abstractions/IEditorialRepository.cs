using Domain;
using Infrastructure.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Abstractions
{
    public interface IEditorialRepository : IRepositoryCrud<Editorial,int>, IRepositoryPaginated<Editorial>
    {
        //Task<Editorial> Create(Editorial entity);
        //Task<Editorial?> Edit(int id, Editorial entity);
        //Task<Editorial?> EnableOrDisable(int id);
        //Task<Editorial?> Find(int id);
        //Task<IList<Editorial>> FindAll();
    }
}
