using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoutDataModelPortable.Web
{

        public delegate ResolveConflictOption ResolveConflictDelegate<Z>(Z clientitem, Z serveritem);


        public enum ResolveConflictOption
        {
            FavourClient,
            FavourServer
        }

}
