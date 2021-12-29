using System.Text.Json.Serialization;

namespace Wabooorrt.BotApi;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Direction
{
    North,
    East,
    South,
    West,
}

public interface IOperation
{
    string Name { get; }
}

public record NoOp : IOperation
{
    public string Name { get; } = "NOOP";
}

public record ChargeOp : IOperation
{
    public string Name { get; } = "CHARGE";
}

public record WalkOp(Direction? Direction) : IOperation
{
    public string Name { get; } = "WALK";
}

public record ThrowOp(int? X, int? Y) : IOperation
{
    public string Name { get; } = "THROW";
}

public record LookOp(double? Range) : IOperation
{
    public string Name { get; init; } = "LOOK";
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum EntityType
{
    Bot,
}

public record Me(
    int X,
    int Y,
    int Energy,
    int Health,
    string? Name,
    [property: JsonPropertyName("view_range")]
    double ViewRange
);

public record Meta(
    int W,
    int H,
    int Tick
);

public record Entity(
    int X,
    int Y,
    EntityType? Type
);
