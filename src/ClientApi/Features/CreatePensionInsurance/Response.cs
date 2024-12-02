namespace ClientApi.Features.CreatePensionInsurance;

public class Response
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public decimal Value { get; set; }
}