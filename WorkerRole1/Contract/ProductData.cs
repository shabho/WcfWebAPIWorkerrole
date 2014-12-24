using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;


namespace WorkerRole1.Contract
{
    
    [DataContract]
    public class ProductData
    {
        [DataMember]
        public string SKU { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}
