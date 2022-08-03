using Application.Features.Productos.Commands.CreateProductoCommand;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    public class GeneralMapper : Profile
    {
        public GeneralMapper()
        {
            #region Commands
            CreateMap<CreateProductoCommand, Producto>();
            #endregion
        }
    }
}
