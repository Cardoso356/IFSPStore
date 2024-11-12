using AutoMapper;
using FluentValidation;
using IFSPStore.Domain.Base;
using Microsoft.Extensions.Options;

namespace IFSPStore.Service.Services
{
    //é uma classe genérica
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : IBaseEntity
    {
        private readonly IBaseRepository<TEntity> _baseRepository;
        private readonly IMapper _mapper;

        //um método construtor:
        //isso é uma injeção de dependência, é uma ferramenta que vai cuidar de todas as dependências do sistema
        public BaseService(IBaseRepository<TEntity> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public TOutputModel Add<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TInputModel : class
            where TOutputModel : class
            where TValidator : AbstractValidator<TEntity>
        {
            var entity = _mapper.Map<TEntity>(inputModel);
            Validate(entity, Activator.CreateInstance<TValidator>());
            _baseRepository.Insert(entity);
            var outputModel = _mapper.Map<TOutputModel>(entity);
            return outputModel;
        }



        //método para taxar o objeto: é rastrear o objeto para o banco de dados
        public void AtachObject(Object obj) 
        {
            _baseRepository.AtachObject(obj);
        }

        public void AttachObject(object obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            _baseRepository.Delete(id);
        }

        public IEnumerable<TOutputModel> Get<TOutputModel>(IList<string> includes = null) where TOutputModel : class
        {
            var entities = _baseRepository.Select(includes);
            var outputModel = entities.Select(s => _mapper.Map<TOutputModel>(s));
            return outputModel;
        }

        public TOutputModel GetById<TOutputModel>(int id, IList<string> includes = null) where TOutputModel : class
        {
            var entity = _baseRepository.Select(includes);
            var outputModel = _mapper.Map<TOutputModel>(entity);
            return outputModel;
        }

        public TOutputModel Update<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TInputModel : class
            where TOutputModel : class
            where TValidator : AbstractValidator<TEntity>
        {
            var entity = _mapper.Map<TEntity>(inputModel);
            Validate(entity, Activator.CreateInstance<TValidator>());
            _baseRepository.Update(entity);
            var outputModel = _mapper.Map<TOutputModel>(entity);
            return outputModel;
        }


        private void Validate(TEntity obj, AbstractValidator<TEntity> validator)
        {
            if(obj == null)
            {
                throw new Exception("Objeto inválido"); 
            }
            validator.ValidateAndThrow(obj);
        }
    }
}
