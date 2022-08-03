using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Productos.Commands.CreateProductoCommand
{
    public class CreateProductoCommand : IRequest<Response<int>>
    {
        public string Descripcion { get; set; }
        public DateTime FechaFabricacion { get; set; }
        public DateTime FechaValidez { get; set; }
        public int CodigoProveedor { get; set; }
        public string DescripcionProveedor { get; set; }
        public string TelefonoProveedor { get; set; }
    }
    public class CreateProductoCommandHandler : IRequestHandler<CreateProductoCommand, Response<int>>
    {
        private readonly IRepositoryAsync<Producto> _repositoryAsync;
        private readonly IMapper _mapper;

        public CreateProductoCommandHandler(IRepositoryAsync<Producto> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(CreateProductoCommand request, CancellationToken cancellationToken)
        {
            
            var nuevoRegistro = _mapper.Map<Producto>(request);
            nuevoRegistro.Estado = "Activo";
            var data = await _repositoryAsync.AddAsync(nuevoRegistro);

            return new Response<int>(data.Codigo);
        }
    }
}
