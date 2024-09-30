using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_3_QuizGame.Models
{
    public class Answer
    {
        public int QuestionId { get; set; }

        public Option SelectedOption { get; set; }
    }
}
