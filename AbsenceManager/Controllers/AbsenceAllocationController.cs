using AbsenceManager.Contract;
using AbsenceManager.Data;
using AbsenceManager.Mapping;
using AbsenceManager.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbsenceManager.Controllers
{
    public class AbsenceAllocationController : Controller
    {
        private readonly IAbsenceTypeRepository _absenceTypeRepo;
        private readonly IAbsenceAllocationRepository _absenceAllocationRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<IdentityUser> _userManager;

        public AbsenceAllocationController(IAbsenceTypeRepository absenceTypeRepo,
            IAbsenceAllocationRepository absenceAllocationRepository,
            IMapper mapper,
            UserManager<IdentityUser> userManager
            )
        {
            _absenceTypeRepo = absenceTypeRepo;
            _absenceAllocationRepository = absenceAllocationRepository;
            _mapper = mapper;
            _userManager = userManager;
        }
        // GET: AbsenceAllocationController
        public ActionResult Index()
        {
            var absenceTypes = _absenceTypeRepo.GetAll().ToList();
            var mappedAbsenceTypes = _mapper.Map<List<AbsenceType>, List<DetailsAbsenceTypeViewModel>>(absenceTypes);
            var model = new CreateAbsenceAllocationViewModel
            {
                AbsenceTypes = mappedAbsenceTypes,
                NumberUpdated = 0
            };
            return View(model);
        }
        public ActionResult SetAbsence(int id)
        {
            var AbsenceType = _absenceTypeRepo.GetById(id);
            var students = _userManager.GetUsersInRoleAsync("Student").Result;
            foreach (var student in students)
            {
                if (_absenceAllocationRepository.CheckAllocation(id, student.Id))
                    continue;
                var allocation = new AbsenceAllocationViewModel
                {
                    DateCreated = DateTime.Now,
                    StudentId = student.Id,
                    AbsenceTypeId = id,
                    NumberOfDays = AbsenceType.DefaultDays,
                    Period = DateTime.Now.Year

                };
                var absenceAllocation = _mapper.Map<AbsenceAllocation>(allocation);
                _absenceAllocationRepository.Create(absenceAllocation);
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: AbsenceAllocationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AbsenceAllocationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AbsenceAllocationController/Create
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

        // GET: AbsenceAllocationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AbsenceAllocationController/Edit/5
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

        // GET: AbsenceAllocationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AbsenceAllocationController/Delete/5
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
