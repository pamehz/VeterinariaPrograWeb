using Veterinaria.Application.Contracts;
using Veterinaria.Application.Contracts.Repositories;
using Veterinaria.Domain.DTOs;
using Veterinaria.Domain.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Domain.Entities;

namespace Veterinaria.Application.Services
{
    public class VeterinarioService : IVeterinarioService
    {
        private readonly IVeterinarioRepository _repository;

        public VeterinarioService(IVeterinarioRepository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public VeterinarioDTO Get(int id)
        {
            var veterinario = _repository.Get(s => s.Id == id);
            return veterinario.AsDTO();
        }

        public List<VeterinarioDTO> List()
        {
            return _repository
                .GetAll()
                .ToList()
                .ConvertAll(veterinario => veterinario.AsDTO());
        }

        public bool Insert(NewVeterinario newVeterinario)
        {
            Veterinario veterinario = new Veterinario(newVeterinario.Nombre);
            _repository.Insert(veterinario);
            _repository.SaveChanges();
            return true;
        }

        public bool Update(ExistingVeterinario existingVeterinario)
        {
            Veterinario veterinario = _repository.Get(s => s.Id == existingVeterinario.Id);
            veterinario.Update(existingVeterinario.Nombre);
            _repository.Update(veterinario);
            _repository.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            Veterinario veterinario = _repository.Get(s => s.Id == id);
            _repository.Remove(veterinario);
            _repository.SaveChanges();
            return true;
        }
    }
}
