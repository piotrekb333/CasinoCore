using Models.Casino.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasioCore.Services.Interfaces
{
    public interface IMessageService
    {
        bool SendMessage(MessageDto model);
    }
}
