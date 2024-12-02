using Domain;

namespace ClientApi.Features.CreatePensionInsurance;

sealed class Endpoint : Endpoint<Request, Response>
{
    static int s_lastId = 0;
    public static List<PensionInsurance> PensionInsurances = [
        new PensionInsurance(){Name = "Retirement Plan A", CurrentValue = 50000.75m}
    ];
    public override void Configure()
    {
        Post("/api/pension-insurances");
        AllowAnonymous();
    }

    public override async Task HandleAsync(Request r, CancellationToken c)
    {
        s_lastId++;
        var newPensionInsurance = new PensionInsurance { Id = s_lastId, Name = r.Name };
        PensionInsurances.Add(newPensionInsurance);
        await SendAsync(new Response() { Id = newPensionInsurance.Id, Name = newPensionInsurance.Name, Value = 0 });
    }
}