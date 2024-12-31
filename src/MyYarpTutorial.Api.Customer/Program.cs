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

var customers = new[]
{
    new Customer { Name = "Tech Innovations srl", VatNumber = "IT12345678901"},
    new Customer { Name = "Green Solutions spa", VatNumber = "IT23456789012"},
    new Customer { Name = "Culinary Delights snc", VatNumber = "IT34567890123"},
    new Customer { Name = "Artisan Crafts sas", VatNumber = "IT45678901234"},
    new Customer { Name = "Global Logistics spa", VatNumber = "IT56789012345"},
    new Customer { Name = "Smart Home Systems srl", VatNumber = "IT67890123456"},
    new Customer { Name = "Eco-Friendly Products spa", VatNumber = "IT78901234567"},
    new Customer { Name = "Digital Marketing Agency snc", VatNumber = "IT89012345678"},
    new Customer { Name = "Fashion Trends Boutique srl", VatNumber = "IT90123456789"},
    new Customer { Name = "Health & Wellness Center srl", VatNumber = "IT01234567890"},
};

app.MapGet("/list", () =>
{
    return customers.OrderBy(c => c.Name);
})
.WithName("GetCustomersList");

app.Run();