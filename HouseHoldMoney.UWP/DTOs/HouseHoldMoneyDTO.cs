using GalaSoft.MvvmLight;
using HouseHoldMoney.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseHoldMoney.UWP.DTOs
{
    public class HouseHoldMoneyDTO : ObservableObject
    {
        public event EventHandler HouseHoldMoneyChanged;

        private Guid _iD;
        public Guid ID
        {
            get
            {
                return _iD;
            }
            set
            {
                Set<Guid>(() => this.ID, ref _iD, value);
                RaiseHouseHoldMoneyChanged();
            }
        }

        private string _organisation;
        public string Organisation
        {
            get
            {
                return _organisation;
            }
            set
            {
                Set<string>(() => this.Organisation, ref _organisation, value);
                RaiseHouseHoldMoneyChanged();
            }
        }

        private string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                Set<string>(() => this.Description, ref _description, value);
                RaiseHouseHoldMoneyChanged();
            }
        }

        private double _amount;
        public double Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                Set<double>(() => this.Amount, ref _amount, value);
                RaiseHouseHoldMoneyChanged();
            }
        }

        private bool _automatically;
        public bool Automatically
        {
            get
            {
                return _automatically;
            }
            set
            {
                Set<bool>(() => this.Automatically, ref _automatically, value);
                RaiseHouseHoldMoneyChanged();
            }
        }

        private PaymentDTO _payment;
        public PaymentDTO Payment
        {
            get
            {
                return _payment;
            }
            set
            {
                Set<PaymentDTO>(() => this.Payment, ref _payment, value);
                RaiseHouseHoldMoneyChanged();
            }
        }

        private void RaiseHouseHoldMoneyChanged()
        {
            HouseHoldMoneyChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
