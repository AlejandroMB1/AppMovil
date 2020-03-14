using System;
using System.Collections.Generic;
using System.Text;
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

        public int DatoGuardado { get; set; }

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
            UsuarioModel usuario1 = new UsuarioModel()
            {
                NumDocumento = "12345678",
                Nombres = "Carlos",
                Apellidos = "Perez",
                Edad = 23,
                Contrasenia = "1234",
                Correo = "carlos@email.com"

            };

            await Task.FromResult(true);
        }
        #endregion Metodos
    }
}
