using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrChloe_.Models;
using Telegram.Bot.Types;

namespace PrChloe_.Controllers
{
    [ApiController]
    public class MessageController : ControllerBase
    {
        [Route(@"api/message/update")]
        public async Task<OkResult> Update([FromBody]Update update)
        {
            var commands = Bot.Commands;
            var message  = update.Message;
            var client   = await Bot.Get();

            foreach (var command in commands)
            {
                if (command.Contains(message.Text))
                {
                    command.Execute(message, client);
                    break;
                }
            }

            return Ok();
        }
    }
}