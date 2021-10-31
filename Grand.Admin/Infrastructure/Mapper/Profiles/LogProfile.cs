﻿using AutoMapper;
using Grand.Domain.Logging;
using Grand.Core.Infrastructure.Mapper;
using Grand.Admin.Models.Logging;

namespace Grand.Admin.Infrastructure.Mapper.Profiles
{
    public class LogProfile : Profile, IMapperProfile
    {
        public LogProfile()
        {
            CreateMap<Log, LogModel>()
                .ForMember(dest => dest.CustomerEmail, mo => mo.Ignore())
                .ForMember(dest => dest.CreatedOn, mo => mo.Ignore());

            CreateMap<LogModel, Log>()
                .ForMember(dest => dest.Id, mo => mo.Ignore())
                .ForMember(dest => dest.CreatedOnUtc, mo => mo.Ignore())
                .ForMember(dest => dest.LogLevelId, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}