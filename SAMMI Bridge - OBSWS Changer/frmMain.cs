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

namespace SAMMI_Bridge___OBSWS_Changer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBridge_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.Title = @"Please select your bridge.html in your SAMMI folder";
                f.Filter = "SAMMI Bridge|bridge.html";

                if (f.ShowDialog() == DialogResult.OK)
                {
                    txtBridge.Text = f.FileName;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtBridge.Text = Properties.Settings.Default.BridgePath;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.BridgePath = txtBridge.Text;
            Properties.Settings.Default.Save();
        }

        private void txtBridge_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(txtBridge.Text))
            {
                using (StreamReader sr = new StreamReader(txtBridge.Text))
                {
                    string sBridge = sr.ReadToEnd();
                    sr.Close();

                    if (sBridge.Contains("<script src=\"https://cdn.jsdelivr.net/npm/obs-websocket-js@4.0.2/dist/obs-websocket.js\"></script>")) cbOBSWS.SelectedIndex = 0;
                    if (sBridge.Contains("<script src=\"https://cdn.jsdelivr.net/npm/obs-websocket-js\"></script>")) cbOBSWS.SelectedIndex = 1;
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtBridge.Text))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(txtBridge.Text))
                    {
                        string sBridge = sr.ReadToEnd();
                        sr.Close();

                        if (cbOBSWS.SelectedIndex == 1 && sBridge.Contains("<script src=\"https://cdn.jsdelivr.net/npm/obs-websocket-js@4.0.2/dist/obs-websocket.js\"></script>"))
                        {
                            using (StreamWriter sw = new StreamWriter(txtBridge.Text))
                            {
                                sw.Write(sBridge.Replace("<script src=\"https://cdn.jsdelivr.net/npm/obs-websocket-js@4.0.2/dist/obs-websocket.js\"></script>", "<script src=\"https://cdn.jsdelivr.net/npm/obs-websocket-js\"></script>"));
                                sw.Flush();
                                sw.Close();
                                MessageBox.Show("Switched the bridge to support OBSWS5 for extensions");
                            }
                        }
                        if (cbOBSWS.SelectedIndex == 0 && sBridge.Contains("<script src=\"https://cdn.jsdelivr.net/npm/obs-websocket-js\"></script>"))
                        {
                            using (StreamWriter sw = new StreamWriter(txtBridge.Text))
                            {
                                sw.Write(sBridge.Replace("<script src=\"https://cdn.jsdelivr.net/npm/obs-websocket-js\"></script>", "<script src=\"https://cdn.jsdelivr.net/npm/obs-websocket-js@4.0.2/dist/obs-websocket.js\"></script>"));
                                sw.Flush();
                                sw.Close();
                                MessageBox.Show("Switched the bridge to support OBSWS4.9.1 for extensions");
                            }
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
