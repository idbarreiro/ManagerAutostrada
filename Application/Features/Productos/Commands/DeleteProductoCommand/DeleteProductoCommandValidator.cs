using FluentValidation;

namespace Application.Features.Productos.Commands.DeleteProductoCommand
{
    public class DeleteProductoCommandValidator : AbstractValidator<DeleteProductoCommand>
    {
        public DeleteProductoCommandValidator()
        {
            RuleFor(p => p.Codigo)
                .NotEmpty().WithMessage("{PropertyName} no puede ser vacío.");
        }
    }
}
