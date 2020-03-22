using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cov19.Data.Entities;
using Cov19.Services.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Cov19.Controllers
{
    public class PatientsController : Controller
    {

        private readonly IPatientsService _patientsService;

        public PatientsController(IPatientsService patientsService)
        {
            _patientsService = patientsService;
        }

        //Get Index
        public IActionResult Index()
        {
            var patientsList = _patientsService.GetAllPatients();
            return View(patientsList);
        }

        //Get Create
        public IActionResult Create()
        {
            return View();
        }

        //Set Create
        [HttpPost]
        public IActionResult Create(Patients patients)
        {
            if (ModelState.IsValid)
            {
                _patientsService.Add(patients);
                _patientsService.AgeCalc(patients, patients.DateOfBirth);
                _patientsService.BolniotOzdraveniotIMrtviot(patients, patients.Infected, patients.Recovered, patients.Dead);
                return RedirectToAction(nameof(Index));
            }
            return View(patients);
        }

        //Get Edit Basic Info
        public IActionResult EditBasicInfo(int id)
        {
            var patients = _patientsService.GetPatientsById(id);
            if (patients == null)
            {
                return NotFound();
            }
            return View(patients);
        }

        //Set Edit Basic Info
        [HttpPost]
        public IActionResult EditBasicInfo(int id, Patients patients)
        {
            if (id != patients.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _patientsService.Edit(patients);
                    _patientsService.AgeCalc(patients, patients.DateOfBirth);
                    _patientsService.BolniotOzdraveniotIMrtviot(patients, patients.Infected, patients.Recovered, patients.Dead);
                }
                catch (Exception ex)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(patients);
        }

        //Get Edit Status
        public IActionResult EditStatus(int id)
        {
            var patients = _patientsService.GetPatientsById(id);
            if (patients == null)
            {
                return NotFound();
            }
            return View(patients);
        }

        //Set Edit Status
        [HttpPost]
        public IActionResult EditStatus(int id, Patients patients)
        {
            if (id != patients.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _patientsService.Edit(patients);
                    _patientsService.BolniotOzdraveniotIMrtviot(patients, patients.Infected, patients.Recovered, patients.Dead);
                }
                catch (Exception ex)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(patients);
        }


        //Get Details
        public IActionResult Details(int id)
        {
            var patients = _patientsService.GetPatientsById(id);

            if (patients == null)
            {
                return NotFound();
            }
            return View(patients);
        }

        //Get Delete 
        public IActionResult Delete(int id)
        {
            var patients = _patientsService.GetPatientsById(id);
            if (patients == null)
            {
                return NotFound();
            }
            return View(patients);
        }
        
        //Set Delete
        [HttpPost]
        public IActionResult Delete(int id, Patients patients)
        {
            if (id != patients.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _patientsService.Delete(patients);
                }
                catch (Exception ex)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(patients);
        }

    }
}