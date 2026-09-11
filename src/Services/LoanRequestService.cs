using Microsoft.EntityFrameworkCore;
using src.Data;
using src.Models;

public class LoanRequestService
{
    private readonly LoanRequestContext _context;

    public LoanRequestService(LoanRequestContext context)
    {
        _context = context;
    }

    public async Task ProcessLoanRequestAsync(LoanRequest request)
    {
        if (await _context.LoanRequests.AnyAsync(r => r.OperationNumber == request.OperationNumber && r.Channel == request.Channel))
        {
            return; // Idempotence: request already processed
        }

        _context.LoanRequests.Add(request);
        await _context.SaveChangesAsync();
    }
}