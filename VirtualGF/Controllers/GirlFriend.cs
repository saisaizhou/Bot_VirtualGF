using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace VirtualGF
{
    [Serializable]
    public class GirlFriend : IDialog<object>
    {
        public Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);

            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var activity = await result as Activity;

            // calculate something for us to return
            int length = (activity.Text ?? string.Empty).Length;

            switch(activity.Text.ToString())
            {
                case "女神，在么？":
                    await context.PostAsync("干嘛？");
                    break;
                case "要不要一起去？":
                    await context.PostAsync("不去，我要去洗澡了。");
                    break;
                default :
                    await context.PostAsync("呵呵");
                    break;
            }

            context.Wait(MessageReceivedAsync);
        }
    }
}