﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestApi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICustomerService
    {

        [OperationContract]
        [WebInvoke(Method ="GET",ResponseFormat =WebMessageFormat.Json,BodyStyle =WebMessageBodyStyle.Wrapped,UriTemplate ="GetCustomers")]
        List<Customer> GetCustomerList();
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Customer
    {
       [DataMember]
        public int CustomerID { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Address { get; set; }
    }
}
