// See https://aka.ms/new-console-template for more information

using EntityFramework.Presentation.UI;
using Serilog;
using Serilog.Core;

ManageDepartment manageDepartment = new ManageDepartment();
manageDepartment.Run();

ManageEmployee manageEmployee = new ManageEmployee();
manageEmployee.Run();

