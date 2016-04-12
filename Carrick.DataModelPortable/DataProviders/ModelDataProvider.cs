
namespace Carrick.ClientData.DataProviders
{

    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using SQLite.Net;
    using Carrick.ClientData.Web;

    using Carrick.BusinessLogic.Interfaces;

    public class ModelDataProvider :IDataProviders
    {
        
        private SQLiteConnection _conn;

        internal HttpClient client = new HttpClient();
        private string url = "";

        private Dictionary<Type, IClientDataProvider> _DataProviders = new Dictionary<Type, IClientDataProvider>();


        public ModelDataProvider(String url, string username, string password)
        {
            this.url = url;
            client.BaseAddress = new Uri(this.url);

           // WebAPIRegisterHelper w = new WebAPIRegisterHelper(client,url);
           // w.Register();

            WebAPITokenHelper t = new WebAPITokenHelper(client, url);
            t.LoadLoginToken(username, password);

            this.client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", t.Token);

            AddDataProvider(new BadgeDataProvider(this));
            AddDataProvider(new EventLocationDataProvider(this));
            AddDataProvider(new LocationDataProvider(this));
            AddDataProvider(new OrganisationUnitDataProvider(this));
            AddDataProvider(new PersonBadgeDataProvider(this));
            AddDataProvider(new PersonDataProvider(this));
            AddDataProvider(new PersonOrganisationUnitDataProvider(this));
            AddDataProvider(new PersonPersonDataProvider(this));
            AddDataProvider(new PersonResidenceDataProvider(this));
            AddDataProvider(new PersonScoutingEventDataProvider(this));
            AddDataProvider(new PersonScoutingRoleDataProvider(this));
            AddDataProvider(new PersonSignInDataProvider(this));
            AddDataProvider(new ResidenceDataProvider(this));
            AddDataProvider(new ScoutingEventDataProvider(this));
            AddDataProvider(new ScoutingRoleDataProvider(this));
            
        }

        private void AddDataProvider(IClientDataProvider obj)
        {
            _DataProviders.Add(obj.GetDataType(), obj);
        }


        public Object GetProvider(Type t)
        {
            IClientDataProvider retval;
            _DataProviders.TryGetValue(t, out retval);
            return retval;
        }

        internal SQLiteConnection GetLocalConnection()
        {
            return _conn;
        }


        public void CreateModel(SQLite.Net.Interop.ISQLitePlatform platform)
        {
            //Creating database, if it doesn't already exist
            string dbPath = ("c:\\temp\\test.db3");

            _conn = new SQLiteConnection(platform, dbPath);

            foreach (IClientDataProvider c in _DataProviders.Values)
            {
                c.Initialise();
                c.LoadLocalData();
            }
        }

        public void LoadLocalData()
        {
            foreach (IClientDataProvider c in _DataProviders.Values)
            {
                c.LoadLocalData();
            }
        }

        public void Sync()
        {
            foreach (IClientDataProvider c in _DataProviders.Values)
            {
                try
                {
                    Debug.WriteLine("Syncing "  + c.GetType().ToString() );
                    c.Sync();
                    Debug.WriteLine(c.GetType().ToString() + " Sync Successfull");
                }
                
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
                    
            }
        }

    }
}
