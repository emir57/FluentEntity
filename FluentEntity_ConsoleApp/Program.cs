using FluentEntity_ConsoleApp.Entities;
using FluentEntity_ConsoleApp.FEntity;
using System;

namespace FluentEntity_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new CustomFluentEntity<User>()
                .AddParameter(u => u.Id, 1)
                .AddParameter(u => u.FirstName, "Emir")
                .AddParameter(u => u.LastName, "Gürbüz")
                .AddParameter(u => u.EmailConfirm, true)
                .AddParameter(u => u.CreatedDate, DateTime.Now)
                .AddParameter(u => u.UpdatedDate, DateTime.Now.AddMinutes(5))
                .GetEntity();
            Console.WriteLine($"{user.Id} {user.FirstName} {user.LastName}\n{user.EmailConfirm}\n{user.CreatedDate}\n{user.UpdatedDate}");
        }
    }
}
