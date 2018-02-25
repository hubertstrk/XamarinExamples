using ListView.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListView.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Fields : ContentPage
    {
        public Fields()
        {
            InitializeComponent();

            BindingContext = new FieldsViewModel();
        }
    }
}