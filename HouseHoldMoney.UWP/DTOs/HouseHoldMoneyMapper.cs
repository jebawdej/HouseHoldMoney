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
    class HouseHoldMoneyMapper
    {
        private PaymentMapper pMapper;
        public HouseHoldMoneyMapper()
        {
            Mapper.Initialize(cfg => { 
            cfg.CreateMap<Model.HouseHoldMoney, HouseHoldMoneyDTO>().ForMember(x => x.Payment, opt => opt.Ignore());
            cfg.CreateMap<Payment, PaymentDTO>();
                });
            pMapper = new PaymentMapper();
        }

        public HouseHoldMoney.Model.HouseHoldMoney ConvertFromDTO(HouseHoldMoneyDTO houseHoldMoneyDto)
        {
            HouseHoldMoney.Model.HouseHoldMoney entity = Mapper.Map<HouseHoldMoney.Model.HouseHoldMoney>(houseHoldMoneyDto);
            entity.Payment = pMapper.ConvertFromDTO(houseHoldMoneyDto.Payment);
            return entity;
        }

        public ObservableCollection<HouseHoldMoney.Model.HouseHoldMoney> ConvertFromDTO(ObservableCollection<HouseHoldMoneyDTO> houseHoldMoneyDto)
        {
            ObservableCollection<HouseHoldMoney.Model.HouseHoldMoney> persons = new ObservableCollection<HouseHoldMoney.Model.HouseHoldMoney>();
            foreach (HouseHoldMoneyDTO dto in houseHoldMoneyDto)
            {
                persons.Add(ConvertFromDTO(dto));
            }

            return persons;
        }

        public HouseHoldMoneyDTO ConvertToDTO(HouseHoldMoney.Model.HouseHoldMoney houseHoldMoney)
        {
            HouseHoldMoneyDTO dto = Mapper.Map<HouseHoldMoneyDTO>(houseHoldMoney);
            dto.Payment = pMapper.ConvertToDTO(houseHoldMoney.Payment);
            return dto;
        }

        public ObservableCollection<HouseHoldMoneyDTO> ConvertToDTO(ObservableCollection<HouseHoldMoney.Model.HouseHoldMoney> persons)
        {
            ObservableCollection<HouseHoldMoneyDTO> houseHoldMoneyDto = new ObservableCollection<HouseHoldMoneyDTO>();

            foreach (HouseHoldMoney.Model.HouseHoldMoney p in persons)
            {
                houseHoldMoneyDto.Add(ConvertToDTO(p));
            }

            return houseHoldMoneyDto;
        }
    }
}
