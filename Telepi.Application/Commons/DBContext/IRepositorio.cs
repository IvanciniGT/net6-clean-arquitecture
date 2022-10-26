using Telepi.Application.Dtos;

namespace Telepi.Application.Commons.DBContext;

public interface IRepositorio
{

    public void persistir<T> (T dto) where T : BaseDTO;
    // Si necesito el ID, necesito devolver el DTO?
    // OJO:  !!!!!!  Puede ser que tenga default values en BBDD??? o Autocalculados????

    public void SaveChanges();

}

