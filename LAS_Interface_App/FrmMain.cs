using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccuLib;
namespace LAS_Interface_App
{
    public partial class FrmMain : Form
    {
        
        public FrmMain()
        {
            InitializeComponent();
           
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show(clsLib.getName());
        }
    }
}
