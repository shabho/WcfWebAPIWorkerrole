using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;



namespace WorkerRole1.Contract
{
    [ServiceContract]

    public interface IproductsService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/Products/Getall", ResponseFormat = WebMessageFormat.Json)]
        ProductData[] Getall();
    }
}
