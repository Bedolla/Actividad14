using Actividad.Data.Entities;
using Actividad.Mobile.Services;
using Actividad.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Actividad.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CrearEditarPage : ContentPage
    {
        public CrearEditarPage(Usuario usuario)
        {
            this.InitializeComponent();

            CrearEditarViewModel viewModel = InjeccionDependencia.Proveedor.GetService<CrearEditarViewModel>();
            viewModel.Inicializar(usuario);
            this.BindingContext = viewModel; // new CrearEditarViewModel(usuario);
        }
    }
}
