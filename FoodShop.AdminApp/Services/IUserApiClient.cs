﻿using FoodShop.ViewModels.Common;
using FoodShop.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodShop.AdminApp.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);

        Task<PagedResult<UserVm>> GetUsersPagings(GetUserPagingRequest request);
    }
}