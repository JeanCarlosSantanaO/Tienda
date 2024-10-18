using Tienda.DTO.FotoDTO;
using Tienda.Modelos;

namespace Tienda.Abstraccion.Servicios
{
    public interface IServiciosFoto
    {
        List<FotoDto> GetFoto();
        Foto GetById(int id);
        FotoDto Create(CrearFotoDto crearFotoDto);
        FotoDto Update(int id, ActualizarFotoDto actualizarFotoDto);
        void Delete(int id);
    }
}
