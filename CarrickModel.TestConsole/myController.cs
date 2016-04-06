using Scout.BusinessLogic.BusinessLogic;
using Scout.BusinessLogic.Interfaces;
using ScoutDataModelPortable.DataProviders;
using ScoutDataModelPortable.Model;
using System;


namespace ScoutModel.TestConsole
{
    public class DotNetController : BusinessLogic
        {
        ModelDataProvider mc;

        public DotNetController(string baseurl, string username, string password) : base()
        {
            mc = new ModelDataProvider(baseurl, username, password);

            base.DataProviders = mc;

        }

        public void Execute()
        {
            mc.CreateModel(new SQLite.Net.Platform.Generic.SQLitePlatformGeneric());
            mc.LoadLocalData();

            mc.Sync();

        }
        public void loadtestdata1()
        {
            IScoutingRole sr = ScoutingRoleBL.GetItem(12);

            if (sr != null)
            {
                sr.Description = "Group Leader";
                ScoutingRoleBL.ModifyItem(sr);
            }

            IScoutingRole sr2 = ScoutingRoleBL.Factory();
            sr2.Description = "Tester2";
            ScoutingRoleBL.InsertItem(sr2);
        }

        public void loadtestdata()
        {

            ScoutingRole sr = new ScoutingRole();
            sr.Description = "Test1";

            //_controller.ScoutingRoleController.InsertItem(sr);

            IPerson james = PersonBL.Factory();
            james.PreferredName = "James";
            james.Surname = "Noonan";
            PersonBL.InsertItem(james);

            IPerson newPerson = PersonBL.Factory();
            newPerson.PreferredName = "Logan";
            PersonBL.InsertItem(newPerson);



            //if (_conn.Table<Adult>().Count() == 0)
            //{
            // only insert the data if it doesn't already exist
            //Adult chris = new Adult
            //{
            //    PreferredName = "Chris",
            //    Surname = "Noonan"
            //};
            //AdultController.InsertItem(chris);

            //var newPerson = new Adult
            //{
            //    PreferredName = "Meaghan",
            //    Surname = "Noonan"
            //};
            //AdultController.InsertItem(newPerson);
            ////}

            //if ((james != null) && (chris != null))
            //{
            //    YouthMemberAdultController.Link(chris, james);

            //}
        }

        public void readdata()
        {
            Console.WriteLine("Scouting Role");
            foreach (IScoutingRole s in ScoutingRoleBL.GetItems())
            {
                Console.WriteLine(s.LocalId + " " + s.Description);
            }

            Console.WriteLine("People");
            foreach (IPerson s in PersonBL.GetItems())
            {
                Console.WriteLine(s.PreferredName + ' ' + s.Surname );
                Console.WriteLine(s.Email);
            }
            Console.WriteLine("");

            //Console.WriteLine("Adults");
            //foreach (Adult s in model.Adults.Values)
            //{
            //    Console.WriteLine(s.LocalId + " " + s.PreferredName);
            //    foreach (var p in s.YouthMemberAdults)
            //    {
            //        Console.Write("-->");
            //        Console.WriteLine(p.GetYouthMember(model).ToString());
            //    }
            //}
        }
    }
}
