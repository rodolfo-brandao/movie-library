using MovieLibrary.Core.Enums;
using MovieLibrary.Core.Models.Abstract;

namespace MovieLibrary.Core.Models;

public class Movie : TrackableEntity
{
    public virtual Guid DirectorId { get; protected internal set; }
    public virtual string Name { get; protected internal set; }
    public virtual string ReleaseYear { get; protected internal set; }
    public virtual Genres Genres { get; protected internal set; }
    public virtual string CountryName { get; protected internal set; }
    public virtual ushort RuntimeInMinutes { get; protected internal set; }

    #region Navigation Properties

    public virtual Director Director { get; protected internal set; }

    #endregion

    public virtual Movie ChangeDirectorId(Guid directorId)
    {
        DirectorId = directorId;
        return this;
    }

    public virtual Movie ChangeName(string name)
    {
        Name = name;
        return this;
    }

    public virtual Movie ChangeReleaseYear(string releaseYear)
    {
        ReleaseYear = releaseYear;
        return this;
    }

    public virtual Movie ChangeCategories(Genres genres)
    {
        Genres = genres;
        return this;
    }

    public virtual Movie ChangeCountryName(string countryName)
    {
        CountryName = countryName;
        return this;
    }

    public virtual Movie ChangeRuntime(ushort runtimeInMinutes)
    {
        RuntimeInMinutes = runtimeInMinutes;
        return this;
    }

    public override TrackableEntity Disable()
    {
        IsDisabled = true;
        return this;
    }

    public override TrackableEntity Enable()
    {
        IsDisabled = default;
        return this;
    }

    public override TrackableEntity UpdatedNow()
    {
        UpdatedOn = DateTime.UtcNow;
        return this;
    }
}
