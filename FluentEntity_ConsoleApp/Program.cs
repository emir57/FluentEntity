using FluentEntity_ConsoleApp.Entities;
using FluentEntity_ConsoleApp.FEntity;
using System;

namespace FluentEntity_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new FluentEntity<User>()
                .AddParameter("Id", 1)
                .AddParameters<string>("bu bir string")
                .AddParameter(u => u.EmailConfirm, false)
                .AddParameter(u => u.CreatedDate, DateTime.Now)
                .AddParameter(u => u.UpdatedDate, DateTime.Now.AddMinutes(5))
                .GetEntity();
            user = new FluentEntity<User>(user)
                .AddParameter(x => x.LastName, "Gürbüz")
                .GetEntity();
            Console.WriteLine($"{user.Id} {user.FirstName} {user.LastName}\n{user.EmailConfirm}\n{user.CreatedDate}\n{user.UpdatedDate}");
        }
    }
}
