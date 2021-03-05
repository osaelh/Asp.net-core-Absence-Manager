using AbsenceManager.Contract;
using AbsenceManager.Data;
using AbsenceManager.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        private readonly IAbsenceTypeRepository _absenceTypeRepository;
        private readonly IAbsenceAllocationRepository _absenceAllocationRepository;

        public AbsenceRequestController(IAbsenceRequestRepository absenceRequestRepo, IMapper mapper, UserManager<IdentityUser> userManager, IAbsenceTypeRepository absenceTypeRepository, IAbsenceAllocationRepository absenceAllocationRepository)
        {
            _absenceRequestRepo = absenceRequestRepo;
            _mapper = mapper;
            _userManager = userManager;
            _absenceTypeRepository = absenceTypeRepository;
            _absenceAllocationRepository = absenceAllocationRepository;
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
            var AbsenceRequest = _absenceRequestRepo.GetById(id);
            var model = _mapper.Map<AbsenceRequestViewModel>(AbsenceRequest);
            return View(model);
        }

        public ActionResult ApprouveRequest(int id)
        {
            try
            {
                var user = _userManager.GetUserAsync(User).Result;
                var AbsenceRequest = _absenceRequestRepo.GetById(id);
                var allocation = _absenceAllocationRepository.GetAbsenceAllocationsByStudent(AbsenceRequest.RequestingStudentId).FirstOrDefault(x=>x.AbsenceTypeId==AbsenceRequest.AbsenceTypeId);

                int daysRequested = (int)(AbsenceRequest.EndDate - AbsenceRequest.StartDate).TotalDays;
                allocation.NumberOfDays -= daysRequested;

                AbsenceRequest.Approved = true;
                AbsenceRequest.ApprovedById = user.Id;
                AbsenceRequest.ActionDate = DateTime.Now;
                _absenceRequestRepo.Update(AbsenceRequest);
                _absenceAllocationRepository.Update(allocation);
                return    RedirectToAction("Index");
              
            }
            catch (Exception ex)
            {

               return  RedirectToAction("Index");
            }
        }
        public ActionResult RejectRequest(int id)
        {
            try
            {
                var user = _userManager.GetUserAsync(User).Result;
                var AbsenceRequest = _absenceRequestRepo.GetById(id);
                AbsenceRequest.Approved = false;
                AbsenceRequest.ApprovedById = user.Id;
                AbsenceRequest.ActionDate = DateTime.Now;
                _absenceRequestRepo.Update(AbsenceRequest);
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {

                return RedirectToAction("Index");
            }
        }
        // GET: AbsenceRequestController/Create
        public ActionResult Create()
        {
            var absenceTypes = _absenceTypeRepository.GetAll().ToList();
            var absenceTypesItems = absenceTypes.Select(x => new SelectListItem 
            { 
              Text=x.Name,
              Value=x.Id.ToString()
            }).ToList();
            var model = new CreateAbsenceRequestViewModel
            {
                AbsenceTypes = absenceTypesItems
            };
            return View(model);
        }

        // POST: AbsenceRequestController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateAbsenceRequestViewModel model)
        {

            try
            {
                var StartDate = Convert.ToDateTime(model.StartDate);
                var EndDate = Convert.ToDateTime(model.EndDate);
                var absenceTypes = _absenceTypeRepository.GetAll().ToList();
                var absenceTypesItems = absenceTypes.Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                }).ToList();
                model.AbsenceTypes = absenceTypesItems;
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                if (DateTime.Compare(StartDate,EndDate)>1)
                {
                    ModelState.AddModelError("", "Start Date cannot be further in the future the the end date");
                    return View(model);
                }
                var student = _userManager.GetUserAsync(User).Result;
                var allocation = _absenceAllocationRepository.GetAbsenceAllocationsByStudent(student.Id).FirstOrDefault(x=>x.AbsenceTypeId==model.AbsenceTypeId);
                int daysRequested = (int)(EndDate.Date - StartDate.Date).TotalDays;

                if (daysRequested>allocation.NumberOfDays)
                {
                    ModelState.AddModelError("", "You do not have enough days for this request");
                    return View(model);
                }
                var AbsenceRequestVm = new AbsenceRequestViewModel
                {
                    RequestingStudentId = student.Id,
                    StartDate = StartDate,
                    EndDate = EndDate,
                    Approved = null,
                    RequestDate = DateTime.Now,
                    ActionDate = DateTime.Now,
                    AbsenceTypeId=model.AbsenceTypeId

                };
                var AbsenceRequest = _mapper.Map<AbsenceRequest>(AbsenceRequestVm);
                var isSuccuss = _absenceRequestRepo.Create(AbsenceRequest);
                if (!isSuccuss)
                {
                    ModelState.AddModelError("", "Something went wrong in the submit action");
                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
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
