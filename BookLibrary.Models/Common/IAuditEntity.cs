using System;

namespace BookLibrary.Models.Common
{
    public interface IAuditEntity
    {
        DateTime CreatedDateTime { get; set; }
        DateTime? UpdatedDateTime { get; set; }
        DateTime? DeletedDateTime { get; set; }
    }
}