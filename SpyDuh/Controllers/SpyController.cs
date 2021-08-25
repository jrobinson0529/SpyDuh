﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpyDuh.DataAccess;
using SpyDuh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpyDuh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpyController : ControllerBase
    {
        SpyRepository _repo;
        public SpyController()
        {
            _repo = new SpyRepository();
        }

        [HttpGet]
        public IEnumerable<Spy> GetAllSpies()
        {
            return _repo.GetAll();
        }

        // Add a new spy
        [HttpPost]

        public void AddSpy(Spy newSpy)
        {
            _repo.Add(newSpy);
        }

        // Add a new skill to a spy
        [HttpPut("{id}/skills")]
        public object UpdateSkill(Guid id, Skills skill)
        {
            return _repo.AddSkillById(id, skill);
        }

        // Delete sklls from a spy
        [HttpDelete("{id}/skills")]
        public object RemoveSkill(Guid id, Skills skill)
        {
            return _repo.RemoveSkillById(id, skill);
        }

        
    }
}