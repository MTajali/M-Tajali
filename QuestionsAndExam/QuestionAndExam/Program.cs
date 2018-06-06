using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionAndExam
{
    class Program
    {
        static void Main(string[] args)

        {
            Exam exam = new Exam();
            var questions = new List<Question>();
            questions.Add(new Question() { Subject = "c#", Questfase = "What is your name?", Dificultly =Dificultly.Easy , Mark = 1.5, Time =7  });
            questions.Add(new Question() { Subject = "html", Questfase = "how are you?", Dificultly =Dificultly.Hard , Mark = 2, Time = 5 });
            questions.Add(new Question() { Subject = "java", Questfase = "where are you from?", Dificultly = Dificultly.Normal, Mark = 4, Time = 10 });

            //questions.Sort(new QuestionTime());
            //questions.Sort(new QuestionSubject());
            //questions.Sort(new QuestionMark());
            // questions.Sort(new QuestionDificultly());


            //foreach (var question in questions)
            //{
            //    Console.WriteLine(question);
            //    Console.WriteLine("----------------------------------------------");
            //}

            foreach (Question q in exam)
            {
                Console.WriteLine(q.Subject);
            }

            Console.ReadKey();
        }
    }
}
