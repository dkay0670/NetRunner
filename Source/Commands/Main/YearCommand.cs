using System;
using System.Threading.Tasks;

using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;

using WinBot.Commands.Attributes;

namespace WinBot.Commands.Main
{
    public class YearCommand : BaseCommandModule
    {
        [Command("YearCommand")]
        [Description("Gets the remaining time in the year")]
        [Category(Category.Fun)]
        public async Task Year(CommandContext Context)
        {
            var timeSpan = new DateTime(DateTime.Now.Year + 1, 1, 1).Subtract(DateTime.Now);
            await Context.ReplyAsync($"There are {Math.Round((double)timeSpan.TotalDays,2)} days left in 2022. That's {Math.Round((double)timeSpan.TotalHours,2)} hours, {Math.Round((double)timeSpan.TotalMinutes,2)} minutes, or {Math.Round((double)timeSpan.TotalSeconds,2)} seconds.");
        }
    }
}
