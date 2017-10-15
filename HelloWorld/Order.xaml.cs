using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace HelloWorld
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Order : Page
    {
        public Order(Window window)
        {
            this.InitializeComponent();

            DateTime date = DateTime.Now;

            widthBox.Text = "2";
            heightBox.Text = "2";
            tintBox.Text = "2";
            quantityBox.Text = "2";
            dateBox.Text = "2";
            areaBox.Text = "2";
            lengthBox.Text = "2";

            //widthBox.Text = window.windowWidth.ToString();
            //heightBox.Text = window.windowHeight.ToString();
            //tintBox.Text = window.tint;
            //quantityBox.Text = window.quantity.ToString();
            //dateBox.Text = date.ToString();
            //areaBox.Text = window.area.ToString();
            //lengthBox.Text = window.length.ToString();
        }


        

    }
}
