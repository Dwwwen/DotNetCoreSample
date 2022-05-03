namespace Sample.Domain.SeedWork;

public class Entity
{
    public virtual string Id { get; set; }

    private List<IDomainEvent> _domainEvents { get; set; }

    public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    protected void AddDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents = _domainEvents ?? new List<IDomainEvent>();
        _domainEvents.Add(domainEvent);
    }

    public void RemoveDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents?.Remove(domainEvent);
    }

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }

    public bool IsTransient()
    {
        return Id == default;
    }

    public override int GetHashCode()
    {
        if (!IsTransient())
            return Id.GetHashCode() ^ 31;
        else
            return base.GetHashCode();
    }

    public override bool Equals(object obj)
    {
        if (!(obj is Entity))
            return false;

        if (object.ReferenceEquals(this, obj))
            return true;

        if (GetType() != obj.GetType())
            return false;

        Entity item = (Entity)obj;

        if (item.IsTransient() || this.IsTransient())
            return false;
        else
            return item.Id == this.Id;
    }

    public static bool operator ==(Entity left, Entity right)
    {
        if (object.Equals(left, null))
            return object.Equals(right, null);
        else
            return left.Equals(right);
    }

    public static bool operator !=(Entity left, Entity right)
    {
        return !(left == right);
    }
}
