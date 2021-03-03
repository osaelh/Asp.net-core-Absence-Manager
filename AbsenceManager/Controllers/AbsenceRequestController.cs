using AbsenceManager.Contract;
using AbsenceManager.Data;
using AbsenceManager.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbsenceManager.Controllers
{
    [Authorize]
    public class AbsenceRequestController : Controller
    {
        private readonly IAbsenceRequestRepository _absenceRequestRepo;
        private readonly IMapper _mapper;
        private readonly UserManager<IdentityUser> _userManager;

        public AbsenceRequestController(IAbsenceRequestRepository absenceRequestRepo, IMapper mapper, UserManager<IdentityUser> userManager)
        {
            _absenceRequestRepo = absenceRequestRepo;
            _mapper = mapper;
            _userManager = userManager;
        }

        // GET: AbsenceRequestController
        [Authorize(Roles ="Administrator")]
        public ActionResult Index()
        {
            var AbsenceRequests = _absenceRequestRepo.GetAll();
            var AbsenceRequestsModel = _mapper.Map<List<AbsenceRequestViewModel>>(AbsenceRequests);
            var model = new AdminAbsenceRequestViewModel
            {
                TotalRequest = AbsenceRequestsModel.Count,
                ApprouvedRequest = AbsenceRequestsModel.Where(x => x.Approved == true).Count(),
                RejectedRequest = AbsenceRequestsModel.Where(x => x.Approved == false).Count(),
                PendingRequest=AbsenceRequestsModel.Count(x=>x.Approved==null),
                AbsenceRequests = AbsenceRequestsModel

            };
            return View(model);
        }

        // GET: AbsenceRequestController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AbsenceRequestController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AbsenceRequestController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AbsenceRequestController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AbsenceRequestController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AbsenceRequestController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AbsenceRequestController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
