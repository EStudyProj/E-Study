using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EStudy.Application.Interfaces.MVC;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EStudy.MVC.Controllers
{
    public class GroupController : Controller
    {
        private readonly ILogger<GroupController> _logger;
        private IGroupService groupService;
        public GroupController(ILogger<GroupController> logger, IGroupService _groupService)
        {
            _logger = logger;
            groupService = _groupService;
        }


    }
}
