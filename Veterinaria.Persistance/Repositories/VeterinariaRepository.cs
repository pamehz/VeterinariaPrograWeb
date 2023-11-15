﻿using Veterinaria.Application.Contracts.Repositories;
using Veterinaria.Application.Diagnostics;
using Veterinaria.Domain.Entities;
using Veterinaria.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Persistence.Repositories
{
    public class VeterinariaRepository<TEntity> : IRepository<TEntity>
        where TEntity : Entity
    {
        private readonly VeterinariaDbContext _dbContext;
        private readonly DbSet<TEntity> _dbset;

        public VeterinariaRepository(VeterinariaDbContext dbContext)
        {
            this._dbContext = dbContext;
            this._dbset = this._dbContext.Set<TEntity>();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> query = _dbset;
            query = query.Where(predicate);

            return query.FirstOrDefault();
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null,
            params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _dbset;

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (includes.Any())
            {
                query = includes.Aggregate
                    (query, (current, include) => current.Include(include));
            }

            return query;
        }

        public void Insert(TEntity entity)
        {
            Guard.Against.ThrowIfNull(entity);
            _dbset.Add(entity);
        }

        public void Update(TEntity entity)
        {
            Guard.Against.ThrowIfNull(entity);
            _dbset.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            Guard.Against.ThrowIfNull(entity);
            _dbset.Remove(entity);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
