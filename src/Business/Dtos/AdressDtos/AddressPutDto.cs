namespace Business.Dtos;

public class AddressPutDto
{
    public int Id { get; set; }
    public string Street { get; set; } = null!;
    public string City { get; set; } = null!;
    public string State { get; set; } = null!;
    public int EmployeId { get; set; }
}
