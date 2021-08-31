using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace reg
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            loadData();
        }

        void loadData()
        {
            string[] data = File.ReadAllText("config.txt").Split('\n');
            ldPath.Text = data[0].Split('=')[1];
            string ho = "", ten = "";
            foreach(var s in data[1].Split('=')[1].Split('|'))
            {
                ho += s + "\n";
            }
            rtbHo.Text = ho;
            foreach (var s in data[2].Split('=')[1].Split('|'))
            {
                ten += s + "\n";
            }
            rtbTen.Text = ten;
        }
    }
}
