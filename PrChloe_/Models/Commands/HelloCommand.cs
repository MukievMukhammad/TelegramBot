using Telegram.Bot;
using Telegram.Bot.Types;

namespace PrChloe_.Models.Commands
{
    public class HelloCommand : Command
    {
        public override string Name => "start";
        public override async void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;
            
            //TODO: Bot logic

            using (var db = new ApplicationContext())
            {
                // Crate new User Profile
                var user = new PrChloe_.Models.Components.User
                {
                    FirstName = message.Chat.FirstName,
                    LastName = message.Chat.LastName
                };

                // Add user to database
                db.Users.Add(user);
                db.SaveChanges();
            }

            await client.SendTextMessageAsync(
                chatId, 
                string.Format(
                    "Hello {0}, welcome to PrChloeMedia. Your account has been created successfully!", 
                    message.Chat.FirstName), 
                replyToMessageId: messageId);
        }
    }
}