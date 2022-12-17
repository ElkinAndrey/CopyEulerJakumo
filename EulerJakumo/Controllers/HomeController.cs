using EulerJakumo.Data;
using EulerJakumo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        /// <returns>Страница "Index"</returns>
        public IActionResult Index()
        {
            List<TextDesign> aboutProductText = applicationRepository.AboutProductText;
            return View(aboutProductText);
        }

        /// <summary>
        /// Страница "Обратная связь".
        /// </summary>
        /// <returns>Страница "Feedback"</returns>
        public IActionResult Feedback()
        {
            List<TextDesign> feedbackText = applicationRepository.FeedbackText;
            return View(feedbackText);
        }

        /// <summary>
        /// Страница с задачами
        /// </summary>
        /// <returns>Страница "Problems"</returns>
        public IActionResult Problems()
        {
            List<Problem> tasks = applicationRepository.Problems;
            return View(tasks);
        }

        /// <summary>
        /// Страница с задачей
        /// </summary>
        /// <param name="number">Номер задачи</param>
        /// <returns>Страница "Problems/НомерПроблемы
        /// "</returns>
        public IActionResult Problem(int number)
        {
            Problem? problem = applicationRepository.ProblemByNumber(number);
            return View(problem);
        }
    }
}
