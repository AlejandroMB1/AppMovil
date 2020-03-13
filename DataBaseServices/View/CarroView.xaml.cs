using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseServices.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBaseServices.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarroView : ContentPage
    {
        CarroViewModel context = new CarroViewModel();
        public CarroView()
        {
            InitializeComponent();
            BindingContext = context;
        }
    }
}