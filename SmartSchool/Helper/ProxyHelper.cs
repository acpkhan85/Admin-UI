
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace SmartSchool.Helper
{     
    public class WCFProxy
    {
        public static void Using<T>(Action<T> action)
        {
            BasicHttpBinding bindnig = new BasicHttpBinding();
            string endpointUri = GetServiceEndpoint(typeof(T));
            ChannelFactory<T> factory = new ChannelFactory<T>(bindnig, new EndpointAddress(new Uri(endpointUri)));

            //ChannelFactory<T> factory = new ChannelFactory<T>("*");

            T client = factory.CreateChannel();

            try
            {
                action(client);
                ((IClientChannel)client).Close();
                factory.Close();
            }
            catch (Exception ex)
            {
                IClientChannel clientInstance = ((IClientChannel)client);
                if (clientInstance.State == System.ServiceModel.CommunicationState.Faulted)

                {
                    clientInstance.Abort();
                    factory.Abort();
                }
                else if (clientInstance.State != System.ServiceModel.CommunicationState.Closed)
                {
                    clientInstance.Close();
                    factory.Close();
                }
                throw (ex);
            }
        }
        private static string GetServiceEndpoint(Type service)
        {

            string serviceTypeName = service.Name;
            //We will configure this from Config file
            switch (serviceTypeName)
            {
                case "IUserService":
                    serviceTypeName = "http://localhost:17219/UserService.svc";
                    break;
                case "IEventsAndNewsService":
                    serviceTypeName = "http://localhost:17219/EventsAndNewsService.svc";
                    break;
                case "IClassSetupService":
                    serviceTypeName = "http://localhost:17219/ClassSetupService.svc";
                    break;
                case "IAboutService":
                    serviceTypeName = "http://localhost:17219/AboutService.svc";
                    break;
                case "IDashboardService":
                    serviceTypeName = "http://localhost:17219/DashboardService.svc";
                    break;
            }

            return serviceTypeName;

        }
    }
}