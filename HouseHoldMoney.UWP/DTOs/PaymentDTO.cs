using GalaSoft.MvvmLight;
using HouseHoldMoney.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseHoldMoney.UWP.DTOs
{
    public class PaymentDTO : ObservableObject
    {
        public event EventHandler PaymentChanged;
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
                RaisePaymentChanged();
            }
        }


        private ThermOfPayment _termOfPayment;
        public ThermOfPayment TermOfPayment
        {
            get
            {
                return _termOfPayment;
            }
            set
            {
                Set<ThermOfPayment>(() => this.TermOfPayment, ref _termOfPayment, value);
                RaisePaymentChanged();
            }
        }



        private bool _jan;
        public bool Jan
        {
            get
            {
                return _jan;
            }
            set
            {
                Set<bool>(() => this.Jan, ref _jan, value);
                RaisePaymentChanged();
            }
        }

        private bool _feb;
        public bool Feb
        {
            get
            {
                return _feb;
            }
            set
            {
                Set<bool>(() => this.Feb, ref _feb, value);
                RaisePaymentChanged();
            }
        }

        private bool _mar;
        public bool Mar
        {
            get
            {
                return _mar;
            }
            set
            {
                Set<bool>(() => this.Mar, ref _mar, value);
                RaisePaymentChanged();
            }
        }

        private bool _apr;
        public bool Apr
        {
            get
            {
                return _apr;
            }
            set
            {
                Set<bool>(() => this.Apr, ref _apr, value);
                RaisePaymentChanged();
            }
        }

        private bool _may;
        public bool May
        {
            get
            {
                return _may;
            }
            set
            {
                Set<bool>(() => this.May, ref _may, value);
                RaisePaymentChanged();
            }
        }

        private bool _jun;
        public bool Jun
        {
            get
            {
                return _jun;
            }
            set
            {
                Set<bool>(() => this.Jun, ref _jun, value);
                RaisePaymentChanged();
            }
        }

        private bool _jul;
        public bool Jul
        {
            get
            {
                return _jul;
            }
            set
            {
                Set<bool>(() => this.Jul, ref _jul, value);
                RaisePaymentChanged();
            }
        }

        private bool _aug;
        public bool Aug
        {
            get
            {
                return _aug;
            }
            set
            {
                Set<bool>(() => this.Aug, ref _aug, value);
                RaisePaymentChanged();
            }
        }

        private bool _sep;
        public bool Sep
        {
            get
            {
                return _sep;
            }
            set
            {
                Set<bool>(() => this.Sep, ref _sep, value);
                RaisePaymentChanged();
            }
        }

        private bool _oct;
        public bool Oct
        {
            get
            {
                return _oct;
            }
            set
            {
                Set<bool>(() => this.Oct, ref _oct, value);
                RaisePaymentChanged();
            }
        }

        private bool _nov;
        public bool Nov
        {
            get
            {
                return _nov;
            }
            set
            {
                Set<bool>(() => this.Nov, ref _nov, value);
                RaisePaymentChanged();
            }
        }

        private bool _dec;
        public bool Dec
        {
            get
            {
                return _dec;
            }
            set
            {
                Set<bool>(() => this.Dec, ref _dec, value);
                RaisePaymentChanged();
            }
        }

        private void RaisePaymentChanged()
        {
            PaymentChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
