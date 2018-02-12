namespace BookLibrary.Models.Common
{
    public interface IBaseEntity : IKeyEntity, IAuditEntity
    {
        User CreatedUser { get; set; }
        User UpdatedUser { get; set; }
        User DeletedUser { get; set; }
    }
}
