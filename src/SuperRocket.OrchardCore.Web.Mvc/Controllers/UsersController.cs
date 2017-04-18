using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using SuperRocket.OrchardCore.Authorization;
using SuperRocket.OrchardCore.Controllers;
using SuperRocket.OrchardCore.Users;
using Microsoft.AspNetCore.Mvc;

namespace SuperRocket.OrchardCore.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class UsersController : OrchardCoreControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public async Task<ActionResult> Index()
        {
            var output = await _userAppService.GetUsers();
            return View(output);
        }
    }
}