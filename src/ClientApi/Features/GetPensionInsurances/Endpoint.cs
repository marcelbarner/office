using Domain;

namespace ClientApi.Features.GetPensionInsurances;

sealed class Endpoint : Endpoint<Request, IEnumerable<PensionInsurance>>
{
    public override void Configure()
    {
        Get("/api/pension-insurances");
        AllowAnonymous();
    }

    public override async Task HandleAsync(Request r, CancellationToken c)
    {
        await SendAsync(CreatePensionInsurance.Endpoint.PensionInsurances, cancellation: c);
    }
}