
namespace Carrick.Data.Controllers
{
    using Carrick.Data;
    using Model;
    using System;

    public class Repository
    {
        //public static Repository Singleton = new Repository();
        internal CarrickEntityDataModel DataModel;

        private BadgeDataController _BadgeDataController;
        private PersonBadgeDataController _PersonBadgeDataController;
        private EventLocationDataController _EventLocationDataController;
        private LocationDataController _LocationDataController;
        private OrganisationUnitDataController _OrganisationUnitDataController;
        private PersonScoutingEventDataController _PersonAtEventDataController;
        private PersonDataController _PersonDataController;
        private PersonSignInDataController _PersonSignInDataController;
        private PersonOrganisationUnitDataController _PersonOrganisationUnitDataController;
        private PersonPersonDataController _PersonPersonDataController;
        private PersonResidenceDataController _PersonResidenceDataController;
        private PersonScoutingRoleDataController _PersonScoutingRoleDataController;
        private ResidenceDataController _ResidenceDataController;
        private ScoutingRoleDataController _ScoutingRoleDataController;
        private ScoutingEventDataController _ScoutingEventDataController;

        public BadgeDataController BadgeDataController
        {
            get
            {
                if (_BadgeDataController == null)
                {
                    _BadgeDataController = new BadgeDataController(this);
                }
                return _BadgeDataController;
            }
        }

        public PersonBadgeDataController PersonBadgeDataController
        {
            get
            {
                if (_PersonBadgeDataController == null)
                {
                    _PersonBadgeDataController = new PersonBadgeDataController(this);
                }
                return _PersonBadgeDataController;
            }
        }

        public EventLocationDataController EventLocationDataController
        {
            get
            {
                if (_EventLocationDataController == null)
                {
                    _EventLocationDataController = new EventLocationDataController(this);
                }
                return _EventLocationDataController;
            }
        }

        public LocationDataController LocationDataController
        {
            get
            {
                if (_LocationDataController == null)
                {
                    _LocationDataController = new LocationDataController(this);
                }
                return _LocationDataController;
            }
        }

        public OrganisationUnitDataController OrganisationUnitDataController
        {
            get
            {
                if (_OrganisationUnitDataController == null)
                {
                    _OrganisationUnitDataController = new OrganisationUnitDataController(this);
                }
                return _OrganisationUnitDataController;
            }
        }
        
        public PersonScoutingEventDataController PersonScoutingEventDataController
        {
            get
            {
                if (_PersonAtEventDataController == null)
                {
                    _PersonAtEventDataController = new PersonScoutingEventDataController(this);
                }
                return _PersonAtEventDataController;
            }
        }

        public PersonDataController PersonDataController
        {
            get
            {
                if (_PersonDataController == null)
                {
                    _PersonDataController = new PersonDataController(this);
                }
                return _PersonDataController;
            }
        }

        public PersonSignInDataController PersonSignInDataController
        {
            get
            {
                if (_PersonSignInDataController == null)
                {
                    _PersonSignInDataController = new PersonSignInDataController(this);
                }
                return _PersonSignInDataController;
            }
        }

        public PersonOrganisationUnitDataController PersonOrganisationUnitDataController
        {
            get
            {
                if (_PersonOrganisationUnitDataController == null)
                {
                    _PersonOrganisationUnitDataController = new PersonOrganisationUnitDataController(this);
                }
                return _PersonOrganisationUnitDataController;
            }
        }

        public PersonPersonDataController PersonPersonDataController
        {
            get
            {
                if (_PersonPersonDataController == null)
                {
                    _PersonPersonDataController = new PersonPersonDataController(this);
                }
                return _PersonPersonDataController;
            }
        }

        public PersonResidenceDataController PersonResidenceDataController
        {
            get
            {
                if (_PersonResidenceDataController == null)
                {
                    _PersonResidenceDataController = new PersonResidenceDataController(this);
                }
                return _PersonResidenceDataController;
            }
        }

        public PersonScoutingRoleDataController PersonScoutingRoleDataController
        {
            get
            {
                if (_PersonScoutingRoleDataController == null)
                {
                    _PersonScoutingRoleDataController = new PersonScoutingRoleDataController(this);
                }
                return _PersonScoutingRoleDataController;
            }
        }

        public ResidenceDataController ResidenceDataController
        {
            get
            {
                if (_ResidenceDataController == null)
                {
                    _ResidenceDataController = new ResidenceDataController(this);
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

        public ScoutingEventDataController ScoutingEventDataController
        {
            get
            {
                if (_ScoutingEventDataController == null)
                {
                    _ScoutingEventDataController = new ScoutingEventDataController(this);
                }
                return _ScoutingEventDataController;
            }
        }

        public Person PersonRequestingAccess;

        public Repository()
        {
            DataModel = new CarrickEntityDataModel();
        }
    }
}

