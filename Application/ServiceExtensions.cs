using Application.Behaviours;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    public static class ServiceExtensions
    {
        //Agrupar las inyecciones o matricualas de nuestros servicios

        public static void AddApplicationLayer(this IServiceCollection services)
        {
            //Registre automaticamente los mapeos que se hagan en esta biblioteca de clases
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //Registre automaticamente las validaciones que se hagan en esta biblioteca de clases
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            //Registre automaticamente los mediadores que se implementen en esta biblioteca de clases
            services.AddMediatR(Assembly.GetExecutingAssembly());
            //Pipeline que valida el flujo a traves del patron mediator
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        }
    }
}
