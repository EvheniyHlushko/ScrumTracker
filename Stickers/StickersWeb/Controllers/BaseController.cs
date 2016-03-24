using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace StickersWeb.Controllers
{
    public class BaseController : Controller
    {
        
        protected string CurrentUserId
        {
            get
            {
                return System.Web.HttpContext.Current.User.Identity.GetUserId();
            }
        }
    }
}