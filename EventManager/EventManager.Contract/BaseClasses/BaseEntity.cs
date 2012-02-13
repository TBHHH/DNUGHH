using System;

namespace EventManager.Contract.BaseClasses
{
    public abstract class BaseEntity
    {
        public virtual Guid Id { get; set; }
    }
}