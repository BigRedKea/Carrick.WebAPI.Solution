using Carrick.BusinessLogic;
using Carrick.BusinessLogic.Interfaces;
using Carrick.ClientData.DataProviders;

using System;


namespace ScoutModel.TestConsole
{
    public class DotNetController : BusinessLogic
        {
        ModelDataProvider mc;

        public DotNetController(string baseurl, string username, string password) : base()
        {
            mc = new ModelDataProvider(new SQLite.Net.Platform.Generic.SQLitePlatformGeneric(),baseurl, username, password);

            base.DataProviders = mc;

        }

        public void Execute()
        {
            mc.CreateModel();
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

            IScoutingRole sr2 = ScoutingRoleBL.CreateItem();
            sr2.Description = "Tester2";
            ScoutingRoleBL.InsertItem(sr2);
        }

        public void loadtestdata()
        {

            IScoutingRole sr = ScoutingRoleBL.CreateItem();
            sr.Description = "Test1";

            //_controller.ScoutingRoleController.InsertItem(sr);

            IPerson james = PersonBL.CreateItem();
            james.PreferredName = "James";
            james.Surname = "Noonan";
            PersonBL.InsertItem(james);

            IPerson newPerson = PersonBL.CreateItem();
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
            foreach (IScoutingRole s in ScoutingRoleBL.GetAllItems())
            {
                Console.WriteLine(s.Id + " " + s.Description);
            }

            Console.WriteLine("People");
            foreach (IPerson s in PersonBL.GetAllItems())
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
