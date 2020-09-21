using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EStudy.Application.Interfaces.MVC;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EStudy.MVC.Controllers
{
    [Route("Group")]
    public class GroupController : Controller
    {
        private readonly ILogger<GroupController> _logger;
        private IGroupService groupService;
        public GroupController(ILogger<GroupController> logger, IGroupService _groupService)
        {
            _logger = logger;
            groupService = _groupService;
        }

        [HttpGet("{Id?}")]
        public async Task<IActionResult> GetGroup(int? Id)
        {
            if (Id is null)
            {
                if (User.IsInRole("Student") || User.IsInRole("Headman"))
                {
                    var groupStudent = await groupService.GetMyGroup(GetCurrentId());
                    return View(groupStudent);
                }
                else
                    return View("Error");
            }
            var group = await groupService.GetGroup(Convert.ToInt32(Id));
            if (group == null)
                return View("Error");
            return View(group);
        }

        [NonAction]
        private int GetCurrentId()
        {
            try
            {
                return Convert.ToInt32(User.Claims.FirstOrDefault(d => d.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier").Value);
            }
            catch
            {
                return 0;
            }
        }
    }
}
