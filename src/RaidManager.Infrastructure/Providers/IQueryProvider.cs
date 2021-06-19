namespace RaidManager.Infrastructure.Providers
{
    public interface IQueryProvider
    {
        string GetQuery(string queryName);
    }
}