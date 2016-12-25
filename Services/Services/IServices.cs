using PetaPoco;
using Services.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public interface IServices: IDependency
    {
        List<SystemMenu> GetMenus();
        SystemMenu Find(int id);

        int Insert(SystemMenu entity);

        int Update(SystemMenu entity);
        int Delete(List<long> ids);
    }
}
