using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rssdp;

namespace OCSheet
{
    public class Controller
    {

        private SsdpDevicePublisher _Publisher;

        public Controller()
        {
            _Publisher = new SsdpDevicePublisher();
            var deviceDefinition = new SsdpRootDevice()
            {
                CacheLifetime = TimeSpan.FromMinutes(30), //How long SSDP clients can cache this info.
                Location = new Uri("http://mydevice/descriptiondocument.xml"), // Must point to the URL that serves your devices UPnP description document. 
                DeviceTypeNamespace = "my-namespace",
                DeviceType = "MyCustomDevice",
                FriendlyName = "Custom Device 1",
                Manufacturer = "Me",
                ModelName = "MyCustomDevice",
                Uuid = "Andrew-PC" // This must be a globally unique value that survives reboots etc. Get from storage or embedded hardware etc.
            };
            _Publisher.AddDevice(deviceDefinition);
        }


    }
}
