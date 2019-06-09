using GalaSoft.MvvmLight;
using HouseHoldMoney.UWP.DTOs;
using HouseHoldMoney.UWP.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseHoldMoney.UWP.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;
        private ObservableCollection<HouseHoldMoneyDTO> _houseHoldMoneyCollection;
        private ObservableCollection<PaymentDTO> _paymentCollection;

        private bool _isLoading = false;
        public MainPageViewModel(IDataService dataService)
        {
            Title = "Mijn eigen Titel";
            _dataService = dataService;
            _houseHoldMoneyCollection = _dataService.GetAllHhm();
            _paymentCollection = _dataService.GetAllPayment();
            //HouseHoldMoneyDTO dto = _houseHoldMoneyCollection[0];
            //dto.Organisation = "Unive aangepast";
            //dto.Payment = _paymentCollection[7];
            //_dataService.SaveHouseHoldMoney(dto);

            //dto = new HouseHoldMoneyDTO();
            //dto.Organisation = "Essent";
            //dto.Description = "electriciteits kosten";
            //dto.Automatically = true;
            //dto.Amount = 78.90;
            //dto.Payment = _paymentCollection.FirstOrDefault(p => p.TermOfPayment == Model.ThermOfPayment.MONTHLY);
            //_dataService.SaveHouseHoldMoney(dto);
            //HouseHoldMoneyDTO dto = _houseHoldMoneyCollection.FirstOrDefault(h => h.Organisation == "Essent");
            //if(dto != null)
            //{
            //    _dataService.DeleteHouseHoldMoney(dto.ID);
            //}
            

        }


        public ObservableCollection<HouseHoldMoneyDTO> HouseHoldMoneyCollection
        {
            get
            {
                return _houseHoldMoneyCollection;
            }
            set
            {
                _houseHoldMoneyCollection = value;
                RaisePropertyChanged("HouseHoldMoneyCollection");

            }
        }
        private HouseHoldMoneyDTO _selectedHouseHoldMoneyItem;
        public HouseHoldMoneyDTO SelectedHouseHoldMoneyItem
        {
            get
            {
                if ((_selectedHouseHoldMoneyItem == null) && (HouseHoldMoneyCollection.Count > 0))
                    return HouseHoldMoneyCollection[0];
                else
                    return _selectedHouseHoldMoneyItem;
            }
            set
            {
                _selectedHouseHoldMoneyItem = value;
                RaisePropertyChanged("SelectedHouseHoldMoneyItem");
            }
        }
        

        public bool IsLoading
        {
            get
            {
                return _isLoading;
            }
            set
            {
                _isLoading = value;
                RaisePropertyChanged("IsLoading");

            }
        }
        private string _title;
        public string Title
        {

            get
            {
                return _title;
            }
            set
            {
                if (value != _title)
                {
                    _title = value;
                    RaisePropertyChanged("Title");
                }
            }
        }
    }
}
