using Microsoft.AspNetCore.Mvc;
using src.Models;
using src.Services;

[ApiController]
[Route("[controller]")]
public class LoanRequestController : ControllerBase
{
    private readonly LoanRequestService _loanRequestService;

    public LoanRequestController(LoanRequestService loanRequestService)
    {
        _loanRequestService = loanRequestService;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Post([FromBody] LoanRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await _loanRequestService.ProcessLoanRequestAsync(request);

        return CreatedAtAction(nameof(Post), new { id = request.OperationNumber }, request);
    }
}