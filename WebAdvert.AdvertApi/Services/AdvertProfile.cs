using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebAdvert.AdvertApi.Models;

namespace WebAdvert.AdvertApi.Services
{
    public class AdvertProfile : Profile
    {
        public AdvertProfile()
        {
            CreateMap<AdvertDbModel, AdvertModel>().ReverseMap();
        }
    }
}
