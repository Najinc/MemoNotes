using MemoNotes.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoNotes
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MainMenuStrip menuStrip = new MainMenuStrip();
            Controls.Add(menuStrip);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
