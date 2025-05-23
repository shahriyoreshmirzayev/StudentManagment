using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using StudentManagment.Client;
using StudentManagment.Client.Services;
using StudentManagment.Shared.StudentRepository;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();

builder.Services.AddScoped<IStudentRepository, StudentService>();
builder.Services.AddScoped<ICountryRepository, CountryService>();
builder.Services.AddScoped<ISystemCodeDetailRepository, SystemCodeDetailService>();
builder.Services.AddScoped<ISystemCodeRepository, SystemCodeService>();
builder.Services.AddScoped<IParentRepository, ParentService>();
builder.Services.AddScoped<ITeacherRepository, TeacherService>();
builder.Services.AddScoped<ISubjectRepository, SubjectService>();
builder.Services.AddScoped<IBookRepository, BookService>();

builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});
await builder.Build().RunAsync();