namespace HRMoneyAPI.Models
{
	public class UserDatabaseSettings : IDatabaseSettingsUser
	{
		public string UserCollectionName { get; set; }
		public string ConnectionString { get; set; }
		public string DatabaseName { get; set; }
	}

	public interface IDatabaseSettingsUser
	{
		string UserCollectionName { get; set; }
		string ConnectionString { get; set; }
		string DatabaseName { get; set; }
	}
}