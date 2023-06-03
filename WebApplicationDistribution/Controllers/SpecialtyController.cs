using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;
using WebApplicationDistribution.Contracts.Specialties;
using WebApplicationDistribution.Exceptions;

namespace WebApplicationDistribution.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SpecialtyController : ControllerBase
{
    private ISpecialtyService _specialtyService;

    public SpecialtyController(ISpecialtyService specialtyService)
    {
        _specialtyService = specialtyService ?? throw new ArgumentNullException(nameof(specialtyService));
    }

    [HttpPost]
    //[Authorize]
    public async Task<IActionResult> Post([FromBody] Specialty specialty)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await _specialtyService.AddAsync(specialty);

        await _specialtyService.CommitChangesAsync();

        return Ok(specialty.Spec_Id);
    }

    [HttpPut("{id}")]
    //[Authorize]
    public async Task<IActionResult> Put(int id, [FromBody] Specialty specialty)
    {
        var specialties = await _specialtyService.GetRangeAsync(readOnlyIds: new ReadOnlyCollection<int>(new List<int> { id }));

        if (!specialties.Any())
        {
            throw new ElementNotFoundException();
        }

        await _specialtyService.UpdateAsync(specialty);

        await _specialtyService.CommitChangesAsync();

        return Ok();


    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var specialties = await _specialtyService.GetRangeAsync(readOnlyIds: new ReadOnlyCollection<int>(new List<int> { id }));

        if (specialties.Any())
        {
            await _specialtyService.DeleteAsync(specialties.First());

            await _specialtyService.CommitChangesAsync();
        }

        return Ok();
    }

    [HttpGet("AllSpec")]
    public IActionResult AllSpec()
    {
        var all_spec = _specialtyService.GetAllSpecialties();
        return Ok(all_spec);
    }

}

