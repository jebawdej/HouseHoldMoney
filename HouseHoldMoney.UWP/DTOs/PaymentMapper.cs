using AutoMapper;
using HouseHoldMoney.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseHoldMoney.UWP.DTOs
{
    class PaymentMapper
    {
        public PaymentMapper()
        {
            //Mapper.Initialize(cfg => cfg.CreateMap<HouseHoldMoney.Model.Payment, PaymentDTO>());
        }

        public HouseHoldMoney.Model.Payment ConvertFromDTO(PaymentDTO paymentDto)
        {
            return Mapper.Map<HouseHoldMoney.Model.Payment>(paymentDto);
        }
        public ObservableCollection<Payment> ConvertFromDTO(ObservableCollection<PaymentDTO> paymentDto)
        {
            ObservableCollection<Payment> payments = new ObservableCollection<Payment>();
            foreach (PaymentDTO dto in paymentDto)
            {
                payments.Add(ConvertFromDTO(dto));
            }

            return payments;
        }


        public PaymentDTO ConvertToDTO(HouseHoldMoney.Model.Payment payment)
        {
            return Mapper.Map<PaymentDTO>(payment);
        }
        public ObservableCollection<PaymentDTO> ConvertToDTO(ObservableCollection<Payment> payment)
        {
            ObservableCollection<PaymentDTO> paymentDtos = new ObservableCollection<PaymentDTO>();

            foreach (Payment p in payment)
            {
                paymentDtos.Add(ConvertToDTO(p));
            }

            return paymentDtos;
        }
    }
}
