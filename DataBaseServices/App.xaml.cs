using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DataBaseServices.View;
using DataBaseServices.Services.Handler;
using DataBaseServices.Services.DataBase;
using System.IO;

namespace DataBaseServices
{
    public partial class App : Application
    {
        #region Properties
        static MemoryDataHandler MemoryHandler;
        static DataBase database;
        #endregion Properties

        #region Getters/Setters
        public static DataBase Database
        {
            get
            {
                if (database == null)
                {
                    database = new DataBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "dbCadena.db3"));
                }
                return database;
            }
        }
        #endregion
        public App()
        {
            InitializeComponent();
            Application.Current.Properties["ValorGuardado"] = 25;
            //MainPage = new CarroView();
            MemoryHandler = new MemoryDataHandler();

            //MainPage = new MainPage();
        }

        protected override async void OnStart()
        {
            //await MemoryHandler.SaveData("valorGuardado", 25);
            //await MemoryHandler.GetData("perro");
            //await MemoryHandler.GetData("valorGuardado");
            MainPage = new UsuarioView();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
