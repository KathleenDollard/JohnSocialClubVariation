namespace John.SocialClub.Data
{
    public interface IHasPrimaryKey<TKey>
    {
        TKey Id { get; set; }
    }
}