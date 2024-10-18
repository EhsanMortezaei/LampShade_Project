using AccountManagement.Application.Contracts.Role;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Adminstration.Pages.Accounts.Role
{
    public class CreateModel : PageModel
    {
        public CreateRole Command;
        private readonly IRoleApplication _roleApplication;

        public CreateModel(IRoleApplication roleApplication)
        {
            _roleApplication = roleApplication;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost(CreateRole command)
        {
            var result = _roleApplication.Create(command);
            return RedirectToPage("Index");
        }
    }
}
