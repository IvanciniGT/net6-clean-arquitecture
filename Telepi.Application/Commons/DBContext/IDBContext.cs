using Telepi.Application.Dtos;

namespace Telepi.Application.Commons.DBContext;

public interface IDBContext
{

    public T persistir<T> (T dto) where T : IDTO;
    // Si necesito el ID, necesito devolver el DTO?
    // OJO:  !!!!!!  Puede ser que tenga default values en BBDD??? o Autocalculados????
}

