using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CasioCore.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Casino.Entities;

namespace CasioCore.Controllers
{
    [Produces("application/json")]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleService _articleService = null;
        private readonly IMapper _mapper =null ;
        public ArticlesController(IMapper mapper,IArticleService articleService)
        {
            _mapper = mapper;
            _articleService = articleService;
        }

        [HttpGet]
        [Route("api/Articles/GetAll")]
        public IActionResult GetAll()
        {
            var result = _articleService.GetAllArticles();
            return Ok(result);
        }
    }
}