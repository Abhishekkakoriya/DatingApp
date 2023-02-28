namespace API.Entities
{
    public class UserLike
    {
        public AppUser SourceUser { get; set; }
        public int SourceUSerId { get; set; }
        public AppUser TargetUser { get; set; }
        public int TargetUserId { get; set; }
    }
}