using AutoMapper;
using CasioCore.Services.Interfaces;
using DAL.Casino.Repositories.Interfaces;
using Models.Casino.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasioCore.Services.Implementations
{
    public class MessageService : IMessageService
    {
        private readonly IMessageRepository _messageRepository;
        private readonly IMapper _mapper;
        public MessageService(IMapper mapper, IMessageRepository messageRepository)
        {
            _mapper = mapper;
            _messageRepository = messageRepository;
        }

        public bool SendMessage(MessageDto model)
        {
            _messageRepository.Create(new Models.Casino.Entities.Message
            {
                Body=model.Body,
                Email=model.Email,
                CreatedDate=DateTime.UtcNow
            });
            return true;
        }
    }
}
