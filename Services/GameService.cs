using Rock_Paper_Scissor_Lizard_Spock.Models;

namespace Rock_Paper_Scissor_Lizard_Spock.Services
{
    public class GameService
    {
        private List<GameModel> _model;
        private Random _random;

        public GameService()
        {
            _model = new List<GameModel>
            {
                new GameModel { Choice = "Rock", Beats = new List<string> { "Scissors", "Lizard" } },
                new GameModel { Choice = "Paper", Beats = new List<string> { "Rock", "Spock" } },
                new GameModel { Choice = "Scissors", Beats = new List<string> { "Paper", "Lizard" } },
                new GameModel { Choice = "Lizard", Beats = new List<string> { "Spock", "Paper" } },
                new GameModel { Choice = "Spock", Beats = new List<string> { "Scissors", "Rock" } }
            };
            _random = new Random();
        }


        public string GetComputerChoice(string playerChoice)
        {
            int randomIndex = _random.Next(_model.Count);
            string computerChoice = _model[randomIndex].Choice;

            return computerChoice;
        }
    }
}
