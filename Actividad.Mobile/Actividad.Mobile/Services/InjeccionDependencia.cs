using Actividad.Data.Constants;
using Actividad.Mobile.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Actividad.Mobile.Services
{
    public static class InjeccionDependencia
    {
        public static IServiceProvider Proveedor { get; set; }

        private static IServiceCollection ConfigurarServicios(this IServiceCollection servicios)
        {
            servicios.AddHttpClient<IServicioUsuarios, ServicioUsuarios>(c => c.BaseAddress = new Uri(Uris.Api));
            servicios.AddTransient<LeerBorrarViewModel>();
            servicios.AddTransient<CrearEditarViewModel>();

            return servicios;
        }

        public static void Inicializar() =>
            InjeccionDependencia.Proveedor = new ServiceCollection()
                                             .ConfigurarServicios()
                                             .BuildServiceProvider();
    }
}
