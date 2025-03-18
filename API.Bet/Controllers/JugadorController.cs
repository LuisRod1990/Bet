using System.Collections.Generic;
using API.Bet.Data;
using API.Bet.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Bet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JugadorController : ControllerBase
    {
        private readonly ILogger<JugadorController> _logger;
        private readonly DataContext _context;
        public JugadorController(DataContext _context, ILogger<JugadorController> logger) 
        {
            _logger = logger;
            this._context = _context;
        }

        [HttpGet]
        public async Task<ActionResult<List<VMPlayer>>> Get()
        {
            List<VMPlayer> lstPlayers = await _context.C_Player.ToListAsync();
            return Ok(lstPlayers);
        }




    }
}
