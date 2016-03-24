using System;
using System.Collections.Generic;
using DTO.Entities;

namespace Contracts.IManager
{
    public interface IManagerProject
    {
        IEnumerable<ProjectDto> GetAllProjects();
        //IEnumerable<ProjectDto> GetAllProjects(TakeSkipValue listProject);
        void AddProject(ProjectDto project);
        void AddStateProject(StateProjectDto stateProject);
        void UpdateProject(ProjectDto project);
        void RemoveProject(ProjectDto project);
        IEnumerable<StateProjectDto> GetStateProjectByName(String name);
        IEnumerable<ProjectDto> GetProjectByName(String name);
    }
}