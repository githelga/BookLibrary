using System;

namespace BookLibrary.Models.Common
{
    public abstract class BaseEntity : IKeyEntity, IAuditEntity
    {
        public string Id { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public User CreatedUser { get; set; }
        public User UpdatedUser { get; set; }
        public User DeletedUser { get; set; }
    }
}
