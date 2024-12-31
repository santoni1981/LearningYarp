using MyYarpTutorial.Shared;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var suppliers = new[]
{
    new Supplier { Name = "Bright Future srl", VatNumber = "IT12345678901"},
    new Supplier { Name = "Innovative Tech Solutions spa", VatNumber = "IT23456789012"},
    new Supplier { Name = "Healthy Eats snc", VatNumber = "IT34567890123"},
    new Supplier { Name = "Creative Designs spa", VatNumber = "IT45678901234"},
    new Supplier { Name = "Reliable Services srl", VatNumber = "IT56789012345"},
    new Supplier { Name = "Urban Fashion srl", VatNumber = "IT67890123456"},
    new Supplier { Name = "EcoTech Innovations spa", VatNumber = "IT78901234567"},
    new Supplier { Name = "Global Ventures snc", VatNumber = "IT89012345678"},
    new Supplier { Name = "NextGen Solutions srl", VatNumber = "IT90123456789"},
    new Supplier { Name = "Adventure Travel Agency srl", VatNumber = "IT01234567890"},
    new Supplier { Name = "Smart Home Innovations spa", VatNumber = "IT12345678902"},
    new Supplier { Name = "Digital Media Group snc", VatNumber = "IT23456789023"},
    new Supplier { Name = "Artistic Creations snc", VatNumber = "IT34567890134"},
    new Supplier { Name = "Sustainable Solutions sas", VatNumber = "IT45678901245"},
    new Supplier { Name = "Tech Savvy srl", VatNumber = "IT56789012356"},
};

app.MapGet("/list", () =>
{
    return suppliers.OrderBy(s => s.Name);
})
.WithName("GetSuppliersList");

app.Run();
