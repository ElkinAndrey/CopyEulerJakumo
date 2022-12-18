using EulerJakumo.Data;
using EulerJakumo.Models;
using EulerJakumo.Models.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;

namespace EulerJakumo.Controllers
{
    /// <summary>
    /// Контроллер главной страницы
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Количество задач на одной странице
        /// </summary>
        private int pageSize = 2;

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
        /// <returns>Страница "AboutProject"</returns>
        public IActionResult AboutProject()
        {
            ViewBag.Action = "AboutProject";
            List<TextDesign> aboutProductText = applicationRepository.AboutProductText;
            return View(aboutProductText);
        }

        /// <summary>
        /// Страница "Обратная связь".
        /// </summary>
        /// <returns>Страница "Feedback"</returns>
        public IActionResult Feedback()
        {
            ViewBag.Action = "Feedback";
            List<TextDesign> feedbackText = applicationRepository.FeedbackText;
            return View(feedbackText);
        }

        /// <summary>
        /// Страница с задачами
        /// </summary>
        /// <param name="page">Номер страницы</param>
        /// <returns>Страница "Problems"</returns>
        public IActionResult Problems(int page = 1)
        {
            ViewBag.Action = "Problems";
            ProblemsPageViewModel model = new ProblemsPageViewModel()
            {
                Problems = applicationRepository.PartProblems((page - 1) * pageSize, pageSize),
                AmountPages = (applicationRepository.ProblemsLength - 1) / pageSize + 1,
                ProblemsLength = applicationRepository.ProblemsLength,
                NowPage = page,
            };
            return View(model);
        }

        /// <summary>
        /// Страница с задачей
        /// </summary>
        /// <param name="number">Номер задачи</param>
        /// <returns>Страница "Problems/НомерПроблемы
        /// "</returns>
        public IActionResult Problem(int number)
        {
            ViewBag.Action = "Problems";
            Problem? problem = applicationRepository.ProblemByNumber(number);
            if (problem == null)
            {
                return RedirectToAction("Denied");
            }
            return View(problem);
        }

        /// <summary>
        /// Страница, которая появиться, если попытаться перейти к несуществующей странице
        /// </summary>
        /// <returns>Страница "Denied"</returns>
        public IActionResult Denied()
        {
            ViewBag.Action = "Problems";
            return View();
        }
    }
}
