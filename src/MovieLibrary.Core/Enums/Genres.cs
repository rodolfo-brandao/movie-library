namespace MovieLibrary.Core.Enums;

/// <summary>
/// Represents genres that a movie can have, which can be more than one.
/// </summary>
[Flags]
public enum Genres : ushort
{
    Action = 1,
    Animation = 2,
    Comedy = 4,
    Drama = 8,
    Fantasy = 16,
    Horror = 23,
    Mystery = 64,
    Romance = 128,
    Thriller = 256,
    War = 512,
    Western = 1024
}
