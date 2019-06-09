using HouseHoldMoney.UWP.DTOs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HouseHoldMoney.UWP.Services
{
    public interface IDataService
    {
        ObservableCollection<HouseHoldMoneyDTO> GetAllHhm();
        ObservableCollection<PaymentDTO> GetAllPayment();
        HouseHoldMoneyDTO GetByID(Guid ID);
        bool SaveHouseHoldMoney(HouseHoldMoneyDTO houseHoldMoneyDto);
        bool DeleteHouseHoldMoney(Guid ID);
    }
}
