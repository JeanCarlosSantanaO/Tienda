using Tienda.DTO.FotoDTO;
using Tienda.Modelos;

namespace Tienda.Abstraccion.Repositorio
{
    public interface IRepositorioFoto
    {
        List<Foto> GetFotos();
        Foto GetById(int id);  
        Foto Create(CrearFotoDto crearFotoDto);
        Foto Update(int id, ActualizarFotoDto actualizarFotoDto);
        void Delete(int id);
    }
}
