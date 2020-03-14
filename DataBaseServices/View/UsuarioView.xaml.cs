using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DataBaseServices.ViewModels;

namespace DataBaseServices.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsuarioView : ContentPage
    {
        CarroViewModel context = new CarroViewModel();
        public UsuarioView()
        {
            InitializeComponent();
            BindingContext = context;
        }
    }
}