using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodShop.ViewModels.System.Roles
{
    public interface IRoleService
    {
        Task<List<RoleVm>> GetAll();
    }
}
