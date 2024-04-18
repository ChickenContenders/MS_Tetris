
// DELETE AFTER GETTING TETRISCONTROLLER SETUP

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;
using GameMicroServer.Services;

namespace Micro
{
    [ApiController]
    [Route("[controller]")]
    public class MicroController : ControllerBase
    {
        private static readonly List<GameInfo> TheInfo = new List<GameInfo>
        {
            //Remove this code once individual microservices are set up 
                
            new GameInfo { 
                Id = 2,
                Title = "Tetris",
                //Content = "~/js/tetris.js",
                Author = "Steve from minecraft",
                DateAdded = "09/09/1541",
                Description = "Block Block Block",
                HowTo = "Put Blocks Down",
                //Thumbnail = "/images/tetris.jpg"
            },

        };

        private readonly ILogger<MicroController> _logger;

        public MicroController(ILogger<MicroController> logger)
        {
            _logger = logger;
        }

        private readonly IGameRepository _gameRepo;
        

        [HttpGet]
        public IEnumerable<GameInfo> Get()
        {
            return TheInfo;
        }
    }
}
