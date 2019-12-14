using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdbockHost
{
    public partial class HostFile : Form
    {
        public HostFile()
        {
            InitializeComponent();
            hostFileContent.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            hostFileContent.ScrollBars = ScrollBars.Vertical;
        }

        private void HostFile_Load(object sender, EventArgs e)
        {

            dynamic OSInfo = Environment.OSVersion;
            string pathpart = "hosts";
            if (OSInfo.Platform == PlatformID.Win32NT)
            {
                //is windows NT
                 pathpart = "system32\\drivers\\etc\\hosts";
            }
            string hostfile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), pathpart);
            Console.WriteLine(hostfile);
            hostFileContent.Lines = File.ReadAllLines(hostfile);
            /*  const string tales = "123.123.123.123 download.talesrunner.com";
              if (!File.ReadAllLines(hostfile).Contains(tales))
              {
                  File.AppendAllLines(hostfile, new String[] { tales
          });
              }*/
        }

        private void hostFileContent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
