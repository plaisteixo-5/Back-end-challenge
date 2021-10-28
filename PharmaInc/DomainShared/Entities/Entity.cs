using System;

namespace DomainShared.Entities
{
    public class Entity
    {
        public Entity(string name, string value)
        {
            Id = Guid.NewGuid();
            Name = name;
            Value = value;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}