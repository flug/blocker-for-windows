using AdbockHost.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AdbockHost
{
    class ReadFileBlocker
    {
        List<Host> hosts = JsonConvert.DeserializeObject<List<Host>>(File.ReadAllText(Application.StartupPath + "/hostList.json"));
 

        public List<Host> GetHosts() {
            return hosts;
        }
    }
}
