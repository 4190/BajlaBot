using Discord;
using Discord.Commands;

namespace Uwu
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("test")]
        public async Task TestCommand()
        {
            await ReplyAsync(":D");
        }
    }
}
