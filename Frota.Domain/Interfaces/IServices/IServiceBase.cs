﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Frota.Domain.Interfaces.IServices
{
    public interface IServiceBase<TEntity> : IDisposable where TEntity : class
    {        
        TEntity ObterPorId(int id);

        IEnumerable<TEntity> ObterTodos();
        
        void Remover(TEntity entity);
    }
}
