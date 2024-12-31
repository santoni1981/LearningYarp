namespace MyYarpTutorial.Shared;

public abstract class EntityBase(Guid uuid) : IEntity
{
    /// <summary>
    /// Gets the unique identifier of the entity.
    /// This value is initialized in the constructor and remains immutable.
    /// </summary>
    public Guid Uuid { get; init; } = uuid;
}