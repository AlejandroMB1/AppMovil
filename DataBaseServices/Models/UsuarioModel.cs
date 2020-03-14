using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseServices.Models
{
    public class UsuarioModel : NotificationObjectModel
    {
        #region Properties
               
        private string nombres;      

        private string apellidos;
        public string Contraseña { get; set; }

        public string Usuario { get; set; }

        public int Edad { get; set; }

        private string correo;

        private string numDocumento;

        [PrimaryKey, AutoIncrement]
        public int IDUsuario { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]

        public List<CarroModel> Carros { get; set; }
        #endregion Properties

        #region Getters/Setters
        public string Nombres
        {
            get { return nombres; }
            set
            {
                nombres = value;
                OnPropertyChanged();
            }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set
            {
                apellidos = value;
                OnPropertyChanged();
            }
        }
        public string Correo
        {
            get { return correo; }
            set
            {
                correo = value;
                OnPropertyChanged();
            }
        }

        public string NumDocumento
        {
            get { return numDocumento; }
            set
            {
                numDocumento = value;
                OnPropertyChanged();
            }
        }
        #endregion Getters/Setters
    }
}
