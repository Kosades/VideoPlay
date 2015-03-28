using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace VideoPlay
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeThemeEvent(object sender, EventArgs e)
        {
            string theme = ChooseTheme.SelectedItem.ToString();
           // Properties.Settings s = new Properties.Settings();
            

            switch (theme)
            {
                case "Dark":
                    //s.FormTheme = MetroThemeStyle.Dark;
                    //s.Save();
                    //this.WindowState = FormWindowState.Minimized;
                    this.Theme = MetroThemeStyle.Dark;
                    Player.Theme = MetroThemeStyle.Dark;
                    Previous.Theme = MetroThemeStyle.Dark;
                    Pause.Theme = MetroThemeStyle.Dark;
                    Stop.Theme = MetroThemeStyle.Dark;
                    Next.Theme = MetroThemeStyle.Dark;
                    Media.Theme = MetroThemeStyle.Dark;
                    Settings.Theme = MetroThemeStyle.Dark;
                    Replay.Theme = MetroThemeStyle.Dark;
                    label1.Theme = MetroThemeStyle.Dark;
                    ChooseTheme.Theme = MetroThemeStyle.Dark;
                    vl.Theme = MetroThemeStyle.Dark;
                    tabControl1.Theme = MetroThemeStyle.Dark;
                    VideoProgressBar.Theme = MetroFramework.MetroThemeStyle.Dark;
                    //this.Update();
                    this.Refresh();
                    //this.WindowState = FormWindowState.Normal;
                    break;
                case "Light":
                    //this.WindowState = FormWindowState.Minimized;
                    this.Theme = MetroThemeStyle.Light;
                    Player.Theme = MetroThemeStyle.Light;
                    Previous.Theme = MetroThemeStyle.Light;
                    Pause.Theme = MetroThemeStyle.Light;
                    Stop.Theme = MetroThemeStyle.Light;
                    Next.Theme = MetroThemeStyle.Light;
                    Media.Theme = MetroThemeStyle.Light;
                    Settings.Theme = MetroThemeStyle.Light;
                    Replay.Theme = MetroThemeStyle.Light;
                    label1.Theme = MetroThemeStyle.Light;
                    ChooseTheme.Theme = MetroThemeStyle.Light;
                    vl.Theme = MetroThemeStyle.Light;
                    tabControl1.Theme = MetroThemeStyle.Light;
                    VideoProgressBar.Theme = MetroThemeStyle.Light;
                    //this.Update();
                    this.Refresh();
                    //this.WindowState = FormWindowState.Normal;
                    break;
                default:
                    break;
            }
        }
    }
}
