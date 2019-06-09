using HouseHoldMoney.Model;
using HouseHoldMoney.UWP.DTOs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HouseHoldMoney.UWP.Services
{
    public class DataService : IDataService
    {
        HouseHoldContext context;
        HouseHoldMoneyMapper mapperHHM;
        PaymentMapper mapperP;
        public DataService()
        {
            //context = new HouseHoldContext();
            //var hhm = context.HouseHoldMoneys.
            mapperHHM = new HouseHoldMoneyMapper();
            mapperP = new PaymentMapper();
        }

        public bool DeleteHouseHoldMoney(Guid id)
        {
            using (context = new HouseHoldContext())
            {
                Model.HouseHoldMoney HouseHoldMoneyToDelete = context.HouseHoldMoneys.Include(h => h.Payment).FirstOrDefault(h => h.ID == id);
                if (HouseHoldMoneyToDelete != null)
                {
                    context.HouseHoldMoneys.Remove(HouseHoldMoneyToDelete);
                    context.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public ObservableCollection<HouseHoldMoneyDTO> GetAllHhm()
        {
            using (context = new HouseHoldContext())
            { 
                ObservableCollection<Model.HouseHoldMoney> HouseHoldMoneyList = new ObservableCollection<Model.HouseHoldMoney>(context.HouseHoldMoneys.Include(h => h.Payment).ToList());

                return mapperHHM.ConvertToDTO(HouseHoldMoneyList);
            }
        }
        public ObservableCollection<PaymentDTO> GetAllPayment()
        {
            using (context = new HouseHoldContext())
            {
                ObservableCollection<Payment> PaymentList = new ObservableCollection<Payment>(context.Payments.ToList());

                return mapperP.ConvertToDTO(PaymentList);
            }
        }
        public HouseHoldMoneyDTO GetByID(Guid id)
        {
            using (context = new HouseHoldContext())
            {
                Model.HouseHoldMoney houseHoldMoney = context.HouseHoldMoneys.FirstOrDefault(h => h.ID == id);
                if (houseHoldMoney != null)
                {
                    return mapperHHM.ConvertToDTO(houseHoldMoney);
                }
            }
            return null;
        }

        public bool SaveHouseHoldMoney(HouseHoldMoneyDTO houseHoldMoneyDto)
        {
            bool retVal = false;

            Model.HouseHoldMoney houseHoldMoney = mapperHHM.ConvertFromDTO(houseHoldMoneyDto);
            using (context = new HouseHoldContext())
            {
                if (houseHoldMoney != null)
                {
                    if (houseHoldMoney.ID == Guid.Empty)
                    {
                        //then add 
                        houseHoldMoney.ID = Guid.NewGuid();
                        context.HouseHoldMoneys.Add(houseHoldMoney);
                        context.Payments.Attach(houseHoldMoney.Payment);
                        retVal = true;
                    }
                    else
                    {
                        if (context.HouseHoldMoneys.Any(hhm => hhm.ID == houseHoldMoney.ID))
                        {
                            var orig = context.HouseHoldMoneys.FirstOrDefault(hhm => hhm.ID == houseHoldMoney.ID);
                            //Then update
                            CopyFromTo(houseHoldMoney, orig);

                            context.HouseHoldMoneys.Update(orig);
                            context.Payments.Update(orig.Payment);

                            retVal = true;
                        }
                    }

                    if (retVal)
                    {
                        try
                        {
                            context.SaveChanges();
                        }
                        catch (Exception e)
                        {
                            Debug.WriteLine("Error SaveHouseHoldMoney: \r\n{0}", e.InnerException);
                            retVal = false;
                        }
                    }
                }
                else
                {
                    Debug.WriteLine("Error SaveHouseHoldMoney: DTO could not be mapped to entity.");
                }
            }
            return retVal;
        }
        private void CopyFromTo(Model.HouseHoldMoney from, Model.HouseHoldMoney to)
        {
            to.Description = from.Description;
            to.Organisation = from.Organisation;
            to.Automatically = from.Automatically;
            to.Amount = from.Amount;
            to.Payment = from.Payment;
        }
    }
}
