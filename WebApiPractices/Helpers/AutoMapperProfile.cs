﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPractices.Entities;

namespace WebApiPractices.Helpers
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            //CreateMap<>(Entity, DTO).ReverseMap();
        }
    }
}
