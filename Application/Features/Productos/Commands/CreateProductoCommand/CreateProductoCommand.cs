using Application.Wrappers;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

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
    public class CreateProductoCommandHandler : IRequestHandler<CreateProductoCommand, Response<int>>
    {
        public async Task<Response<int>> Handle(CreateProductoCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
