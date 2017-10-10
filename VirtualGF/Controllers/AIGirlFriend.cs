using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using System.Net.Http;

namespace VirtualGF

{
    [LuisModel("66c5a941-7c0a-4ef0-bd82-70a76c0c1212", "7d03345f948f432185683f9ca5a51528")]
    [Serializable]
    public class AIGirlFriend : LuisDialog<object>
    {

        [LuisIntent("")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            string message = $"给你一个么么哒~";
            await context.PostAsync(message);
            context.Wait(MessageReceived);
        }

        [LuisIntent("关怀")]
        public async Task Care(IDialogContext context, LuisResult result)
        {
            string message = $"好的呢，谢谢！";
            await context.PostAsync(message);
            context.Wait(MessageReceived);
        }

        [LuisIntent("夸赞")]
        public async Task Praise(IDialogContext context, LuisResult result)
        {
            string message = $"嘻嘻，你这么说人家会害羞的！";
            await context.PostAsync(message);
            context.Wait(MessageReceived);
        }

        [LuisIntent("表白")]
        public async Task confession(IDialogContext context, LuisResult result)
        {
            string message = $"真的吗(づ｡◕‿‿◕｡)づ人家也喜欢你很久了呢，我们在一起吧~要抱抱亲亲举高高(づ￣ 3￣)づ";
            await context.PostAsync(message);
            context.Wait(MessageReceived);
        }

        [LuisIntent("讲述")]
        public async Task Telling(IDialogContext context, LuisResult result)
        {
            string message = $"哇塞，好棒！";
            await context.PostAsync(message);
            context.Wait(MessageReceived);
        }

        [LuisIntent("询问")]
        public async Task Ask(IDialogContext context, LuisResult result)
        {
            string message = $"要亲我一下才告诉你~";
            await context.PostAsync(message);
            context.Wait(MessageReceived);
        }

        [LuisIntent("问候")]
        public async Task SayHi(IDialogContext context, LuisResult result)
        {
            string message = $"我在的呢~";
            await context.PostAsync(message);
            context.Wait(MessageReceived);
        }
    }
}