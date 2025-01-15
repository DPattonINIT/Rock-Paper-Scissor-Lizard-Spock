using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rock_Paper_Scissor_Lizard_Spock.Models
{
    public class GameModel
    {
        public string? Choice {get; set;}
        public List<string>? Beats {get; set;}
    }
}