using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using DataBaseServices.Models;
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
        #endregion Properties

        #region Initialize
        public CarroViewModel()
        {
            Carro = new CarroModel()
            {
                Marca = "Audi",
                Color = "Azul"
            };

            CarroVista = new CarroModel() 
            { 
                Marca = "Chevrolet",
                Color = "Blanco"
            
            };

            ActualizarDatosCommand = new Command(() => ActualizarDatos(), () => true);

            if (Application.Current.Properties.ContainsKey("ValorGuardado"))
            {
                DatoGuardado = (int)Application.Current.Properties["ValorGuardado"];
            }

        }
        #endregion Initialize

        #region Metodos

        public void ActualizarDatos()
        {
            CarroVista.Marca = Carro.Marca;
            CarroVista.Color = Carro.Color;

        }

        #endregion Metodos
    }
}
