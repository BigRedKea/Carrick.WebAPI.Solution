
namespace Carrick.Data.Controllers
{
    using Carrick.Data;
    using Carrick.DataModel;
    using Scout.BusinessLogic.Interfaces;
    using System;

    public class Repository : IDataProviders
    {
        //public static Repository Singleton = new Repository();
        internal CarrickEntityDataModel DataModel;

        private BadgeDataProvider _BadgeDataController;
        private PersonBadgeDataProvider _PersonBadgeDataController;
        private EventLocationDataProvider _EventLocationDataController;
        private LocationDataProvider _LocationDataController;
        private OrganisationUnitDataProvider _OrganisationUnitDataController;
        private PersonScoutingEventDataProvider _PersonAtEventDataController;
        private PersonDataProvider _PersonDataController;
        private PersonSignInDataProvider _PersonSignInDataController;
        private PersonOrganisationUnitDataProvider _PersonOrganisationUnitDataController;
        private PersonPersonDataProvider _PersonPersonDataController;
        private PersonResidenceDataProvider _PersonResidenceDataController;
        private PersonScoutingRoleDataProvider _PersonScoutingRoleDataController;
        private ResidenceDataProvider _ResidenceDataController;
        private ScoutingRoleDataController _ScoutingRoleDataController;
        private ScoutingEventDataProvider _ScoutingEventDataController;

        public BadgeDataProvider BadgeDataController
        {
            get
            {
                if (_BadgeDataController == null)
                {
                    _BadgeDataController = new BadgeDataProvider(this);
                }
                return _BadgeDataController;
            }
        }

        public PersonBadgeDataProvider PersonBadgeDataController
        {
            get
            {
                if (_PersonBadgeDataController == null)
                {
                    _PersonBadgeDataController = new PersonBadgeDataProvider(this);
                }
                return _PersonBadgeDataController;
            }
        }

        public EventLocationDataProvider EventLocationDataController
        {
            get
            {
                if (_EventLocationDataController == null)
                {
                    _EventLocationDataController = new EventLocationDataProvider(this);
                }
                return _EventLocationDataController;
            }
        }

        public LocationDataProvider LocationDataController
        {
            get
            {
                if (_LocationDataController == null)
                {
                    _LocationDataController = new LocationDataProvider(this);
                }
                return _LocationDataController;
            }
        }

        public OrganisationUnitDataProvider OrganisationUnitDataController
        {
            get
            {
                if (_OrganisationUnitDataController == null)
                {
                    _OrganisationUnitDataController = new OrganisationUnitDataProvider(this);
                }
                return _OrganisationUnitDataController;
            }
        }
        
        public PersonScoutingEventDataProvider PersonScoutingEventDataController
        {
            get
            {
                if (_PersonAtEventDataController == null)
                {
                    _PersonAtEventDataController = new PersonScoutingEventDataProvider(this);
                }
                return _PersonAtEventDataController;
            }
        }

        public PersonDataProvider PersonDataController
        {
            get
            {
                if (_PersonDataController == null)
                {
                    _PersonDataController = new PersonDataProvider(this);
                }
                return _PersonDataController;
            }
        }

        public PersonSignInDataProvider PersonSignInDataController
        {
            get
            {
                if (_PersonSignInDataController == null)
                {
                    _PersonSignInDataController = new PersonSignInDataProvider(this);
                }
                return _PersonSignInDataController;
            }
        }

        public PersonOrganisationUnitDataProvider PersonOrganisationUnitDataController
        {
            get
            {
                if (_PersonOrganisationUnitDataController == null)
                {
                    _PersonOrganisationUnitDataController = new PersonOrganisationUnitDataProvider(this);
                }
                return _PersonOrganisationUnitDataController;
            }
        }

        public PersonPersonDataProvider PersonPersonDataController
        {
            get
            {
                if (_PersonPersonDataController == null)
                {
                    _PersonPersonDataController = new PersonPersonDataProvider(this);
                }
                return _PersonPersonDataController;
            }
        }

        public PersonResidenceDataProvider PersonResidenceDataController
        {
            get
            {
                if (_PersonResidenceDataController == null)
                {
                    _PersonResidenceDataController = new PersonResidenceDataProvider(this);
                }
                return _PersonResidenceDataController;
            }
        }

        public PersonScoutingRoleDataProvider PersonScoutingRoleDataController
        {
            get
            {
                if (_PersonScoutingRoleDataController == null)
                {
                    _PersonScoutingRoleDataController = new PersonScoutingRoleDataProvider(this);
                }
                return _PersonScoutingRoleDataController;
            }
        }

        public ResidenceDataProvider ResidenceDataController
        {
            get
            {
                if (_ResidenceDataController == null)
                {
                    _ResidenceDataController = new ResidenceDataProvider(this);
                }
                return _ResidenceDataController;
            }
        }

        public ScoutingRoleDataController ScoutingRoleDataController
        {
            get
            {
                if (_ScoutingRoleDataController == null)
                {
                    _ScoutingRoleDataController = new ScoutingRoleDataController(this);
                }
                return _ScoutingRoleDataController;
            }
        }

        public ScoutingEventDataProvider ScoutingEventDataController
        {
            get
            {
                if (_ScoutingEventDataController == null)
                {
                    _ScoutingEventDataController = new ScoutingEventDataProvider(this);
                }
                return _ScoutingEventDataController;
            }
        }

        public Person PersonRequestingAccess;

        public Repository()
        {
            DataModel = new CarrickEntityDataModel();
        }

        public object GetProvider(Type t)
        {
            throw new NotImplementedException();
        }
    }
}

