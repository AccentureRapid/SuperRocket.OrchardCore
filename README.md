# SuperRocket.OrchardCore
SuperRocket.OrchardCore is an ABP Module Zero ASP.NET Core Template with all things ready to go!

After creating and downloading your project,

Open your solution on Visual Studio 2017+.
Select the 'Web.Mvc' project as startup project.
Migrator.EF tool is used for adding/applying EntityFramework migrations. In order to create your database, open command prompt and move to root folder of EntityFramework project in your solution. Then run "dotnet ef database update" command."
Run the application. User name is 'admin' and password is '123qwe' as default.
In this template, multi-tenancy is enabled by default. You can disable it in Core project's module class if you don't need.
