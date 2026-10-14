using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class frm_photo : Form
    {
        public frm_photo()
        {
            InitializeComponent();
        }

        private void btn_prenota_Click(object sender, EventArgs e)
        {
            if(cmb_tipostanza.SelectedIndex == null || cmb_stagione.SelectedIndex == null)
            {
                MessageBox.Show("Attenzione selezionare il tipo di stanza");
                return; 

            }
            else
            {
                int giorni = Convert.ToInt32(txt_ngiorni.Text);
                string stagione= cmb_stagione.SelectedItem.ToString();
                string stanza = cmb_tipostanza.SelectedItem.ToString();
               
            }
        }

        
    }
}
