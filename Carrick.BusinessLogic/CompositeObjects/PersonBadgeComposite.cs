
using Carrick.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Carrick.BusinessLogic.CompositeObjects
{
    public class PersonBadgeComposite
    {
        public IPerson Person { get; set; }
        public IBadge Badge { get; set; }
        public IPersonBadge PersonBadge { get; set; }

        public int Id { get; set; }

        public String PersonBadgeState {
            get
            {
                if (PersonBadge.RowDeleted.HasValue)
                { return "Deleted"; }
                else if (PersonBadge.PresentedTimeStamp.HasValue)
                { return "Presented"; }
                else if (PersonBadge.AuthorisedByGuid.HasValue)
                { return "Authorised to Present"; }
                else if (PersonBadge.LeaderAssignedGuid.HasValue)
                { return "Leader Assigned"; }
                else
                { return "Not Assigned"; }
            }
        }
    }
}
