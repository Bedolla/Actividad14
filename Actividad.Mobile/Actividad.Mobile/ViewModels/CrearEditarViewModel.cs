using Actividad.Data.Constants;
using Actividad.Data.Entities;
using Actividad.Mobile.Extensions;
using Actividad.Mobile.Services;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Actividad.Mobile.ViewModels
{
    public class CrearEditarViewModel : BaseViewModel
    {
        private string _botonGuardar;
        private string _informacion;
        private Usuario _usuario;

        public CrearEditarViewModel(Usuario usuario)
        {
            if (usuario is null || usuario.Id.EsNulo())
            {
                this.Limpiar();
            }
            else
            {
                this.Usuario = usuario;
                this.BotonGuardar = "Editar";
            }

            this.LimpiarCommand = new Command(this.Limpiar);
            this.GuardarCommand = new Command(this.Guardar);
        }

        public CrearEditarViewModel(IServicioUsuarios servicioUsuarios)
        {
            this.ServicioUsuarios = servicioUsuarios;
            this.LimpiarCommand = new Command(this.Limpiar);
            this.GuardarCommand = new Command(this.Guardar);
        }

        public CrearEditarViewModel() { }

        private IServicioUsuarios ServicioUsuarios { get; }

        public Usuario Usuario
        {
            get => this._usuario;
            set
            {
                this._usuario = value;
                this.OnPropertyChanged();
            }
        }

        public string Informacion
        {
            get => this._informacion;
            set
            {
                this._informacion = value;
                this.OnPropertyChanged();
            }
        }

        public string BotonGuardar
        {
            get => this._botonGuardar;
            set
            {
                this._botonGuardar = value;
                this.OnPropertyChanged();
            }
        }

        public ICommand LimpiarCommand { get; set; }
        public ICommand GuardarCommand { get; set; }

        public void Inicializar(Usuario usuario)
        {
            if (usuario is null || usuario.Id.EsNulo())
            {
                this.Limpiar();
            }
            else
            {
                this.Usuario = usuario;
                this.BotonGuardar = "Editar";
            }
        }

        private async void Guardar()
        {
            try
            {
                if
                (
                    this.Usuario.Nombre.EsNulo() ||
                    this.Usuario.Apellido.EsNulo() ||
                    this.Usuario.Correo.EsNulo() ||
                    this.Usuario.Clave.EsNulo() ||
                    this.Usuario.Foto.EsNulo()
                )
                {
                    this.Informacion = "Debe llenar todos los campos";
                    return;
                }

                Usuario usuarioEncontrado = await this.ServicioUsuarios.ObtenerAsync(this.Usuario.Correo);
                if (usuarioEncontrado is null || (usuarioEncontrado.Id == this.Usuario.Id))
                {
                    if (this.Usuario.Id.EsNulo())
                    {
                        this.Usuario.Id = Guid.NewGuid().ToString();
                        this.Usuario.Rol = Roles.Soporte;
                        this.Usuario.Creacion = DateTime.Now;
                        this.Usuario.Disponible = true;

                        await this.ServicioUsuarios.CrearAsync(this.Usuario);
                    }
                    else
                    {
                        await this.ServicioUsuarios.EditarAsync(this.Usuario);
                    }

                    if (this.BotonGuardar.Equals("Crear"))
                    {
                        this.Usuario.Id = null;
                        this.Limpiar();
                        this.Informacion = "Usuario creado";
                    }
                    else
                    {
                        await Application.Current.MainPage.DisplayAlert("Aviso", "Usuario editado", "Entendido");
                        await Application.Current.MainPage.Navigation.PopAsync();
                    }
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Duplicado", "Ya hay un usuario con ese Correo.", "Entendido");
                }
            }
            catch (Exception excepcion)
            {
                this.Informacion = excepcion.Message;
            }
        }

        private void Limpiar()
        {
            this.Usuario = new Usuario
            {
                Id = this.Usuario?.Id.Valor(),
                Nombre = String.Empty,
                Apellido = String.Empty,
                Correo = String.Empty,
                Clave = String.Empty,
                Foto = String.Empty
            };

            this.Informacion = String.Empty;
            this.BotonGuardar = this.Usuario.Id.EsNulo() ? "Crear" : "Editar";
        }
    }
}
