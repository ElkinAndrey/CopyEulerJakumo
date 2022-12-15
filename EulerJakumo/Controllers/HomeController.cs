using EulerJakumo.Data;
using EulerJakumo.Models;
using Microsoft.AspNetCore.Mvc;

namespace EulerJakumo.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Репозиторий приложения
        /// </summary>
        private IApplicationRepository applicationRepository;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="actionResult">Репозиторий приложения</param>
        public HomeController(IApplicationRepository actionResult)
        {
            this.applicationRepository = actionResult;
        }

        /// <summary>
        /// Страница "О проекте". Запускается по умолчанию
        /// </summary>
        /// <returns>Страница "Home/Index"</returns>
        public IActionResult Index()
        {
            List<TextDesign> aboutProductText = applicationRepository.AboutProductText;
            return View(aboutProductText);
        }
    }
}
