namespace HRMoneyAPI.Models
{
	public class VersaoDatabaseSettings : IDatabaseSettingsVersao
	{
		public string UserCollectionName { get; set; }
		public string ConnectionString { get; set; }
		public string DatabaseName { get; set; }
	}

	public interface IDatabaseSettingsVersao
	{
		string UserCollectionName { get; set; }
		string ConnectionString { get; set; }
		string DatabaseName { get; set; }
	}
}