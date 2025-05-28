using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using University.Infrastructure;
using University.Infrastructure.Models;
using University.Infrastructure.Repositories;
using University.Infrastructure.Services;

namespace University.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddDbContext<UniversityContext>(options =>
                options.UseSqlite("Data Source=university.db"));

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddScoped(typeof(ICrudServiceAsync<>), typeof(CrudServiceAsync<>));

            var serviceProvider = services.BuildServiceProvider();

            using var scope = serviceProvider.CreateScope();
            var studentService = scope.ServiceProvider.GetRequiredService<ICrudServiceAsync<StudentModel>>();

            Console.WriteLine("Створення нового студента...");
            var newStudent = new StudentModel
            {
                FirstName = "Жирнов",
                LastName = "Олександр",
                BirthDate = new DateTime(2005, 03, 25)
            };

            await studentService.CreateAsync(newStudent);
            Console.WriteLine("Акаунт студента створено!");

            Console.WriteLine("\nПеречислення всіх акаунтів студентів:");
            var students = await studentService.ReadAllAsync();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id}: {student.FirstName} {student.LastName}");
            }
        }
    }
}