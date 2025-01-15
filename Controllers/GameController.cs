using Microsoft.AspNetCore.Mvc;
using Rock_Paper_Scissor_Lizard_Spock.Services;

namespace Rock_Paper_Scissor_Lizard_Spock.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private readonly GameService _gameService;


        public GameController(GameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        [Route("game/{playerChoice}/{opponentChoice}")]
        public string PlayGame(string playerChoice, string opponentChoice)
        {


            if (string.IsNullOrEmpty(playerChoice) || string.IsNullOrEmpty(opponentChoice))
            {
                return "Both player and opponent choices must be provided.";
            }


            return _gameService.PlayGame(playerChoice, opponentChoice);
        }
    }
}