using AngularXam.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AngularXam.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AngularDetailPage : ContentPage
	{
		public AngularDetailPage ()
		{
			InitializeComponent ();
            BindingContext = new AngularDetailPageViewModel();
		}
	}
}