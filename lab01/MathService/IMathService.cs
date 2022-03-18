using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MathService
{
    [ServiceContract]
    public interface IMathService
    {
        [OperationContract]
        int Add(MyNumbers obj);

        [OperationContract]
        int Substract(MyNumbers obj);
    }


    [DataContract]
    public class MyNumbers
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public int Number1 { get; set; }

        [DataMember]
        public int Number2 { get; set; }
    }
}
