using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymSystemBLL.Models;
using GymSystemBLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GymSystem.Controllers
{
    public class MemberController(IMemberService _memberService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var Members = await _memberService.GetAllMembersAsync();
            return View(Members);
        }


        #region Create Member
        [HttpGet]
        public IActionResult AddMember() => View();

        [HttpPost]
        public async Task<IActionResult> AddMember(CreateMemberModelView model)
        {
           var res = await _memberService.CreateMemberAsync(model);
           if(res) {
            ViewData["CreationFaild"] = false;
            return View(model);
           }
           return RedirectToAction(nameof(Index));
        } 
        #endregion
        

    }
}