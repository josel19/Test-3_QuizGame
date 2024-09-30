
using Test_3_QuizGame.Models;

Console.WriteLine("-- Quiz Game --");

var questions = new List<Question>();

SeedQuestionAndOptions();

void SeedQuestionAndOptions(){

    questions.Add(new Question
    {
        Id = 1,
        QuestionText = "What is the biggest country on earth?",
        Options = new List<Option>
        {
            new Option {id = 1, Text = "Australia" },
            new Option {id = 2, Text = "China" },
            new Option {id = 3, Text = "Canada"},
            new Option {id = 4, Text = "Russia", Isvalid = true } 
        }
    });

    questions.Add(new Question
    {
        Id = 2,
        QuestionText = "What is the country on with the greatest population in 2024??",
        Options = new List<Option>
        {
            new Option {id = 1, Text = "India" },
            new Option {id = 2, Text = "China", Isvalid = true },
            new Option {id = 3, Text = "USA"},
            new Option {id = 4, Text = "Brasil" }
        }
    });

    questions.Add(new Question
    {
        Id = 3,
        QuestionText = "What was the less corrupt country in the world in 2024?",
        Options = new List<Option>
        {
            new Option {id = 1, Text = "Finlad" },
            new Option {id = 2, Text = "New Zealand"},
            new Option {id = 3, Text = "Denmark", Isvalid = true},
            new Option {id = 4, Text = "Norway" }
        }
    });

    questions.Add(new Question
    {
        Id = 4,
        QuestionText = "What was the best country for quality of life in 2024?",
        Options = new List<Option>
        {
            new Option {id = 1, Text = "Norway", Isvalid = true  },
            new Option {id = 2, Text = "Belgium" },
            new Option {id = 3, Text = "Sweden" },
            new Option {id = 4, Text = "Switzerland" }
        }
    });

}


