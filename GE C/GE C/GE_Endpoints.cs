using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_C
{
    public class GE_Endpoints
    {
        //
        // Login Endpoint that returns Access-Token
        //
        public string LoginURL()
        {
            return "https://api2.xlink.cn/v2/user_auth";
        }
        //
    // Grabs Device List for Specified User
    //
        public string GetDevicesURL(string user)
        {
            return "https://api2.xlink.cn/v2/user/" + $"{user}" + "/subscribe/devices";
        }
        //
    // Grabs Device Properties for Specified Product
    //
        public string GetPropertiesURL(string productId, string deviceId)
        {
            return "https://api2.xlink.cn/v2/product/" + $"{productId}" + "/device/" + $"{deviceId}" + "/property";
        }
        //
        // Grabs User Information for Specified User
        //
        public string GetUserURL(string user)
        {
            return "https://api2.xlink.cn/v2/user/" + $"{user}";
        }
    }
}
