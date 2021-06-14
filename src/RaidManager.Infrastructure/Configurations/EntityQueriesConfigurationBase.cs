namespace RaidManager.Infrastructure.Configurations
{
    public class EntityQueriesConfigurationBase
    {
        public string InsertQuery {get;set;}
        public string DeleteQuery {get;set;}
        public string FindByIdQuery {get;set;}
        public string UpdateQuery {get;set;}
    }
}