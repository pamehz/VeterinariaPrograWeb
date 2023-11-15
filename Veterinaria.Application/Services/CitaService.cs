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
    public class CitaService : ICitaService
    {
        private readonly ICitaRepository _repository;

        public CitaService(ICitaRepository repository)
        {
            this._repository = repository;
        }

        public CitaDTO Get(int id)
        {
            var cita = _repository.Get(s => s.Id == id);
            return cita.AsDTO();
        }

        public List<CitaDTO> List()
        {
            return _repository
                .GetAll(s => s.ParentId == null,
                    includes: i => i).ToList()
                .ConvertAll(cita => cita.AsDTO());
        }

        public bool Insert(NewCita newCita)
        {
            Cita cita = new Cita(newCita.VeterinarioId, newCita.Motivo, newCita.Fecha);
            _repository.Insert(cita);
            _repository.SaveChanges();
            return true;
        }

        public bool Update(ExistingCita existingCita)
        {
            Cita cita = _repository.Get(s => s.Id == existingCita.Id);
            cita.Update(existingCita.Motivo);
            _repository.Update(cita);
            _repository.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            Cita cita = _repository.Get(s => s.Id == id);
            _repository.Delete(cita);
            _repository.SaveChanges();
            return true;
        }
    }
}
