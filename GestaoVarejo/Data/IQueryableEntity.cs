﻿using Neo4j.Driver;

namespace GestaoVarejo;

public interface IQueryableEntity<T>
{
    public abstract static List<T> GetAll(IAsyncSession session);
    // public abstract void Create(IAsyncSession session);
    // public abstract void Delete(IAsyncSession session);
    // public abstract void Update(IAsyncSession session);
}