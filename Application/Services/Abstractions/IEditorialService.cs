using Application.Dtos.Editoriales;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Abstractions
{
    public interface IEditorialService
    {
        Task<Editorial> Create(Editorial entity);
        Task<Editorial> Edit(int id, Editorial entity);
        Task<Editorial> EnableOrDisable(int id);
        Task<Editorial> Find(int id);
        Task<IList<EditorialDto>> FindAll();
    }
}
