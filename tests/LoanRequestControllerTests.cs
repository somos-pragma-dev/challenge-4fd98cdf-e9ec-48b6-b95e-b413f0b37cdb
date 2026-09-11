using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

public class LoanRequestControllerTests
{
    private readonly HttpClient _client;

    public LoanRequestControllerTests()
    {
        var webHostBuilder = new WebApplicationFactory<Program>().WithWebHostBuilder(builder =>
        {
            builder.ConfigureServices(services =>
            {
                var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<LoanRequestContext>));
                services.Remove(descriptor);
                services.AddDbContext<LoanRequestContext>(options =>
                    options.UseInMemoryDatabase("InMemoryDbForTesting"));
            });
        });

        _client = webHostBuilder.CreateClient();
    }

    [Fact]
    public async Task Post_ValidLoanRequest_ReturnsCreated()
    {
        var request = new LoanRequest
        {
            OperationNumber = "12345",
            Amount = 10000,
            Term = 12,
            Channel = "online"
        };

        var response = await _client.PostAsJsonAsync("/loanrequest", request);

        Assert.Equal(HttpStatusCode.Created, response.StatusCode);
    }
}