using System;
using FormAutomationApi.Context;
using FormAutomationApi.DTOs;
using FormAutomationApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FormAutomationApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly ITokenService _tokenService;

        public AdminController(ApplicationDbContext context , ITokenService tokenService) { 
            _context = context; 
            _tokenService = tokenService;
        }

       
        // admin create session and sends the data
        [HttpPost("create-session")]
        public async Task<IActionResult> createSession(SendFormRequest body)
        {
            //create a session and send token to frontend
            if (body == null)
            {
                return BadRequest("NO data found form the admin");
            }

            var expiresAt = DateTime.UtcNow.AddHours(24);
            var token = _tokenService.Generate(body, expiresAt);

            return Ok(new { token, expiresAt });
        }

        // get details from session to patient


        //
    }
}

public interface RequestSessionBody
{
    public int patientId { get; set; }

    public string formlabel { get; set; }
}
