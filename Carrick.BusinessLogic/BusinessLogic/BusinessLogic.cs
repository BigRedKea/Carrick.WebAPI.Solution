using Carrick.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Carrick.BusinessLogic
{
    public class BusinessLogic
    {
        public IDataProviders DataProviders;

        public BusinessLogic()
        {
        }

        //Badge
        private BadgeBusinessLogic _BadgeBL ;
        public BadgeBusinessLogic BadgeBL
        { get
            {
                if (_BadgeBL == null)
                {
                    _BadgeBL = new BadgeBusinessLogic(this);
                }
                return _BadgeBL;
            }
        }


        
        private EventLocationBusinessLogic _EventLocationBL;
        public EventLocationBusinessLogic EventLocationBL
        {
            get
            {
                if (_EventLocationBL == null)
                {
                    _EventLocationBL = new EventLocationBusinessLogic(this);
                }
                return _EventLocationBL;
            }
        }

        
        private LocationBusinessLogic _LocationBL;
        public LocationBusinessLogic LocationBL
        {
            get
            {
                if (_LocationBL == null)
                {
                    _LocationBL = new LocationBusinessLogic(this);
                }
                return _LocationBL;
            }
        }

        
        private PersonBadgeBusinessLogic _PersonBadgeBL;
        public PersonBadgeBusinessLogic PersonBadgeBL
        {
            get
            {
                if (_PersonBadgeBL == null)
                {
                    _PersonBadgeBL = new PersonBadgeBusinessLogic(this);
                }
                return _PersonBadgeBL;
            }
        }

        //OrganisationUnit
        private OrganisationUnitBusinessLogic _OrganisationUnitBL;
        public OrganisationUnitBusinessLogic OrganisationUnitBL
        {
            get
            {
                if (_OrganisationUnitBL == null)
                {
                    _OrganisationUnitBL = new OrganisationUnitBusinessLogic(this);
                }
                return _OrganisationUnitBL;
            }
        }

        //Person
        private PersonBusinessLogic _PersonBL;
        public PersonBusinessLogic PersonBL
        {
            get
            {
                if (_PersonBL == null)
                {
                    _PersonBL = new PersonBusinessLogic(this);
                }
                return _PersonBL;
            }
        }

        //PersonOrganisationUnit
        private PersonOrganisationUnitBusinessLogic _PersonOrganisationUnitBL;
        public PersonOrganisationUnitBusinessLogic PersonOrganisationUnitBL
        {
            get
            {
                if (_PersonOrganisationUnitBL == null)
                {
                    _PersonOrganisationUnitBL = new PersonOrganisationUnitBusinessLogic(this);
                }
                return _PersonOrganisationUnitBL;
            }
        }

        //PersonPerson
        private PersonPersonBusinessLogic _PersonPersonBL;
        public PersonPersonBusinessLogic PersonPersonBL
        {
            get
            {
                if (_PersonPersonBL == null)
                {
                    _PersonPersonBL = new PersonPersonBusinessLogic(this);
                }
                return _PersonPersonBL;
            }
        }

        //PersonResidence
        private PersonResidenceBusinessLogic _PersonResidenceBL;
        public PersonResidenceBusinessLogic PersonResidenceBL
        {
            get
            {
                if (_PersonResidenceBL == null)
                {
                    _PersonResidenceBL = new PersonResidenceBusinessLogic(this);
                }
                return _PersonResidenceBL;
            }
        }

        //PersonScoutingEvent
        private PersonScoutingEventBusinessLogic _PersonScoutingEventBL;
        public PersonScoutingEventBusinessLogic PersonScoutingEventBL
        {
            get
            {
                if (_PersonScoutingEventBL == null)
                {
                    _PersonScoutingEventBL = new PersonScoutingEventBusinessLogic(this);
                }
                return _PersonScoutingEventBL;
            }
        }

        //PersonSignIn
        private PersonSignInBusinessLogic _PersonSignInBL;
        public PersonSignInBusinessLogic PersonSignInBL
        {
            get
            {
                if (_PersonSignInBL == null)
                {
                    _PersonSignInBL = new PersonSignInBusinessLogic(this);
                }
                return _PersonSignInBL;
            }
        }

        //Residence
        private ResidenceBusinessLogic _ResidenceBL;
        public ResidenceBusinessLogic ResidenceBL
        {
            get
            {
                if (_ResidenceBL == null)
                {
                    _ResidenceBL = new ResidenceBusinessLogic(this);
                }
                return _ResidenceBL;
            }
        }

        //ScoutingEvent
        private ScoutingEventBusinessLogic _ScoutingEventBL;
        public ScoutingEventBusinessLogic ScoutingEventBL
        {
            get
            {
                if (_ScoutingEventBL == null)
                {
                    _ScoutingEventBL = new ScoutingEventBusinessLogic(this);
                }
                return _ScoutingEventBL;
            }
        }

        //PersonScoutingRole
        private PersonScoutingRoleBusinessLogic _PersonScoutingRoleBL;
        public PersonScoutingRoleBusinessLogic PersonScoutingRoleBL
        {
            get
            {
                if (_PersonScoutingRoleBL == null)
                {
                    _PersonScoutingRoleBL = new PersonScoutingRoleBusinessLogic(this);
                }
                return _PersonScoutingRoleBL;
            }
        }

        //ScoutingRole
        private ScoutingRoleBusinessLogic _ScoutingRoleBL;
        public ScoutingRoleBusinessLogic ScoutingRoleBL
        {
            get
            {
                if (_ScoutingRoleBL == null)
                {
                    _ScoutingRoleBL = new ScoutingRoleBusinessLogic(this);
                }
                return _ScoutingRoleBL;
            }
        }

    }
}
