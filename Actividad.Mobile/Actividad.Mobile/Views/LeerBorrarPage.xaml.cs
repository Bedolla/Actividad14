using Actividad.Mobile.Services;
using Actividad.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Actividad.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LeerBorrarPage : ContentPage
    {
        public LeerBorrarPage()
        {
            this.InitializeComponent();
            this.BindingContext = InjeccionDependencia.Proveedor.GetService<LeerBorrarViewModel>();
        }

        protected override void OnAppearing() => ((LeerBorrarViewModel)this.BindingContext).ListarUsuarios();
    }
}
