﻿namespace eVoting.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Security;
    using eVoting.DAL;
    using Model;
    //using System.Web.Security;
    //using System.Web.Security;
    using WebMatrix.WebData;
    using System.Collections.Generic;

    public class eVConfiguration : DbMigrationsConfiguration<eVoting.DAL.evContext>
    {
        public eVConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }


        protected override void Seed(evContext context)
        {

            //  if (!WebSecurity.Initialized)
            //   WebSecurity.InitializeDatabaseConnection("evotingDatabase", "UserProfile", "UserId", "UserName", autoCreateTables: true);
            // WebSecurity.InitializeDatabaseConnection("evotingDatabase", "UserProfile", "UserId", "UserName", autoCreateTables: true);



            if (!Roles.RoleExists("SuperAdmin"))
                Roles.CreateRole("SuperAdmin");

            if (!Roles.RoleExists("Admin"))
                Roles.CreateRole("Admin");

            if (!Roles.RoleExists("InterAdmin"))
                Roles.CreateRole("InterAdmin");
            UnitOfWork work = new UnitOfWork();


            //if (Membership.GetUser("chair") != null)
            //{
            //    Membership.DeleteUser("chair", true);
            //    //  Membership.CreateUser("chair", "P@ssw0rd");
            //    List<Voter> theVoter = work.VoterRepository.Get(a => a.FirstName == "chair").ToList();
            //    foreach (Voter v in theVoter)
            //    {
            //        //  Voter theVoter = new Voter() { Department = "", FirstName = "chair", IdentityNumber = "chair", Voted = false, VotedTime = DateTime.Now, LoggedInAttemptsAfterVoting = 0, LastName = "", Password = "P@ssw0rd" };
            //        work.VoterRepository.Delete(v);
            //    }
            //    work.Save();
            //}

            if (Membership.GetUser("chair") == null)
            {

                Membership.CreateUser("chair", "scandalla");
                Voter theVoter = new Voter() { Department = "", FirstName = "chair", IdentityNumber = "chair", Voted = false, VotedTime = DateTime.Now, LoggedInAttemptsAfterVoting = 0, LastName = "", Password = "scandalla" };
                work.VoterRepository.Insert(theVoter);
                work.Save();
            }


            //  Roles.AddUserToRole("kayode", "SuperAdmin");

            //if (!WebSecurity.UserExists("chair"))
            //    WebSecurity.CreateUserAndAccount(
            //        "chair",
            //        "P@ssw0rd");


            //if (Membership.GetUser("kazeem") != null)
            //{
            //    Membership.DeleteUser("kazeem", true);
            //    //  Membership.CreateUser("chair", "P@ssw0rd");
            //    //  Voter theVoter = work.VoterRepository.Get(a => a.FirstName == "kazeem").First();
            //    //  Voter theVoter = new Voter() { Department = "", FirstName = "chair", IdentityNumber = "chair", Voted = false, VotedTime = DateTime.Now, LoggedInAttemptsAfterVoting = 0, LastName = "", Password = "P@ssw0rd" };
            //    List<Voter> theVoter = work.VoterRepository.Get(a => a.FirstName == "kazeem").ToList();
            //    foreach (Voter v in theVoter)
            //    {
            //        //  Voter theVoter = new Voter() { Department = "", FirstName = "chair", IdentityNumber = "chair", Voted = false, VotedTime = DateTime.Now, LoggedInAttemptsAfterVoting = 0, LastName = "", Password = "P@ssw0rd" };
            //        work.VoterRepository.Delete(v);
            //    }
            //    work.Save();

            //    //  work.VoterRepository.Insert(theVoter);
            //    // work.Save();
            //}

            if (Membership.GetUser("kazeem") == null)
            {
                // UnitOfWork work = new UnitOfWork();
                Membership.CreateUser("kazeem", "kazeemA1");
                Voter theVoter = new Voter() { Department = "", FirstName = "kazeem", IdentityNumber = "kazeem", Voted = false, VotedTime = DateTime.Now, LoggedInAttemptsAfterVoting = 0, LastName = "Oyebode1234567", Password = "kazeemA1" };

                work.VoterRepository.Insert(theVoter);
                work.Save();


            }


            if (Membership.GetUser("password") == null)
            {
                // UnitOfWork work = new UnitOfWork();
                Membership.CreateUser("password", "P@ssw0rd");
                Voter theVoter = new Voter() { Department = "", FirstName = "password", IdentityNumber = "password", Voted = false, VotedTime = DateTime.Now, LoggedInAttemptsAfterVoting = 0, LastName = "", Password = "P@ssw0rd" };
                work.VoterRepository.Insert(theVoter);
                work.Save();
            }

            if (!Roles.GetRolesForUser("kazeem").Contains("SuperAdmin"))
                Roles.AddUsersToRoles(new[] { "kazeem" }, new[] { "SuperAdmin" });

            if (!Roles.GetRolesForUser("chair").Contains("InterAdmin"))
                Roles.AddUsersToRoles(new[] { "chair" }, new[] { "InterAdmin" });

            if (!Roles.GetRolesForUser("password").Contains("Admin"))
                Roles.AddUsersToRoles(new[] { "password" }, new[] { "Admin" });

            // UnitOfWork work = new UnitOfWork();

            //List<Voter> akin = work.VoterRepository.Get(a => a.IdentityNumber == "chair").ToList();
            //if (akin.Count() == 0)
            //{

            //}

            //List<Voter> pass = work.VoterRepository.Get(a => a.IdentityNumber == "password").ToList();
            //if (pass.Count() == 0)
            //{

            //}
            //List<Voter> kazee = work.VoterRepository.Get(a => a.IdentityNumber == "kazeem").ToList();
            //if (kazee.Count() == 0)
            //{

            //}



            //  }


        }
    }

}
