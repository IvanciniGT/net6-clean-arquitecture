using Microsoft.EntityFrameworkCore;
using Telepi.Application.Commons.DBContext;
using Telepi.Application.Dtos;

namespace Telepi.Infrastructure.Persistence;

public class MiDBContext: DbContext
{
    public MiDBContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseInMemoryDatabase("TestDb");
    }

}

