using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieLibrary.Core.Models;

namespace MovieLibrary.Data.EntityTypeConfigurations;

public class MovieEntityTypeConfiguration : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder.ToTable("movie");

        builder.HasKey(movie => movie.Id);

        builder.Property(movie => movie.Id)
            .HasColumnName("id")
            .HasColumnType("UNIQUEIDENTIFIER")
            .IsRequired();

        builder.Property(movie => movie.Director)
            .HasColumnName("director_id")
            .HasColumnType("UNIQUEIDENTIFIER")
            .IsRequired();

        builder.Property(movie => movie.CountryId)
            .HasColumnName("country_id")
            .HasColumnType("UNIQUEIDENTIFIER")
            .IsRequired();

        builder.Property(movie => movie.EnglishName)
            .HasColumnName("english_name")
            .HasColumnType("VARCHAR(255)")
            .IsRequired();

        builder.Property(movie => movie.OriginalName)
            .HasColumnName("original_name")
            .HasColumnType("VARCHAR(255)")
            .IsRequired(required: default);

        builder.Property(movie => movie.ReleaseYear)
            .HasColumnName("release_year")
            .HasColumnType("CHAR(4)")
            .IsRequired();

        builder.Property(movie => movie.RuntimeInMinutes)
            .HasColumnName("runtime_in_minutes")
            .HasColumnType("SMALLINT")
            .IsRequired();

        builder.Property(movie => movie.Genres)
            .HasColumnName("genres")
            .HasColumnType("SMALLINT")
            .IsRequired();

        builder.Property(movie => movie.CreatedOn)
            .HasColumnName("created_on")
            .HasColumnType("DATETIME2")
            .IsRequired();

        builder.Property(movie => movie.UpdatedOn)
            .HasColumnName("updated_on")
            .HasColumnType("DATETIME2")
            .IsRequired(required: default);

        builder.Property(movie => movie.IsDisabled)
            .HasColumnName("is_disabled")
            .HasColumnType("BIT")
            .IsRequired();
    }
}
