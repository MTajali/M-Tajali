using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionAndExam
{
    class Exam : IEnumerable
    {
       
        public string ExamName { get; set; }
        public int Time { get; set; }
        public int QuestCount { get; set; }
        public string Teacher { get; set; }
        public List<Question> questions { get; set; }
 
       
       

        
       

        public IEnumerator GetEnumerator()
        {
            return this.questions.GetEnumerator();
        }
    }
}

