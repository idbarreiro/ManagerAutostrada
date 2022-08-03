using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Productos.Commands.UpdateProductoCommand
{
    public class UpdateProductoCommand : IRequest<Response<int>>
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaFabricacion { get; set; }
        public DateTime FechaValidez { get; set; }
        public int CodigoProveedor { get; set; }
        public string DescripcionProveedor { get; set; }
        public string TelefonoProveedor { get; set; }
    }
    public class UpdateProductoCommandHandler : IRequestHandler<UpdateProductoCommand, Response<int>>
    {
        private readonly IRepositoryAsync<Producto> _repositoryAsync;
        private readonly IMapper _mapper;

        public UpdateProductoCommandHandler(IRepositoryAsync<Producto> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(UpdateProductoCommand request, CancellationToken cancellationToken)
        {

            var producto = await _repositoryAsync.GetByIdAsync(request.Codigo);

            if (producto == null)
            {
                throw new KeyNotFoundException($"Producto no encontrado con el Código {request.Codigo}");
            }
            else
            {
                producto.Descripcion = request.Descripcion;
                producto.FechaFabricacion = request.FechaFabricacion;
                producto.FechaValidez = request.FechaValidez;
                producto.CodigoProveedor = request.CodigoProveedor;
                producto.DescripcionProveedor = request.DescripcionProveedor;
                producto.TelefonoProveedor = request.TelefonoProveedor;

                await _repositoryAsync.UpdateAsync(producto);

                return new Response<int>(producto.Codigo);
            }
        }
    }
}
