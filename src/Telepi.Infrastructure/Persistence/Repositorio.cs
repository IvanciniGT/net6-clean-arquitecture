using System;
using Microsoft.EntityFrameworkCore;
using Telepi.Application.Commons.DBContext;
using Telepi.Application.Dtos;

namespace Telepi.Infrastructure.Persistence;

public class Repositorio: IRepositorio
{

    private MiDBContext contexto;

    public Repositorio(MiDBContext contexto)
    {
        this.contexto = contexto;
    }

    void IRepositorio.persistir<T>(T dto)
    {
        contexto.Set<T>().Add(dto);
    }

    public void SaveChanges()
    {
        contexto.SaveChanges();
    }
}

