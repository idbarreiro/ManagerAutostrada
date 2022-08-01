using Application.Wrappers;
using MediatR;
using System;

namespace Application.Features.Productos.Commands.CreateProductoCommand
{
    public class CreateProductoCommand : IRequest<Response<int>>
    {
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public DateTime FechaFabricacion { get; set; }
        public DateTime FechaValidez { get; set; }
        public int CodigoProveedor { get; set; }
        public string DescripcionProveedor { get; set; }
        public string TelefonoProveedor { get; set; }
    }
}
