﻿namespace EulerJakumo.Data
{
    /// <summary>
    /// Задача
    /// </summary>
    public class Task
    {
        /// <summary>
        /// Номер задачи
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Название задачи
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Ссылка на оригинал задачи
        /// </summary>
        public string? LinkOriginal { get; set; }

        /// <summary>
        /// Текст задачи
        /// </summary>
        public List<TextDesign>? Text { get; set; }
    }
}
