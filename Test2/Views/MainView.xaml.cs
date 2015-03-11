using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Test2
{
	public partial class MainView : ContentPage
	{
		public MainView ()
		{
			InitializeComponent ();
			myVM = new MainViewModel ();
			BindingContext = myVM;
		}

		private MainViewModel myVM;
	}
}

