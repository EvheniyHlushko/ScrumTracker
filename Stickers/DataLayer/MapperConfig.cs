using AutoMapper;
using DataLayer.Entities;
using DTO.Entities;

namespace DataLayer
{
    public class MapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.CreateMap<User, UserDto>();
            Mapper.CreateMap<UserDto, User>()
               // .ForMember(x => x.Role, opt => opt.Ignore())
                .ForMember(x => x.Department, opt => opt.Ignore())
                .ForMember(x => x.UserTeamPositions, opt => opt.Ignore());

            Mapper.CreateMap<Role, RoleDto>();
            Mapper.CreateMap<RoleDto, Role>()
                .ForMember(x => x.Users, opt => opt.Ignore());

            Mapper.CreateMap<Department, DepartmentDto>();
            Mapper.CreateMap<DepartmentDto, Department>();

            Mapper.CreateMap<Team, TeamDto>();
            Mapper.CreateMap<TeamDto, Team>()
                .ForMember(x => x.Projects, opt => opt.Ignore())
                .ForMember(x => x.UserTeamPositions, opt => opt.Ignore());

            Mapper.CreateMap<Position, PositionDto>();
            Mapper.CreateMap<PositionDto, Position>()
                .ForMember(x => x.UserTeamPositions, opt => opt.Ignore());

            Mapper.CreateMap<UserTeamPosition, UserTeamPositionDto>();
            Mapper.CreateMap<UserTeamPositionDto, UserTeamPosition>()
                .ForMember(x => x.Team, opt => opt.Ignore())
                .ForMember(x => x.User, opt => opt.Ignore())
                .ForMember(x => x.Position, opt => opt.Ignore());

            Mapper.CreateMap<Project, ProjectDto>();
            Mapper.CreateMap<ProjectDto, Project>()
                .ForMember(x => x.StateProject, opt => opt.Ignore())
                .ForMember(x => x.Team, opt => opt.Ignore());

            Mapper.CreateMap<StateProject, StateProjectDto>();
            Mapper.CreateMap<StateProjectDto, StateProject>()
                .ForMember(x => x.Projects, opt => opt.Ignore());

        }
    }
}
