using System;
using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Components;

namespace NUIXamlSimpleApp
{
	public partial class XamlPage : ContentPage
	{
        public XamlPage()
        {
            InitializeComponent();
        }

        private void start_Clicked(object sender, ClickedEventArgs e)
        {
            video.Play();
        }
    }
}
