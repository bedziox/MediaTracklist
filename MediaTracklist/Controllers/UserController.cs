using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaTracklist.Models;
using MediaTracklist.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace MediaTracklist.Controllers
{
    [Route("api/[controller]/user")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserRepository _userRepository;
        public UserController(UserRepository userRepository, ILogger<UserController> logger)
        {
            this._logger = logger;
            this._userRepository = userRepository;
        }
        [HttpGet]
        public IEnumerable<User> Index()
        {
            var model = _userRepository.GetAll();
            return model;
        }
        [HttpPost("add")]
        public ActionResult<string> AddUser(User model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _userRepository.Insert(model);
                    _userRepository.Save();
                    return Created("User added to database", model);
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.ToString());
                return BadRequest("User not added");
            }
            return BadRequest("Something went wrong.");
        }
        [HttpPost("edit")]
        public ActionResult EditUser(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _userRepository.Update(user);
                    _userRepository.Save();
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.ToString());
                return BadRequest("User not edited.");
            }
            return BadRequest("Something went wrong.");
        }
        
        [HttpPost("delete")]
        public ActionResult<string> Delete(int userId)
        {
            try
            {
                _userRepository.Delete(userId);
                _userRepository.Save();
                return Ok("User deleted from database");
            }
            catch (Exception e)
            {
                _logger.LogError(e.ToString());
                return BadRequest("User not deleted.");
            }
        }
    }
    
}
