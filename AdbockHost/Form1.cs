namespace AdbockHost
{
    using AdbockHost.Client;
    using AdbockHost.Model;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="Blocker" />
    /// </summary>
    public partial class Blocker : Form
    {
        /// <summary>
        /// Defines the urls
        /// </summary>
        internal List<String> urls = new List<String>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Blocker"/> class.
        /// </summary>
        public Blocker()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The Blocker_Load
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void Blocker_Load(object sender, EventArgs e)
        {
            ReadFileBlocker hosts = new ReadFileBlocker();
            List<String> list = new List<String>();
            hosts.GetHosts().ForEach(delegate (Host host)
            {
                urls.Add(host.Url);
                list.Add(host.Name);
            });
            hostsList.SelectionMode = SelectionMode.MultiExtended;
            hostsList.DataSource = list;
        }

        /// <summary>
        /// The button2_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        [STAThread]
        private void button2_Click(object sender, EventArgs e)
        {

            HostFile hostFileForm = new HostFile();
            hostFileForm.Show();
        }

        /// <summary>
        /// The setHosts_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private async void setHosts_Click(object sender, EventArgs e)
        {
            string filePath  = "test.txt";
            string domainBlockerPattern = "#=========== DOMAIN BLOCKER =====================================";
            string[] lines = File.ReadAllLines(filePath);

            progressWrite.Maximum = lines.Length;
            progressWrite.Value = 0; 
            int numberline =0;
            List<String> backupLines = new List<String>();  
            foreach (string line in new List<string>(lines))
            {
              
                if (line != domainBlockerPattern)
                {
                    backupLines.Add(line);
                  
                }
                else
                {
                    break;
                }
                progressWrite.Value += 1;
              
              numberline++;
            }
            backupLines.Add(domainBlockerPattern); 
           
            for (int x = 0; x < hostsList.Items.Count; x++)
            {
                if (hostsList.GetSelected(x) == true)
                { progressWrite.Value = 0;
                    string domainsResponse = await Task.FromResult<string>(await DownloadHost.GetDomains(urls[x].ToString()));
                   
                    string[] linesDomains = Regex.Split(domainsResponse, "\r\n|\r|\n");
                   
                    progressWrite.Maximum = linesDomains.Length;
                    for (var i = 0; i < linesDomains.Length; i++)
                    {
                        if (!backupLines.Contains(linesDomains[i].Trim())) {
                            backupLines.Add(linesDomains[i].Trim());
                        Console.WriteLine(linesDomains[i]);
                        }
                        progressWrite.Value++;
                        setHosts.Enabled = false;
                    }

                }
                hostsList.SetSelected(x, false);
            }
            setHosts.Enabled = true;
            File.WriteAllLines(filePath, backupLines);
            Console.WriteLine(backupLines.Count);
        }
    }
}
