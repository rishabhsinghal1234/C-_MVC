using AutoMapper;
using MVC_Application.Dtos;
using MVC_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Application.App_Start
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<MovieDto, Movie>();
            Mapper.CreateMap<Movie, MovieDto>();
        }
    }
}