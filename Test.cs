using Discord.Commands;
using System.Threading.Tasks;

namespace Hourglass_Test
{
    public class Test : ModuleBase<SocketCommandContext>
    {
        [Command("test")]
        public async Task TestAsync()
        {
            await ReplyAsync("Test completed");
        }
    }
}
