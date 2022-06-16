# FluentEntity

Basic Usage <br>
Create New User

```C#
User user = new FluentEntity<User>()
                .AddParameter("Id", 1)
                .AddParameter(u => u.EmailConfirm, true)
                .AddParameter(u => u.CreatedDate, DateTime.Now)
                .AddParameter(u => u.UpdatedDate, DateTime.Now.AddMinutes(5))
                .GetEntity();
```

<br>
Update User

```C#
User user = new User();
user = new FluentEntity<User>(user)
                .AddParameter(x => x.FirstName, "Emir")
                .AddParameter(x => x.LastName, "Gürbüz")
                .GetEntity();
```

<br>
Assigns values to all properties of the selected type

```C#
User user = new FluentEntity<User>()
                .AddParameters<string>("assigns this value by all strings")
                .GetEntity();
```
