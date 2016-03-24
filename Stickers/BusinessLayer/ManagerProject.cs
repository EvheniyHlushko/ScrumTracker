using System;
using System.Collections.Generic;
using System.Linq;
using Contracts.IManager;
using DTO.Entities;

namespace BusinessLayer
{
        //public struct TakeSkipValue
        //{
        //    public int CountOutput { get; set; }
        //    public int PageNumber { get; set; }

        //    public int Skip { get { return CountOutput * (PageNumber - 1); } }
        //    public int Take { get { return CountOutput; } }

        //    public string OrderBy { get; set; } // парсить нужно
        //}

    public  class ManagerProject : BaseManager, IManagerProject
    {
        public IEnumerable<ProjectDto> GetAllProjects()
        {
            return _srv.Projects.GetList().ToArray();
        }

        //public IEnumerable<ProjectDto> GetAllProjects(TakeSkipValue listProject)
        //{
        //    //return ServiceDal.Projects.GetList().Skip(listProject.Skip).Take(listProject.Take).OrderBy().ToList();
        //    return _srv.Projects.GetList().Skip(listProject.Skip).Take(listProject.Take).ToArray();
        //}

        public void AddProject(ProjectDto project)
        {
            _srv.Projects.Add(project);
        }

        public void AddStateProject(StateProjectDto stateProject)
        {
            _srv.StateProjects.Add(stateProject);
        }

        public void UpdateProject(ProjectDto project)
        {
            _srv.Projects.Update(project);
        }

        public void RemoveProject(ProjectDto project)
        {
            _srv.Projects.Remove(project);
        }

        public IEnumerable<StateProjectDto> GetStateProjectByName(String name)
        {
            var listState = _srv.StateProjects.GetWithFilter(x => x.Name == name).ToArray();
            return listState.Length > 0 ? listState : null;
        }

        public IEnumerable<ProjectDto> GetProjectByName(String name)
        {
            var listProject = _srv.Projects.GetWithFilter(x => x.Name == name).ToArray();
            return listProject.Length > 0 ? listProject : null;
        }
    }
}
