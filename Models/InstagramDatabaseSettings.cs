namespace HRMoneyAPI.Models
{
	public class InstagramDatabaseSettings : IDatabaseSettingsInstagram
	{
		public string InstagramCollectionName { get; set; }
		public string ConnectionString { get; set; }
		public string DatabaseName { get; set; }
	}

	public interface IDatabaseSettingsInstagram
	{
		string InstagramCollectionName { get; set; }
		string ConnectionString { get; set; }
		string DatabaseName { get; set; }
	}
}