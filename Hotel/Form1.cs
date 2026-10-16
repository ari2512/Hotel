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
            if (cmb_tipostanza.SelectedIndex == null || cmb_stagione.SelectedIndex == null)
            {
                MessageBox.Show("Attenzione selezionare il tipo di stanza");
                return;

            }
            else
            {
                int giorni = Convert.ToInt32(txt_ngiorni.Text);
                string stagione = cmb_stagione.SelectedItem.ToString();
                string stanza = cmb_tipostanza.SelectedItem.ToString();
                int costoGiornaliero = Convert.ToInt32(txt_ngiorni.Text);


                if (stagione == "bassa stagione")
                {
                    if (stanza == "bassa")
                    {
                        costoGiornaliero = 15;
                    }
                    else if (stanza == "media")
                    {
                        costoGiornaliero = 30;
                    }
                    else if (stanza == " alta")
                    {
                        costoGiornaliero = 45;
                    }
                }
                if (stagione == " media stagione")
                {
                    if (stanza == " bassa")
                    {
                        costoGiornaliero = 20;
                    }
                    else if (stanza == " media")
                    {
                        costoGiornaliero = 35;
                    }
                    else if (stanza == " alta")
                    {
                        costoGiornaliero = 50;
                    }
                }
                if (stagione == " alta stagione")
                {
                    if (stanza == " bassa")
                    {
                        costoGiornaliero = 25;
                    }
                    else if (stanza == " media")
                    {
                        costoGiornaliero = 40;
                    }
                    else if (stanza == " alta")
                    {
                        costoGiornaliero = 55;
                    }
                }
            }


        }
    }
}