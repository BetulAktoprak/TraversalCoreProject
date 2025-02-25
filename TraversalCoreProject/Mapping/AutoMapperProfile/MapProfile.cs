﻿using AutoMapper;
using DTOLayer.DTOs.AnnouncementDTOs;
using DTOLayer.DTOs.AppUserDTOs;
using EntityLayer.Concrete;

namespace TraversalCoreProject.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AnnouncementAddDto, Announcement>().ReverseMap();

            CreateMap<AppUserRegisterDTOs, AppUser>().ReverseMap();

            CreateMap<AppUserLoginDTOs, AppUser>().ReverseMap();

            CreateMap<AnnouncementListDto, Announcement>().ReverseMap();

            CreateMap<AnnouncementUpdateDto, Announcement>().ReverseMap();
        }
    }
}
