using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using System;
using System.Threading.Tasks;

namespace LuisBot101.Dialogs
{
    [LuisModel("modelID", "subscriptionID")]
    [Serializable]
    public class LuisDialog : LuisDialog<object>
    {
        [LuisIntent("None")]
        [LuisIntent("")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("None Intent Detected");
            context.Wait(this.MessageReceived);
        }
        
        [LuisIntent("Reminder.Find")]
        public async Task ReminderFind(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Reminder.Find Intent Detected");
            context.Wait(this.MessageReceived);
        }

        
        [LuisIntent("Reminder.Create")]
        public async Task ReminderCreate(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Reminder.Create Intent Detected");
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("Places.GetRoute")]
        public async Task PlacesGetRoute(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Places.GetRoute Intent Detected");
            context.Wait(this.MessageReceived);
        }

    }
}