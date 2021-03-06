﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using DataBaseServices.Models;
using SQLiteNetExtensions.Attributes;

namespace DataBaseServices.Models
{
    public class CarroModel : NotificationObjectModel
    {
        #region Properties
        [PrimaryKey, AutoIncrement]
        public int IDCarro { get; set; }

        [ForeignKey(typeof(UsuarioModel))]
        public int IDUsuario { get; set; }

        private int pasajeros; //Propagables

        public string Marca { get; set; } //No propagables

        private string color; //Propagables

        public string Year { get; set; } //No propagables

        public string Modelo { get; set; } //No propagables

        private double tanque;

       
        #endregion Properties

        #region Getters/Setters
        
        public int Pasajeros
        {
            get { return pasajeros; }
            set
            { 
                pasajeros = value;
                OnPropertyChanged();
            }
        }

        public string Color
        {
            get { return color; }
            set 
            {
                color = value;
                OnPropertyChanged();
            }
        }

        public double Tanque
        {
            get { return tanque; }
            set
            {
                tanque = value;
                OnPropertyChanged();
            }
        }


        #endregion Getters/Setters
    }
}
