using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitUpdateTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Visible = false;
            button3.Visible = false;
            SolicenTEAM.Updater.ExeFileName = "GitUpdateTest";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await SolicenTEAM.Updater.CheckUpdate("SAn4Es-TV", "GitUpdateTest");
            if (SolicenTEAM.Updater.UpdateVersion == SolicenTEAM.Updater.CurrentVersion)
            {
                MessageBox.Show("Установлена новейшая версия програмного обеспечения!");

                label2.Text = SolicenTEAM.Updater.UpdateDescription;
                label1.Text = "GitUpdateTest " + SolicenTEAM.Updater.UpdateVersion;
                button2.Visible = false;
                button3.Visible = false;
            } else
            {
                label2.Text = SolicenTEAM.Updater.UpdateDescription;
                label1.Text = "GitUpdateTest " + SolicenTEAM.Updater.UpdateVersion;
                label3.Text = "New update awaliable!";
                button2.Visible = true;
                button3.Visible = true;
                Debug.WriteLine(SolicenTEAM.Updater.UpdateDescription);
                Debug.WriteLine(SolicenTEAM.Updater.CurrentVersion);
                Debug.WriteLine(SolicenTEAM.Updater.UpdateVersion);
                if (SolicenTEAM.Updater.UpdateVersion != "")
                { await SolicenTEAM.Updater.CheckUpdate("SAn4Es-TV", "GitUpdateTest"); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            await SolicenTEAM.Updater.CheckUpdate("SAn4Es-TV", "GitUpdateTest");
            if (SolicenTEAM.Updater.UpdateVersion != SolicenTEAM.Updater.CurrentVersion && SolicenTEAM.Updater.UpdateVersion != "")
            {
                SolicenTEAM.Updater.ExtractArchive();
            }
        }
    }
}
