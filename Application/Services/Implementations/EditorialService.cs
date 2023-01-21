using Application.Dtos.Editoriales;
using Application.Services.Abstractions;
using AutoMapper;
using Domain;
using Infrastructure.Repositories.Abstractions;

namespace Application.Services.Implementations
{
    public class EditorialService : IEditorialService
    {
        private readonly IMapper _mapper;
        private readonly IEditorialRepository _editorialRepository;

        public EditorialService(IMapper mapper, IEditorialRepository editorialRepository)
        {
            _mapper = mapper;
            _editorialRepository = editorialRepository;
        }

        public Task<Editorial> Create(Editorial entity)
        {
           
            throw new NotImplementedException();
        }

        public Task<Editorial> Edit(int id, Editorial entity)
        {
            throw new NotImplementedException();
        }

        public Task<Editorial> EnableOrDisable(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Editorial> Find(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<EditorialDto>> FindAll()
        {
            var response = await _editorialRepository.FindAll();

            return _mapper.Map<IList<EditorialDto>>(response);
        }
    }
}
