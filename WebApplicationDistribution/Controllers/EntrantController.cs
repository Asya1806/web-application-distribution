using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;
using WebApplicationDistribution.Attributes;
using WebApplicationDistribution.Contracts.Entrants;
using WebApplicationDistribution.Contracts.Specialties;
using WebApplicationDistribution.Exceptions;

namespace WebApplicationDistribution.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EntrantController : ControllerBase
{
    private IEntrantService _entrantService;

    public EntrantController(IEntrantService entrantService)
    {
        _entrantService = entrantService ?? throw new ArgumentNullException(nameof(entrantService));
    }

    /// <summary>
    /// Create Entrant
    /// </summary>
    /// <param name="entrant"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Entrant entrant)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
                    
        await _entrantService.AddAsync(entrant);

        await _entrantService.CommitChangesAsync();
        
        return Ok(entrant.Entrant_Id); 
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] Entrant entrant)
    {
        var entrants = await _entrantService.GetRangeAsync(readOnlyIds: 
            new ReadOnlyCollection<int>(new List<int> { id }));

        if (!entrants.Any())
        {
            throw new ElementNotFoundException();
        }

        await _entrantService.UpdateAsync(entrant);

        await _entrantService.CommitChangesAsync();

        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var entrants = await _entrantService.GetRangeAsync(readOnlyIds: new ReadOnlyCollection<int>(new List<int> { id }));

        if (entrants.Any())
        {
            await _entrantService.DeleteAsync(entrants.First());

            await _entrantService.CommitChangesAsync();
        }

        return Ok();
    }

    [HttpGet("Specialty_by_budget_1")]
    public IActionResult Spec_by_budget_1()
    {
        var toAdd = _entrantService.DistributionEntrant(new List<int> { 1, 2, 3, 4, 5, 6 }, _entrantService.listSeatsBudget(), 1);
        
        return Ok(toAdd[0]);
    }

    [HttpGet("Specialty_by_budget_2")]
    public IActionResult Spec_by_budget_2()
    {
        var toAdd = _entrantService.DistributionEntrant(new List<int> { 1, 2, 3, 4, 5, 6 }, _entrantService.listSeatsBudget(), 1);
        return Ok(toAdd[1]);
    }

    [HttpGet("Specialty_by_budget_3")]
    public IActionResult Spec_by_budget_3()
    {
        var toAdd = _entrantService.DistributionEntrant(new List<int> { 1, 2, 3, 4, 5, 6 }, _entrantService.listSeatsBudget(), 1);
        return Ok(toAdd[2]);
    }

    [HttpGet("Specialty_by_budget_4")]
    public IActionResult Spec_by_budget_4()
    {
        var toAdd = _entrantService.DistributionEntrant(new List<int> { 1, 2, 3, 4, 5, 6 }, _entrantService.listSeatsBudget(), 1);
        return Ok(toAdd[3]);
    }

    [HttpGet("Specialty_by_budget_5")]
    public IActionResult Spec_by_budget_5()
    {
        var toAdd = _entrantService.DistributionEntrant(new List<int> { 1, 2, 3, 4, 5, 6 }, _entrantService.listSeatsBudget(), 1);
        return Ok(toAdd[4]);
    }

    [HttpGet("Specialty_by_budget_6")]
    public IActionResult Spec_by_budget_6()
    {
        var toAdd = _entrantService.DistributionEntrant(new List<int> { 1, 2, 3, 4, 5, 6 }, _entrantService.listSeatsBudget(), 1);
        return Ok(toAdd[5]);
    }  
    
    [HttpGet("Specialty_by_paid_1")]
    public IActionResult Spec_by_paid_1()
    {
        var toAdd = _entrantService.DistributionEntrant(new List<int> { 1, 2, 3, 4, 5, 6 }, _entrantService.listSeatsPaid(), 2);
        
        return Ok(toAdd[0]);
    }

    [HttpGet("Specialty_by_paid_2")]
    public IActionResult Spec_by_paid_2()
    {
        var toAdd = _entrantService.DistributionEntrant(new List<int> { 1, 2, 3, 4, 5, 6 }, _entrantService.listSeatsPaid(), 2);
        return Ok(toAdd[1]);
    }

    [HttpGet("Specialty_by_paid_3")]
    public IActionResult Spec_by_paid_3()
    {
        var toAdd = _entrantService.DistributionEntrant(new List<int> { 1, 2, 3, 4, 5, 6 }, _entrantService.listSeatsPaid(), 2);
        return Ok(toAdd[2]);
    }

    [HttpGet("Specialty_by_paid_4")]
    public IActionResult Spec_by_paid_4()
    {
        var toAdd = _entrantService.DistributionEntrant(new List<int> { 1, 2, 3, 4, 5, 6 }, _entrantService.listSeatsPaid(), 2);
        return Ok(toAdd[3]);
    }

    [HttpGet("Specialty_by_paid_5")]
    public IActionResult Spec_by_paid_5()
    {
        var toAdd = _entrantService.DistributionEntrant(new List<int> { 1, 2, 3, 4, 5, 6 }, _entrantService.listSeatsPaid(), 2);
        return Ok(toAdd[4]);
    }

    [HttpGet("Specialty_by_paid_6")]
    public IActionResult Spec_by_paid_6()
    {
        var toAdd = _entrantService.DistributionEntrant(new List<int> { 1, 2, 3, 4, 5, 6 }, _entrantService.listSeatsPaid(), 2);
        return Ok(toAdd[5]);
    }

    [HttpGet("All")]
    [Authorize]
    public IActionResult All()
    {
        var all = _entrantService.CommissionDecision();
        //var all = _entrantService.GetAllEntrants();
        //var all = _entrantService.GetAllEntrants()
        //    .Where(x => x.ApplicationForPaid_Id == 1).Where(x => x.TypeOfСontest_Id == 4).OrderByDescending(a => a.SumOfPoints)
        //    .ThenByDescending(a => a.TestMath).ThenByDescending(a => a.TestPhys)
        //    .ThenByDescending(a => a.MiddleMark).ToList();
        return Ok(all);
    }
}
