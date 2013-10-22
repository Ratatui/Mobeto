
namespace Mobeto.WcfService
{
	public class MobetoService : IMobetoService
	{
		public Person GetData(string id)
		{
			return new Person();
		}

		public class Person
		{
			public int id;
			public string name;
		}
	}
}