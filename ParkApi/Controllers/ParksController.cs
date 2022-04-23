using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkApi.Models;

namespace StateAndNationalParks.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private readonly ParkApiContext _db;

    public ParksController(ParkApiContext db)
    {
      _db = db;
    }

    // GET: api/Parks
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get()
    {
      return await _db.Parks.ToListAsync();
    }
    public async Task<ActionResult<IEnumerable<Park>>> Get(string parkId, string name, string location, int yearFounded, string activities)
    {
      var query = _db.Parks.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (location != null)
      {
        query = query.Where(entry => entry.Location == location);
      }    
      if (yearFounded != 0)
      {
        query = query.Where(entry => entry.YearFounded == yearFounded);
      }
      if (activities != null)
      {
        query = query.Where(entry => entry.Activities == activities);
      }  
      return await query.ToListAsync();
    }


    // GET: api/Parks/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int parkId)
    {
        var park = await _db.Parks.FindAsync(parkId);

        if (park == null)
        {
            return NotFound();
        }

        return park;
    }

    // PUT: api/Parks/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int parkId, Park park)
    {
      if (parkId != park.ParkId)
      {
        return BadRequest();
      }

      _db.Entry(park).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ParkExists(parkId))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    // POST: api/Parks
    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetPark), new { parkId = park.ParkId }, park);
    }

    // DELETE: api/Parks/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int parkId)
    {
      var park = await _db.Parks.FindAsync(parkId);
      if (park == null)
      {
        return NotFound();
      }

      _db.Parks.Remove(park);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool ParkExists(int parkId)
    {
      return _db.Parks.Any(e => e.ParkId == parkId);
    }
  }
}