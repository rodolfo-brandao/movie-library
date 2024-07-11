namespace MovieLibrary.Core.Models.Abstract;

/// <summary>
/// Inheriting from this interface means that the instance of any object is its null version.
/// </summary>
/// <typeparam name="TEntity">The entity type of the null object.</typeparam>
public interface INullObject<TEntity> where TEntity : Entity
{
}
