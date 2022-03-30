using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using PruebaFinal.Models;
using PruebaFinal.DTOS;
namespace PruebaFinal.DTOS

{
public class MapperConfig:Profile
    {
        public override string ProfileName
        {
            get
            {
                return "MapperConfig";
            }
        }

        public MapperConfig()   
        {
            MapperConfiguration();
        }

        private void MapperConfiguration()
        {
            CreateMap<Cliente, ClienteDTO>().ReverseMap();

           
        }
    }
}
