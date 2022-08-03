using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Productos.Commands.DeleteProductoCommand
{
    public class DeleteProductoCommand : IRequest<Response<int>>
    {
        public int Codigo { get; set; }
    }
    public class DeleteProductoCommandHandler : IRequestHandler<DeleteProductoCommand, Response<int>>
    {
        private readonly IRepositoryAsync<Producto> _repositoryAsync;
        private readonly IMapper _mapper;

        public DeleteProductoCommandHandler(IRepositoryAsync<Producto> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(DeleteProductoCommand request, CancellationToken cancellationToken)
        {

            var producto = await _repositoryAsync.GetByIdAsync(request.Codigo);

            if (producto == null)
            {
                throw new KeyNotFoundException($"Producto no encontrado con el Código {request.Codigo}");
            }
            else
            {
                producto.Estado = "Inactivo";

                await _repositoryAsync.UpdateAsync(producto);

                return new Response<int>(producto.Codigo);
            }
        }
    }
}
