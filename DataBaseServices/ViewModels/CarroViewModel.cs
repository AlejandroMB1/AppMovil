using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using DataBaseServices.Models;
using DataBaseServices.Services.DataBase;
using Xamarin.Forms;

namespace DataBaseServices.ViewModels
{
    public class CarroViewModel
    {
        #region Properties
        public CarroModel Carro { get; set; }

        public CarroModel CarroVista { get; set; }

        public ICommand ActualizarDatosCommand { get; set; }
        public ICommand GuardarDatosCommand { get; set; }

        public ICommand BorrarDatosCommand { get; set; }

        public int DatoGuardado { get; set; }
        public int id { get; set; }
        public UsuarioModel Usuario1 { get; set; }

        //servicios
        public IUsuarioDataBase<UsuarioModel> ServicioUsuarioDB { get; set; }
        #endregion Properties

        #region Initialize
        public CarroViewModel()
        {
            //Carro = new CarroModel()
            //{
            //    Marca = "Audi",
            //    Color = "Azul",
            //    Pasajeros = 3
            //};

            //CarroVista = new CarroModel() 
            //{ 
            //    Marca = "Chevrolet",
            //    Color = "Blanco",
            //    Pasajeros = 4

            //};

            //ActualizarDatosCommand = new Command(() => ActualizarDatos(), () => true);

            //if (Application.Current.Properties.ContainsKey("ValorGuardado"))
            //{
            //    var datoGuardado = (int)Application.Current.Properties["ValorGuardado"];
            //    DatoGuardado = Convert.ToInt32(DatoGuardado);
            //}
            ServicioUsuarioDB = new UsuarioDataBase<UsuarioModel>();
            GuardarDatosCommand = new Command(async () => await GuardarUsuario(), () => true);
            Usuario1 = new UsuarioModel();
            BorrarDatosCommand = new Command(async () => await BorrarUsuario(), () => true);
            //GuardarUsuario();
        }
        #endregion Initialize

        #region Metodos

        public void ActualizarDatos()
        {
            CarroVista.Marca = Carro.Marca;
            CarroVista.Color = Carro.Color;
            CarroVista.Pasajeros = Carro.Pasajeros;

        }
        public async Task GuardarUsuario()
        {
            UsuarioModel usuario2 = new UsuarioModel()
            {
                NumDocumento = "12445678",
                Nombres = "Andres",
                Apellidos = "Salazar",
                Edad = 25,
                Contrasenia = "1234",
                Correo = "andreswebcam@sexy.com"
            };

            int id = await ServicioUsuarioDB.InsertItemAsync(usuario2);
            Thread.Sleep(500);
            UsuarioModel usuario3 = await ServicioUsuarioDB.GetItemAsync(id);

            Usuario1.NumDocumento = usuario3.NumDocumento;
            Usuario1.Nombres = usuario3.Nombres;
            Usuario1.Apellidos = usuario3.Apellidos;
            Usuario1.Edad = usuario3.Edad;
            Usuario1.Contrasenia = usuario3.Contrasenia;
            Usuario1.Correo = usuario3.Correo;

            Usuario1 = new UsuarioModel();

            await Task.FromResult(true);

        }
        public async Task BorrarUsuario()
        {
            Thread.Sleep(500);
            await Task.FromResult(true);
        }
        #endregion Metodos
    }
}
