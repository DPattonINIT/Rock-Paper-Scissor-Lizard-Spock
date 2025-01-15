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
        
        }

        public string PlayGame(string playerChoice, string opponentChoice)
        {


            GameModel player = null;
            GameModel opponent = null;

            foreach (var choice in _model)
            {
                if (choice.Choice == playerChoice)
                {
                    player = choice;
                    break;
                }
            }

            foreach (var choice in _model)
            {
                if (choice.Choice == opponentChoice)
                {
                    opponent = choice;
                    break;
                }
            }

            if (player == null || opponent == null)
            {
                return "Invalid choice!";
            }

            if (player.Choice == opponent.Choice)
            {
                return "It's a tie!";
            }

            if (player.Beats.Contains(opponent.Choice))
            {
                return $"{player.Choice} beats {opponent.Choice}. You win!";
            }
            else
            {
                return $"{opponent.Choice} beats {player.Choice}. You lose!";
            }
        }
    }
}