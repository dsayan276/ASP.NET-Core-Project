using ADO.NET_Core_L1_Hands_On.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace ADO.NET_Core_L1_Hands_On.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<string> CultureList = new List<string>();
            CultureInfo[] getCultureInfo = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach(CultureInfo getCulture in getCultureInfo)
            {
                RegionInfo GetRegionInfo = new RegionInfo(getCulture.LCID);
                if(!(CultureList.Contains(GetRegionInfo.EnglishName)))
                {
                    CultureList.Add(GetRegionInfo.EnglishName);
                }
            }
            CultureList.Sort();
            //---------------
            Country obj = new Country();
            obj.names=CultureList;
            return View(obj);
        }
        public IActionResult Second()
        {
            return View();
        }
        public IActionResult Third()
        {
            return View();
        }
        public  IActionResult Mugs()
        {
            return View();
        }
        public IActionResult Tshirts()
        {
            return View();
        }
        public IActionResult Laopala()
        {
            return View();
        }
        public IActionResult Raymond()
        {
            return View();
        }
    }
}
