using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fetch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        System.Net.WebClient web = null;
        private void butFetch_Click(object sender, EventArgs e)
        {
            string html = String.Empty;
            try
            {
                web = new System.Net.WebClient();
                web.DownloadStringCompleted += new System.Net.DownloadStringCompletedEventHandler(web_DownloadStringCompleted);
                Uri uri = new Uri("https://swgoh.gg/u/tsitas_66/collection/237/grand-admiral-thrawn/");
                web.DownloadStringAsync(uri);
            }
            catch
            {
            }
        }
        void web_DownloadStringCompleted(object sender, System.Net.DownloadStringCompletedEventArgs e)
        {
            if (e.Error != null)
            {
            }
            else
            {
                string html = e.Result;
                int index = html.IndexOf("<h5>General</h5>", html.Length / 2);
                if (index != -1)
                {
                    string retver = html.Substring(index);
                    string health = "";
                    for (int i = 17; i < 160; i++)
                    {
                        if (char.IsNumber(retver[i]))
                        {
                            health += retver[i];
                        }
                    }

                    index = retver.IndexOf("Health");
                    if (index != -1)
                    {
                        retver = retver.Substring(index);
                        string protection = "";
                        for (int i = 0; i < 150; i++)
                        {
                            if (char.IsNumber(retver[i]))
                            {
                                protection += retver[i];
                            }
                        }
                        MessageBox.Show("Health:" + health + "\r\nProtection:" + protection);
                    }


                }
            }
        }
    }
}
