using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Glazer_Calculation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        const double MAX_WIDTH = 5.0;
        const double MIN_WIDTH = 0.5;
        const double MAX_HEIGHT = 3.0;
        const double MIN_HEIGHT = 0.75;
        
        private void Slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            this.txtQuantity.Text = e.NewValue.ToString();
        }

        private void Click_ClickMe(object sender, RoutedEventArgs e)
        {
            //after validation
            //if true 
            double w = Convert.ToDouble(txtbWeight.Text);
            double h = Convert.ToDouble(txtbHeight.Text);

            lblWeight.Text = txtbWeight.Text;
            lblHeight.Text = txtbHeight.Text;
            lblTintColor.Text = cbboxTintColor.SelectedValue.ToString();
            lblQuantity.Text = txtQuantity.Text;
            lblLengFrame.Text = (2 * (w + h) * 3.25).ToString();
            lblAreaGlass.Text = (2 * w * h).ToString();
            lblOrderDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void Weight_Changed(object sender, KeyRoutedEventArgs e)
        {
           /*
            if (e.Key < Windows.System.VirtualKey.Number1 || 
                e.Key > Windows.System.VirtualKey.Number5)
            {
                txtbWeight.IsTapEnabled = true;
                txtbWeight.IsHitTestVisible = true;
                 txtbWeight.Focus(FocusState.Programmatic);
            }
            */
            
        }

        ObservableCollection<string> color = new ObservableCollection<string>();

        public MainPage()
        {
            this.InitializeComponent();
            color.Add("Black");
            color.Add("Brown");
            color.Add("Blue");
        }


    }
}
