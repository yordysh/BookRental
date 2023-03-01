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
        Task<EditorialDto> Create(EditorialFormDto dto);
        Task<EditorialDto> Edit(int id, EditorialFormDto dto);
        Task<EditorialDto> EnableOrDisable(int id);
        Task<EditorialDto> Find(int id);
        Task<IList<EditorialDto>> FindAll();
    }
}
