using Carrick.BusinessLogic.Interfaces;
using Carrick.DataModel;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrick.ClientData.DataProviders
{
    internal class LocalDataProvider<Z> where Z : TableBase, new()
    {
        internal ModelDataProvider modelDataProvider;

        protected Dictionary<int, Z> Items = new Dictionary<int, Z>();

        public void Initialise()
        {
            CreateTable();
        }

        protected internal void DropTable()
        {
            modelDataProvider.GetLocalConnection().DropTable<Z>();
        }

        protected internal void CreateTable()
        {
            modelDataProvider.GetLocalConnection().CreateTable<Z>();
        }

        protected internal TableQuery<Z> GetTable()
        {
            return modelDataProvider.GetLocalConnection().Table<Z>();
        }

        public void LoadLocalData()
        {
            Items.Clear();
            CreateTable(); // If it doesn't exist

            foreach (Z s in GetTable())
            {
                SQLiteNetExtensions.Extensions.ReadOperations.GetChildren(modelDataProvider.GetLocalConnection(), s);
                Items.Add(s.LocalId, s);
            }
        }

        public IEnumerable<Z> GetActiveItems()
        {
            return Items.Values.Where(x => !(x.RowDeleted.HasValue));
        }

        public IEnumerable<Z> GetAllItems()
        {
            return Items.Values;
        }

        public Z GetItem(IRelationshipKey key)
        {
            if (key.Id.HasValue)
            {
                return GetItemFromId(key.Id.Value);
            }
            else if (key.RowGuid.HasValue)
            {
                return GetItemFromGuid(key.RowGuid);
            }
            else if (key.LocalId.HasValue)
            {
                return GetItemFromLocalId(key.LocalId.Value);
            }
            else
            {
                return default(Z);
            }
        }


        protected Z GetItemFromId(int Id)
        {
            Z p = Items.Values.Where(x => x.Id == Id).FirstOrDefault();
            return p;
        }

        protected Z GetItemFromLocalId(int LocalId)
        {
            Z p = Items.Values.Where(x => x.LocalId == LocalId).FirstOrDefault();
            return p;
        }

        protected Z GetItemFromGuid(Guid? uniqueId)
        {
            if (uniqueId.HasValue)
            {
                foreach (Z s in Items.Values)
                {
                    if (s.RowGuid.ToString() == uniqueId.Value.ToString())
                    {
                        return s;
                    }
                }
            }
            return default(Z);
        }

        public Z InsertItem(Z itm)
        {
            modelDataProvider.GetLocalConnection().Insert(itm);
            Items.Add(itm.LocalId, itm);
            return itm;
        }

        public Z ModifyItem(Z itm)
        {
            itm.IsDirty = true;
            UpdateLocalItem(itm);
            return itm;
        }

        public Z DeleteItem(Z itm)
        {
            itm.RowDeleted = DateTime.UtcNow;
            itm.IsDirty = true;
            UpdateLocalItem(itm);
            return itm;
        }

        internal void UpdateLocalItem(Z sr)
        {
            modelDataProvider.GetLocalConnection().Update(sr);
            Items.Remove(sr.LocalId);
            Items.Add(sr.LocalId, sr);
        }

        protected internal DateTime? GetLatestUpdateDatetime()
        {
            DateTime? lastupdatetime = null;
            foreach (Z s in Items.Values)
            {
                if (s.RowLastUpdated.HasValue)
                {
                    if ((lastupdatetime == null)
                        || (DateTime.Compare(s.RowLastUpdated.Value, lastupdatetime.Value) > 0))
                    {
                        lastupdatetime = s.RowLastUpdated.Value;
                    }
                }

            }
            return lastupdatetime;
        }
    }
}
