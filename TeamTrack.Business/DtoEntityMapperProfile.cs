﻿using AutoMapper;
using TeamTrack.Common.Dtos;
using TeamTrack.Common.Model;

namespace TeamTrack.Business;

public class DtoEntityMapperProfile : Profile
{
    public DtoEntityMapperProfile()
    {
        CreateMap<AddressCreate, Address>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());
        CreateMap<AddressUpdate, Address>();
        CreateMap<Address, AddressGet>();
    }
}