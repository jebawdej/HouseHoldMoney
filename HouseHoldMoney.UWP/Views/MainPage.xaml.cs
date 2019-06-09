using HouseHoldMoney.Model;
using Microsoft.EntityFrameworkCore;
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
using HouseHoldMoney.UWP.ViewModels;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HouseHoldMoney.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPageViewModel Vm
        {
            get
            {
                return (MainPageViewModel)DataContext;
            }
        }

        public MainPage()
        {
            //using (var db = new HouseHoldContext())
            //{
            //    //Payment paymnt = db.Payments.FirstOrDefault(p => p.TermOfPayment == ThermOfPayment.MONTHLY);
            //    //if (paymnt != null)
            //    //{
            //    //    db.HouseHoldMoneys.Add(new Model.HouseHoldMoney() { ID = Guid.NewGuid(), Organisation = "Unive", Description = "Zorg verzekering", Payment = paymnt, Amount = 289.30d, Automatically = true });
            //    //    db.SaveChanges();
            //    //}
            //    //Model.HouseHoldMoney hhm = db.HouseHoldMoneys.Include(h => h.Payment).FirstOrDefault();
            //}
            this.InitializeComponent();

        }
    }
}
