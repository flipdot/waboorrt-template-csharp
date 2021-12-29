using Wabooorrt.BotApi;
using System.Collections.Generic;

namespace Wabooorrt;

public interface IBotLogic
{
    IOperation NextAction(Me me, Meta meta, IReadOnlyList<Entity> entities);
}
