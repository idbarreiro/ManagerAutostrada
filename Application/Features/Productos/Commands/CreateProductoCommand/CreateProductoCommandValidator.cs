using FluentValidation;

namespace Application.Features.Productos.Commands.CreateProductoCommand
{
    public class CreateProductoCommandValidator : AbstractValidator<CreateProductoCommand>
    {
        public CreateProductoCommandValidator()
        {
            RuleFor(p => p.Descripcion)
                .NotEmpty().WithMessage("{PropertyName} no puede ser vacío.")
                .MaximumLength(200).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");
            RuleFor(p => p.FechaFabricacion)
                .NotEmpty().WithMessage("Fecha de fabricación no puede ser vacía.");
            RuleFor(p => p.FechaValidez)
                .NotEmpty().WithMessage("Fecha de validez no puede ser vacía.");
            RuleFor(p => p.CodigoProveedor)
                .NotEmpty().WithMessage("Codigo del proveedor no puede ser vacío.");
            RuleFor(p => p.DescripcionProveedor)
                .NotEmpty().WithMessage("Descripción del proveedor no puede ser vacío.")
                .MaximumLength(200).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");
            RuleFor(p => p.TelefonoProveedor)
                .NotEmpty().WithMessage("Telefono del proveedor no puede ser vacio.")
                .MaximumLength(10).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");
        }
    }
}
