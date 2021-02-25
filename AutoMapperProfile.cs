using System.Linq;
using AutoMapper;
using dotnet_rpg.Dtos.Character;
using dotnet_rpg.Dtos.Skill;
using dotnet_rpg.Dtos.Weapon;
using dotnet_rpg.Models;

namespace dotnet_rpg
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character,GetCharacterDto>()
            // Getting Skills directly
            .ForMember(dto => dto.Skills,x => x.MapFrom(x=> x.CharacterSkills.Select(x=>x.Skill)));
            CreateMap<AddCharacterDto,Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
            

        }
    }
}