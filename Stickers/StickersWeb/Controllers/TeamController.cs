using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contracts.IManager;
using DataLayer.Entities;
using DTO.Entities;
using StickersWeb.Models;
using StickersWeb.Models.Team;

namespace StickersWeb.Controllers
{
    public class TeamController : BaseController
    {
        private readonly IManagerUser _userManager;
        private readonly IManagerTeam _teamManager;
        private readonly IManagerUserTeamPos _userTeamPosManager;

        public TeamController(IManagerUser userManager, IManagerTeam teamManager, IManagerUserTeamPos userTeamPosManager)
        {
            _userManager = userManager;
            _teamManager = teamManager;
            _userTeamPosManager = userTeamPosManager;
        }

        public ActionResult Index()
        {

            var users = _userManager.GetAllUsers();
            var teams = _teamManager.GetAllTeams();
            var userTeamPositions = _userTeamPosManager.GetAllUserTeamPos();

            //User user = users.First();
            //Team team = teams.First();
            //UserTeamPosition userTeamPosition = new UserTeamPosition() {TeamId = team.Id, UserId = user.Id};
            //_userTeamPosRepo.AddUserTeamPos(userTeamPosition);
            TeamModel model = new TeamModel() { Users = users, Teams = teams, UserTeamPositions = userTeamPositions };

            return View(model);
        }

        //public ActionResult GetUsers()
        //{
        //    var users = _userManager.GetUsersByEmail("Admin@email.domain");
        //    TeamModel model = new TeamModel() { Users = users };
        //    return PartialView("~/Views/Team/_ListUsersPartial.cshtml", model);
        //}

        public ActionResult GetUserTeamPostions(string id)
        {

            var userTeamPositions = _userTeamPosManager.GetAllUserTeamPos().Where(x => x.Team.Id == new Guid(id));
            TeamModel model = new TeamModel() { UserTeamPositions = userTeamPositions };
            return PartialView("~/Views/Team/_ListUsersTeamPosPartial.cshtml", model);
        }

        public ActionResult GetTeams()
        {
            var teams = _teamManager.GetAllTeams();
            TeamModel model = new TeamModel() { Teams = teams };
            return PartialView("~/Views/Team/_ListTeamsPartial.cshtml", model);
        }

        public ActionResult AddUserToTeam(string userId, string teamId)
        {
            OperationStatus operationStatus = new OperationStatus();
            var userTeamPosition = _userTeamPosManager.GetAllUserTeamPos().ToList()
                .Find(x => x.Team.Id == new Guid(teamId) && x.User.Id == userId);
            if (userTeamPosition == null)
            {
                userTeamPosition = new UserTeamPositionDto() { UserId = userId, TeamId = new Guid(teamId) };
                _userTeamPosManager.AddUserTeamPos(userTeamPosition);
                operationStatus.Status = true;
                if (userTeamPosition.TeamId != null) operationStatus.InsertedId = (Guid) userTeamPosition.TeamId;
            }
            return Json(operationStatus, JsonRequestBehavior.AllowGet);

        }

        public ActionResult AutocompleteTeamSearch(string term)
        {
            var model = _teamManager.GetAllTeams().Where(x => x.Name.Contains(term))
                .Select(x => new {value = x.Name})
                .Distinct();
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SearchTeams(string term)
        {
            var teams = _teamManager.GetAllTeams().Where(a => a.Name.Contains(term));
            TeamModel model = new TeamModel() { Teams = teams };
            return PartialView("~/Views/Team/_ListTeamsPartial.cshtml", model);
        }


        public ActionResult AutocompleteUserSearch(string term)
        {
            var model = _userManager.GetAllUsers().Where(x => x.Email.Contains(term))
                .Select(x => new { value = x.Email })
                .Distinct();
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SearchUsers(string term)
        {
            var users = _userManager.GetAllUsers().Where(a => a.Email.Contains(term));
            TeamModel model = new TeamModel() { Users = users };
            return PartialView("~/Views/Team/_ListUsersPartial.cshtml", model);
        }

    }
}