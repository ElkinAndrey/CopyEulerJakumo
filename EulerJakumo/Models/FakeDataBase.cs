using EulerJakumo.Data;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Collections.Generic;
using System.Security.Principal;

namespace EulerJakumo.Models
{
    static public class FakeDataBase
    {
        /// <summary>
        /// Таблица с текстом о продукте
        /// </summary>
        static public List<TextDesign> AboutProductText { get; set; } = new List<TextDesign>()
        {
            new TextDesign() { TextStyle = TextStyle.Title,     Text = "О проекте" },
            new TextDesign() { TextStyle = TextStyle.SubTitle,  Text = "Что такое Проект \"Эйлер\"?" },
            new TextDesign() { TextStyle = TextStyle.Paragraph, Text = "Проект \"Эйлер\" — это набор интригующих задач по математике и программированию, для решения которых, однако, недостаточно одной только математической интуиции. Разумеется, математика поможет прийти к красивому и элегантному решению, но для успешного решения большинства задач без навыков программирования не обойтись."},
            new TextDesign() { TextStyle = TextStyle.Paragraph, Text = "Основная мотивация для создания и поддержки проекта - предоставить пытливым умам платформу для погружения в незнакомые области и добавить немного веселья в процесс изучения новых идей."},
            new TextDesign() { TextStyle = TextStyle.LineBreak, Text = "" },
            new TextDesign() { TextStyle = TextStyle.SubTitle,  Text = "Для кого предназначены задачи?" },
            new TextDesign() { TextStyle = TextStyle.Paragraph, Text = "Целевая аудитория проекта включает в себя студентов, которым мало университетского курса, не-математиков, которым, тем не менее, интересна математика, а также профессионалов, которым хотят быть в хорошей математической форме." },
            new TextDesign() { TextStyle = TextStyle.LineBreak, Text = "" },
            new TextDesign() { TextStyle = TextStyle.SubTitle,  Text = "Значит, задачи может решить кто угодно?" },
            new TextDesign() { TextStyle = TextStyle.Paragraph, Text = "Задачи эти разной степени сложности, и большинство их предполагает индуктивное обучение. То есть очередная решённая задача открывает нечто новое, что позволит подобраться к ранее недоступной задаче. Таким образом упорный участник проекта будет медленно, но верно продвигаться по списку задач." },
            new TextDesign() { TextStyle = TextStyle.LineBreak, Text = "" },
            new TextDesign() { TextStyle = TextStyle.SubTitle,  Text = "..." },

        };

        /// <summary>
        /// Таблица с текстом об обратной связи
        /// </summary>
        static public List<TextDesign> FeedbackText { get; set; } = new List<TextDesign>()
        {
            new TextDesign() { TextStyle = TextStyle.Title,     Text = "Обратная связь" },
            new TextDesign() { TextStyle = TextStyle.Paragraph, Text = "Наша форма обратной связи перестала работать. Пишите на почту jakumo.euler@gmail.com" },
            new TextDesign() { TextStyle = TextStyle.LineBreak, Text = "" },
        };

        /// <summary>
        /// Таблица с задачами
        /// </summary>
        static public List<Problem> Problems { get; set; } = new List<Problem>()
        {
            new Problem() { Number = 1, Name = "Числа, кратные 3 или 5", LinkOriginal = "https://projecteuler.net/problem=1", Text = new List<TextDesign>() {
                new TextDesign() { TextStyle = TextStyle.Paragraph, Text = "Если выписать все натуральные числа меньше 10, кратные 3 или 5, то получим 3, 5, 6 и 9. Сумма этих чисел равна 23." },
                new TextDesign() { TextStyle = TextStyle.Paragraph, Text = "Найдите сумму всех чисел меньше 1000, кратных 3 или 5." },
            }},
            new Problem() { Number = 2, Name = "Четные числа Фибоначчи", LinkOriginal = "https://projecteuler.net/problem=2", Text = new List<TextDesign>() {
                new TextDesign() { TextStyle = TextStyle.Paragraph,         Text = "Каждый следующий элемент ряда Фибоначчи получается при сложении двух предыдущих. Начиная с 1 и 2, первые 10 элементов будут:\r\n\r\n" },
                new TextDesign() { TextStyle = TextStyle.ParagraphCenter,   Text = "1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ..." },
                new TextDesign() { TextStyle = TextStyle.Paragraph,         Text = "Найдите сумму всех четных элементов ряда Фибоначчи, которые не превышают четыре миллиона." },
            }},
            new Problem() { Number = 3, Name = "Наибольший простой делитель", LinkOriginal = "https://projecteuler.net/problem=3", Text = new List<TextDesign>() {
                new TextDesign() { TextStyle = TextStyle.Paragraph, Text = "Простые делители числа 13195 - это 5, 7, 13 и 29." },
                new TextDesign() { TextStyle = TextStyle.Paragraph, Text = "Каков самый большой делитель числа 600851475143, являющийся простым числом?" },
            }},
            new Problem() { Number = 4, Name = "Наибольшее произведение-палиндром", LinkOriginal = "https://projecteuler.net/problem=4", Text = new List<TextDesign>() {
                new TextDesign() { TextStyle = TextStyle.Paragraph, Text = "Число-палиндром с обеих сторон (справа налево и слева направо) читается одинаково. Самое большое число-палиндром, полученное умножением двух двузначных чисел – 9009 = 91 × 99." },
                new TextDesign() { TextStyle = TextStyle.Paragraph, Text = "Найдите самый большой палиндром, полученный умножением двух трехзначных чисел." },
            }},
            new Problem() { Number = 5, Name = "Наименьшее кратное", LinkOriginal = "https://projecteuler.net/problem=5", Text = new List<TextDesign>() {
                new TextDesign() { TextStyle = TextStyle.Paragraph, Text = "2520 - самое маленькое число, которое делится без остатка на все числа от 1 до 10." },
                new TextDesign() { TextStyle = TextStyle.Paragraph, Text = "Какое самое маленькое число делится нацело на все числа от 1 до 20?" },
            }},
        };

    }
}
