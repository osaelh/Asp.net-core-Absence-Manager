﻿using AbsenceManager.Contract;
using AbsenceManager.Data;
using AbsenceManager.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbsenceManager.Controllers
{
    public class AbsenceTypeController : Controller
    {
        private readonly IAbsenceTypeRepository _repo;
        private readonly IMapper _mapper;

        public AbsenceTypeController(IAbsenceTypeRepository repo,IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }
        // GET: AbsenceTypeController
        public ActionResult Index()
        {
            var AbsenceTypes = _repo.GetAll().ToList();
            var model = _mapper.Map<List<AbsenceType>, List<DetailsAbsenceTypeViewModel>>(AbsenceTypes);
            return View(model);
        }

        // GET: AbsenceTypeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AbsenceTypeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AbsenceTypeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateAbsenceTypeViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var AbsenceType = _mapper.Map<AbsenceType>(model);
                AbsenceType.DateCreated = DateTime.Now;
                var IsSuccess = _repo.Create(AbsenceType);
                if (!IsSuccess)
                {
                    ModelState.AddModelError("", "Something Went wrong");
                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AbsenceTypeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AbsenceTypeController/Edit/5
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

        // GET: AbsenceTypeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AbsenceTypeController/Delete/5
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
