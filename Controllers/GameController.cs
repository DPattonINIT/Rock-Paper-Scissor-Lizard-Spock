using Microsoft.AspNetCore.Mvc;
using Rock_Paper_Scissor_Lizard_Spock.Services;

namespace Rock_Paper_Scissor_Lizard_Spock.Controllers
{
    [Route("api/game")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly GameService _gameService;

        public GameController(GameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet("computer/{playerChoice}")]
        public ActionResult<string> GetComputerChoice(string playerChoice)
        {
            string computerChoice = _gameService.GetComputerChoice(playerChoice);
            return Ok(computerChoice);
        }
    }
}