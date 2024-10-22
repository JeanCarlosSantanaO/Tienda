using Tienda.Abstraccion.Repositorio;
using Tienda.DTO.FotoDTO;
using Tienda.Modelos;

namespace Tienda.Implementaciones.Repositorio
{
    public class RepositorioFoto : IRepositorioFoto
    {
        private readonly TiendaContext _context;

        public RepositorioFoto(TiendaContext context)
        {
            _context = context;
        }



        public Foto Create(CrearFotoDto crearFotoDto)
        {
            var foto = new Foto
            {
                Nombre = crearFotoDto.Nombre,
                Url = crearFotoDto.Url,
                Categoria= crearFotoDto.Categoria,
            };
            _context.Fotos.Add(foto);
            _context.SaveChanges();
            return foto;
        }

        public void Delete(int id)
        {
            Foto foto = GetById(id);
            _context.Remove(foto);
            _context.SaveChanges();
        }

        public Foto GetById(int id)
        {
            return _context.Fotos.Where(c => c.FotoId == id).FirstOrDefault();
        }

        public List<Foto> GetFotos()
        {
            return [.. _context.Fotos];
        }

        public Foto Update(int id, ActualizarFotoDto actualizarFotoDto)
        {
            var fotoExiste = GetById(id);

            fotoExiste.Nombre=actualizarFotoDto.Nombre;
            fotoExiste.Url=actualizarFotoDto.Url;
            fotoExiste.Categoria=actualizarFotoDto.Categoria;
            fotoExiste.ModifiedDateTime=actualizarFotoDto.ModifiedDateTime;

            _context.Update(fotoExiste);
            _context.SaveChanges() ;
            var fotoActualizada = GetById(id);
            return fotoActualizada;

            
        }
    }
}
