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

namespace fromdesign
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            //int Mobile = Convert.ToInt32(Console.ReadLine());
            this.InitializeComponent();
        }
        List<validity> vd = new List<validity>();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            validity vd = new validity();
            vd.FirstName = FirstName.Text.Trim();
            vd.LastName = LastName.Text.Trim();
            vd.Email = Email.Text.Trim();
            vd.Mobile = Mobile.Text.Trim();
            vd.address = Address.Text.Trim();

        }
    }
}
