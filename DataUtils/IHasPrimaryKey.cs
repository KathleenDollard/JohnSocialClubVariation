namespace DataUtils 
{
    public interface IHasPrimaryKey<TKey>
    {
        TKey Id { get; set; }
    }
}