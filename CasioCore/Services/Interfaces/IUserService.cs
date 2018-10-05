﻿using Models.Casino.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasioCore.Services.Interfaces
{
    public interface IUserService
    {
        UserDto Authenticate(string username, string password);
    }
}
