using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskQuiz.Shared
{
    internal class Course
    {
        //[Key]
        //public int CourseId { get; set; }
        public int Id { get; set; }

        public string Name { get; set; }
        public int Stdid { get; set; }
        public int StdMarks { get; set; }
    }
}
