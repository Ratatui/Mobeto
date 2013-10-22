using System.ServiceModel;
using System.ServiceModel.Web;

namespace Mobeto.WcfService
{
	[ServiceContract]
	public interface IMobetoService
	{
		[OperationContract]
		[WebInvoke(Method = "GET",
			BodyStyle = WebMessageBodyStyle.WrappedRequest,
			ResponseFormat = WebMessageFormat.Json,
			UriTemplate = "/data/{id}")]
		Mobeto.WcfService.MobetoService.Person GetData(string id);
	}
}