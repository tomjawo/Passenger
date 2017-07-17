using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Passenger.Core;
using Passenger.Infrastructure.DTO;
using Passenger.Core.Domain;

namespace Passenger.Infrastructure.Mapers
{
    public static class AutoMapperConfig
    {
            public static IMapper Initialize()
            {
                var configuration = new MapperConfiguration
                (cfg =>
                    {
                         cfg.CreateMap<User, UserDto>();
                         cfg.CreateMap<Driver,DriverDto>();
                    }
                );
            return configuration.CreateMapper();
            }
    }
}
