using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using IBM.WatsonDeveloperCloud.Conversation.v1;
using IBM.WatsonDeveloperCloud.Conversation.v1.Model;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;

namespace ITSupportBot.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {
        public Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);
            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            ConversationService Myconvo = new ConversationService();

            ConversationService convo = new ConversationService("77364591-be8c-4d83-a485-64b3fcebdcee", "aATR3Pmw13x0", "2017-05-26");

            var activity = await result as Activity;

            MessageRequest req = new MessageRequest()
            {
                Input = new InputData()
                {
                    Text = activity.Text
                }
            };
            var reply = convo.Message("21b1a403-54c2-4b80-8b7d-d5e5e2cb813e", req);

            // calculate something for us to return
            int length = (activity.Text ?? string.Empty).Length;
            if (reply.Output.Text[0] == "")
            {
                if(reply.Intents[0].Intent == "NumberOfTickets")
                {

                }
                else if()
                {

                }
                else
                {

                }
                
            }
            else
                await context.PostAsync(reply.Output.Text[0]);
            // return our reply to the user


            context.Wait(MessageReceivedAsync);
        }
    }
}