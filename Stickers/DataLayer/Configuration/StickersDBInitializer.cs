using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace DataLayer
{
   // class StickersDBInitializer : DropCreateDatabaseAlways<StickersContext> // раскоментировать если необходимо дропнуть БД
    class StickersDBInitializer : CreateDatabaseIfNotExists<StickersContext> // закоментировать, если необходимо дропнуть БД
    {
        protected override void Seed(StickersContext context)
        {
            // ToDo: TVV: необходимо установить хеш пароль для пользователя, 
            // подумать на счет того, как БД наполнять данными, может строковые переменные через файл ресурсов
            // возможно через xml файл с первичными данными (предпочтительно имхо)

            User adminUser = new User
            {
                Id = "1",
                UserName = "Admin",
                // password equals admin
                PasswordHash = "JaS3MecSfP8f23L0DfTeuBV+AvtCpVcC8ybqb9XVjME=",
                Firstname = "",
                LastName = "",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnabled = false,
                Email = "Admin@email.domain"
            };
            User pmUser = new User
            {
                Id = "2",
                UserName = "PM",
                // password equals admin
                PasswordHash = "JaS3MecSfP8f23L0DfTeuBV+AvtCpVcC8ybqb9XVjME=",
                Firstname = "",
                LastName = "",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnabled = false,
                Email = "pm@email.domain"
            };
            User devUser = new User
            {
                Id = "3",
                UserName = "Developer",
                // password equals admin
                PasswordHash = "JaS3MecSfP8f23L0DfTeuBV+AvtCpVcC8ybqb9XVjME=",
                Firstname = "",
                LastName = "",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnabled = false,
                Email = "developer@email.domain"
            };
            User qaUser = new User
            {
                Id = "21211",
                UserName = "QA",
                // password equals admin
                PasswordHash = "JaS3MecSfP8f23L0DfTeuBV+AvtCpVcC8ybqb9XVjME=",
                Firstname = "",
                LastName = "",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnabled = false,
                Email = "qa@email.domain"
            };

            
            context.Users.Add(adminUser);
            context.Users.Add(pmUser);
            context.Users.Add(devUser);
            context.Users.Add(qaUser);


            context.Positions.Add(new Position
            {
                Id = Guid.NewGuid(),
                Name = "Project Manager",
                Description = "Группа пользователей с привилегиями менеджера.",
            });

            context.Positions.Add(new Position
            {
                Id = Guid.NewGuid(),
                Name = "Product Owner",
                Description = "Пользователь с привилегиями Product Owner",
            });

            context.Positions.Add(new Position
            {
                Id = Guid.NewGuid(),
                Name = "Developer",
                Description = "Группа пользователей с привилегиями Product Developer",
            });

            context.Positions.Add(new Position
            {
                Id = Guid.NewGuid(),
                Name = "Quality Assurance",
                Description = "Группа пользователей с привилегиями тестировщика",
            });

            StateProject archiveStateProject = new StateProject
            {
                Id = Guid.NewGuid(),
                Name = "Archive",
                Description = "Description about Archive state"

            };

            StateProject openStateProject = new StateProject
            {
                Id = Guid.NewGuid(),
                Name = "Open",
                Description = "Description about Open state"
            };

            //context.StateProjects.Add(archiveStateProject);
            //context.StateProjects.Add(openStateProject);

            context.Teams.Add(new Team()
            {
                Id = Guid.NewGuid(),
                Name = "M1T1",
                Description = "Description",
            });

            context.Teams.Add(new Team()
            {
                Id = Guid.NewGuid(),
                Name = "M1T2",
                Description = "Description",
            });

            context.Teams.Add(new Team()
            {
                Id = Guid.NewGuid(),
                Name = "M1T3",
                Description = "Description",
            });

            context.Teams.Add(new Team()
            {
                Id = Guid.NewGuid(),
                Name = "M1T4",
                Description = "Description",
            });
            context.Teams.Add(new Team()
            {
                Id = Guid.NewGuid(),
                Name = "M2T1",
                Description = "Description",
            });
            context.Teams.Add(new Team()
            {
                Id = Guid.NewGuid(),
                Name = "M2T2",
                Description = "Description",
            });
            context.Teams.Add(new Team()
            {
                Id = Guid.NewGuid(),
                Name = "M2T3",
                Description = "Description",
            });
            context.Teams.Add(new Team()
            {
                Id = Guid.NewGuid(),
                Name = "J1T1",
                Description = "Description",
            });
            context.Projects.Add(new Project
            {
                Id = Guid.NewGuid(),
                Name = "LogViewer",
                Description = "This is LogViewer description",
                DateCreate = DateTime.Now,
                Code = "LG",
                StateProject = archiveStateProject
            });

            context.Projects.Add(new Project
            {
                Id = Guid.NewGuid(),
                Name = "BugTracker",
                Description = "This is BugTracker description",
                StateProject = openStateProject,
                DateCreate = DateTime.Now,
                Code = "BT"
            });


            base.Seed(context);
        }
    }
}
