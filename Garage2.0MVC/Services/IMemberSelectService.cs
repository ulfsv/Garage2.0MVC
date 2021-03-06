﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Garage2._0MVC.Services
{
    public interface IMemberSelectService
    {
        Task<IEnumerable<SelectListItem>> GetMembersAsync();
    }
}