
using Test_3_QuizGame.Models;

Console.WriteLine("-- Quiz Game --");

var questions = new List<Question>();
var answers = new List<Answer>();
string playerName;
string? wanToPlay;


StartGame();

void StartGame()
{
    GetPlayerName();
    WantToPlay();
}

void GetPlayerName()
{
    try
    {
        Console.WriteLine("Hey!, What's your name?");
        playerName = Console.ReadLine();

        if (playerName == null)
        {
            throw new InvalidOperationException("Nombre no valido");
        }
    }
    catch (Exception e) {
        Console.WriteLine("Ha ocurrido un error: -"+e.Message);
        GetPlayerName();
    }
}

void WantToPlay()
{
    Console.WriteLine($"Nice!,{playerName} do you want to play a game? Yes/No");
    string Answer = Console.ReadLine();

    switch (Answer?.ToLower())
    {
        case "yes":
            Play();
            break;
        case "no":
            NoPlay();
            break;
        default:
            Console.WriteLine("Please write Yes or No");
            WantToPlay();
            break;
    }

}
void Play()
{
    Console.WriteLine("Let's play!");
    SeedQuestionAndOptions();
    PrintQuestions();
}

void NoPlay()
{
    Console.WriteLine("Ok, see you!");
}

void PrintQuestions()
{
    foreach (var question in questions)
    {
        Console.WriteLine($"{question.Id}- {question.QuestionText}.");
        foreach (var option in question.Options)
        {
            Console.WriteLine($"    {option.id}. {option.Text}.");
        }
        GetAnswers(question.Id, question.Options);
    }
}

void GetAnswers(int questionId, List<Option> options)
{
    string[] validOptions = { "1", "2", "3", "4" };
    Console.WriteLine("Please, enter 1, 2 ,3 or 4");
    var answer = Console.ReadLine();
    if (!validOptions.Contains(answer)) 
    {
        GetAnswers(questionId, options);
        return;
    }
    answers.Add(new Answer
    {
        QuestionId = questionId,
        SelectedOption = options.Find(opt => opt.id == int.Parse(answer)),
    });

}

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


