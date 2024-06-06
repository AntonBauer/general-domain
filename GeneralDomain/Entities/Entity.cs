namespace GeneralDomain.Entities;

public abstract class Entity<TId, TValue>(TId id) where TId : Id<TValue>
{
  public TId Id => id;
}