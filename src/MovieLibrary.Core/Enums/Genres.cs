namespace MovieLibrary.Core.Enums;

/// <summary>
/// Represents genres that a movie can have, which can be more than one.
/// </summary>
[Flags]
public enum Genres : ushort
{
    Action = 1,
    Comedy = 2,
    Drama = 4,
    Fantasy = 8,
    Horror = 16,
    Mystery = 32,
    Romance = 64,
    Thriller = 128,
    Western = 256
}
