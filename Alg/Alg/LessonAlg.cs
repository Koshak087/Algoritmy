using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg
{
    internal interface LessonAlg
    {
        string LessonID { get; }

        string Description { get; set; }

        void Demo();
    }
    internal class Lesson1 : LessonAlg
    {
        public string LessonID { get => "1"; }

        public string Description { get => "ДЗ 1. Определение \"простоты\" числа"; }
        string LessonAlg.Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Demo()
        {
            Console.WriteLine("Начало задания 1");
            DoSomeThing();
            Console.WriteLine("Конец задания 1");
        }

        private void DoSomeThing()
        {
            Console.WriteLine("Здесь основная логика ДЗ");
        }
    }
}
