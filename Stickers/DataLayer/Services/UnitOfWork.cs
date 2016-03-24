using Contracts;
using DataLayer.Entities;
using DataLayer.Repositories;
using DTO.Entities;

namespace DataLayer.Services
{
    public class UnitOfWork 
    {
        static UnitOfWork()
        {
          MapperConfig.RegisterMappings();  
        }

        private static IRepository<User, UserDto> _usersRepo;
        private static IRepository<Role, RoleDto> _rolesRepo;
        private static IRepository<Department, DepartmentDto> _departmentsRepo;
        private static IRepository<Position, PositionDto> _positionsRepo;
        private static IRepository<Team, TeamDto> _teamsRepo;
        private static IRepository<UserTeamPosition, UserTeamPositionDto> _userTeamPosRepo;
        private static IRepository<Project, ProjectDto> _projectsRepo;
        private static IRepository<StateProject, StateProjectDto> _stateProjectsRepo;


        public IRepository<User, UserDto> Users => _usersRepo ?? (_usersRepo = new Repository<User, UserDto>());
        public IRepository<Role, RoleDto> Roles => _rolesRepo ?? (_rolesRepo = new Repository<Role, RoleDto>());
        public IRepository<Department, DepartmentDto> Departments => _departmentsRepo ?? (_departmentsRepo = new Repository<Department, DepartmentDto>());
        public IRepository<Position, PositionDto> Positions => _positionsRepo ?? (_positionsRepo = new Repository<Position, PositionDto>());
        public IRepository<Team, TeamDto> Teams => _teamsRepo ?? (_teamsRepo = new Repository<Team, TeamDto> ());
        public IRepository<UserTeamPosition, UserTeamPositionDto> UserTeamPositions => _userTeamPosRepo ?? (_userTeamPosRepo = new Repository<UserTeamPosition, UserTeamPositionDto>());
        public IRepository<Project, ProjectDto> Projects => _projectsRepo ?? (_projectsRepo = new Repository<Project, ProjectDto>());
        public IRepository<StateProject, StateProjectDto> StateProjects => _stateProjectsRepo ?? (_stateProjectsRepo = new Repository<StateProject, StateProjectDto>());
    }
}
