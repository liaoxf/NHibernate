using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;

namespace Services
{
    public class Service : IServices
    {
        Database db = new Database("connectionString");
        public Service()
        {

        }

        public int Delete(List<long> ids)
        {
            return db.Delete<SystemMenu>(ids);
        }

        public SystemMenu Find(int id)
        {
            return db.Single<SystemMenu>(id);
        }

        public List<SystemMenu> GetMenus()
        {
            return db.Query<SystemMenu>("select * from SystemMenu").ToList();
        }

        public int Insert(SystemMenu entity)
        {
            var result = db.Insert(entity);
            return Convert.ToInt32(result);
        }

        public int Update(SystemMenu entity)
        {
            var result = db.Update("SystemMenu", "Id", false, entity);
            //todo:
            return Convert.ToInt32(result);
        }
    }
}
