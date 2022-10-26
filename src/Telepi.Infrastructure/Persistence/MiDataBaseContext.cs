using Telepi.Application.Commons.DBContext;

namespace Telepi.Infrastructure.Persistence;

public class MiDataBaseContext: IDBContext
{
    public MiDataBaseContext()
    {
    }

    T IDBContext.persistir<T>(T dto)
    {
        throw new NotImplementedException();
    }
}

