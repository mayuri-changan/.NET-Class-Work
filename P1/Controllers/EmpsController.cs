using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P1.Models;
[EnableCors(policyName: "IET")]
[Route("api/[controller]")]
[ApiController]
public class EmpsController : ControllerBase
{
    private readonly EmpDbContext _context;
    public EmpsController(EmpDbContext context)
    {
        _context = context;
    }

    // GET: api/Emp
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Emp>>> GetEmp()
    {
        return await _context.Emps.ToListAsync();
    }

    // GET: api/Emp/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Emp>> GetEmp(int id)
    {
        var emp = await _context.Emps.FindAsync(id);

        if (emp == null)
        {
            return NotFound();
        }

        return emp;
    }

    // PUT: api/Emp/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutEmp(int? id, Emp emp)
    {
        if (id != emp.Id)
        {
            return BadRequest();
        }

        _context.Entry(emp).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!EmpExists(id))
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

    // POST: api/Emp
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Emp>> PostEmp(Emp emp)
    {
        _context.Emps.Add(emp);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetEmp", new { id = emp.Id }, emp);
    }

    // DELETE: api/Emp/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteEmp(int? id)
    {
        var emp = await _context.Emps.FindAsync(id);
        if (emp == null)
        {
            return NotFound();
        }

        _context.Emps.Remove(emp);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool EmpExists(int? id)
    {
        return _context.Emps.Any(e => e.Id == id);
    }
}
