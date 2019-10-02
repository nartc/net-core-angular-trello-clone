using System.Linq;
using AutoMapper;
using Trollo.Common.ViewModels;
using TrolloAPI.Data.Entities;

namespace TrolloAPI.Profiles
{
    public class ListCardProfile : Profile
    {
        public ListCardProfile()
        {
            CreateMap<ListCard, ListCardVm>().ReverseMap();
            CreateMap<ListCard, ListCardInformation>()
                .ForMember(d => d.CardIds, exp => exp.MapFrom(s => s.Cards.Select(c => c.Id)))
                .ReverseMap();
        }
    }
}