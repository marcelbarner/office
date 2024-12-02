namespace Domain;

public class PensionInsurance
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal CurrentValue { get; set; }
    public ICollection<PensionInsuranceActivity>? Activities { get; set; }
}