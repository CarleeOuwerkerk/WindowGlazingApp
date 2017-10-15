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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HelloWorld
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            List<string> colours = new List<string>();
            colours.Add("Black");
            colours.Add("Blue");
            colours.Add("Brown");
            colourDropdown.ItemsSource = colours;
        }

        const double MAX_WIDTH = 5.0;
        const double MIN_WIDTH = 0.5;
        const double MAX_HEIGHT = 3.0;
        const double MIN_HEIGHT = 0.75;

        GlazeProp window = new GlazeProp();




        private void Slider_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            window.numberOfWindows = quantitySlider.Value;

        }

        public void calculateLength(double width, double height)
        {
            window.length = (2 * (width + height) * 3.25);
        }

        public void calculateArea(double width, double height)
        {
            window.area = (2 * (width * height));
        }

        private void colourDropdown_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            window.tint = colourDropdown.DataContext.ToString();
        }

        private void widthBox_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            string widthText = widthBox.Text;

            try
            {
                double width = double.Parse(widthText);

                if ((width >= MIN_WIDTH) && (width <= MAX_WIDTH))
                {
                    window.windowWidth = width;

                    widthWarning.Text = " ";

                    submitButton.IsEnabled = true;                    
                }
                else
                {
                    widthWarning.Text = "Please enter a value between "
                    + MIN_WIDTH
                    + " and "
                    + MAX_WIDTH;

                    submitButton.IsEnabled = false;
                }

            }
            catch (Exception ex)
            {
                widthWarning.Text = "Please enter a value between "
                    + MIN_WIDTH
                    + " and "
                    + MAX_WIDTH;

                submitButton.IsEnabled = false;
            }
        }

        private void heightBox_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            string heightText = heightBox.Text;

            try
            {
                double height = double.Parse(heightText);

                if ((height >= MIN_HEIGHT) && (height <= MAX_HEIGHT))
                {
                    window.windowHeight = height;

                    heightWarning.Text = " ";

                    submitButton.IsEnabled = true;
                }
                else
                {
                    heightWarning.Text = "Please enter a value between "
                    + MIN_HEIGHT
                    + " and "
                    + MAX_HEIGHT;

                    submitButton.IsEnabled = false;
                }
            }
            catch (Exception ex)
            {
                heightWarning.Text = "Please enter a value between "
                    + MIN_HEIGHT
                    + " and "
                    + MAX_HEIGHT;

                submitButton.IsEnabled = false;
            }
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            calculateLength(double.Parse(widthBox.Text), double.Parse(heightBox.Text));

            calculateArea(double.Parse(widthBox.Text), double.Parse(heightBox.Text));

                this.Frame.Navigate(typeof(Order), window);
        }
    }

    public class GlazeProp
    {
        public string tint { get; set; }
        public double numberOfWindows { get; set; }
        public double windowHeight { get; set; }
        public double windowWidth { get; set; }
        public double length { get; set; }
        public double area { get; set; }

    }
}

