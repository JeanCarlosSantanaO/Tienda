using System;
using Tienda.Abstraccion.Repositorio;
using Tienda.Abstraccion.Servicios;
using Tienda.DTO.FotoDTO;
using Tienda.Modelos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tienda.Implementaciones.Servicios
{
    public class ServiciosFoto : IServiciosFoto
    {
        private readonly IRepositorioFoto repositorioFoto;
        public ServiciosFoto(IRepositorioFoto repositorio)
        {
           repositorioFoto = repositorio;
        }



        public FotoDto Create(CrearFotoDto crearFotoDto)
        {
            var foto = repositorioFoto.Create(crearFotoDto);
            var fotoDto = new FotoDto
            {
                Nombre=foto.Nombre,
                Url=foto.Url,
                Categoria=foto.Categoria,
                ModifiedDateTime=foto.ModifiedDateTime
            };
            return fotoDto;
        }

        public void Delete(int id)
        {
            repositorioFoto.Delete(id);
        }

        public Foto GetById(int id)
        {
            return repositorioFoto.GetById(id);
        }

        public List<FotoDto> GetFoto()
        {
            var fotos = repositorioFoto.GetFotos();
            var fotoDto = new List<FotoDto>();
            foreach (Foto foto in fotos)
            {
                var nfoto = new FotoDto
                {

                    Nombre = foto.Nombre,
                    Url = foto.Url,
                    Categoria = foto.Categoria,
                    ModifiedDateTime = foto.ModifiedDateTime
                };
               fotoDto.Add(nfoto);
            }
            return fotoDto;
        }

        public FotoDto Update(int id, ActualizarFotoDto actualizarFotoDto)
        {
           var foto = repositorioFoto.Update(id, actualizarFotoDto);
            var fotoDto = new FotoDto
            {

                Nombre = foto.Nombre,
                Url = foto.Url,
                Categoria = foto.Categoria,
                ModifiedDateTime = foto.ModifiedDateTime
            };
            return fotoDto;
        }
    }
}
