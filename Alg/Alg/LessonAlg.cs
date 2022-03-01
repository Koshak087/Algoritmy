using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg
{
    interface LessonAlg
    {
        public string LessonID { get; }

        public string Description { get; set; }

    }
    internal class Lesson1 : LessonAlg
    {
        public string LessonID { get => "1"; }
        public string Description { get => "ДЗ 1. Определение \"простоты\" числа"; }

        private void DoSomeThing()
        {

        }
    }
}
