using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrChloe_.Models.Commands;
using Telegram.Bot;

namespace PrChloe_.Models
{
    public class Bot
    {
        private static TelegramBotClient client;
        private static List<Command> commands = new List<Command>();
        
        public static IReadOnlyList<Command> Commands => commands.AsReadOnly();

        public static async Task<TelegramBotClient> Get()
        {
            if (client != null) return client;

            var startCommand = new HelloCommand();
            commands.Add(startCommand);
            // TODO: Add more commands
            
            client = new TelegramBotClient(AppSettings.Key);
            var hook = string.Format(AppSettings.Url, "api/message/update");
            await client.SetWebhookAsync(hook);

            return client;
        }
    }
}