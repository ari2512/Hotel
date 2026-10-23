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
            if (cmb_tipostanza.SelectedItem == null || cmb_stagione.SelectedItem == null)
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
                float prezzoTot = 0;



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
                    double costoStanza = 0;
                    if (giorni <= 0)
                    {
                        MessageBox.Show("I parametri non sono validi");

                    }
                    else if (giorni >= 7)
                    {
                        prezzoTot = prezzoTot - (prezzoTot * 35 / 100);
                    }
                    else if (giorni >= 3)
                    {
                        prezzoTot = prezzoTot - (prezzoTot * 25 / 100);
                    }
                    if (chk_si.Checked)
                    {
                        prezzoTot = prezzoTot + (5 * giorni);
                    }

                    if (giorni <= 0)
                    {
                        MessageBox.Show("i dati inseriti non sono corretti, riprova");
                    }
                    else if (giorni <= 2)
                    {
                        costoStanza += costoGiornaliero * giorni;
                    }
                    else if (giorni <= 7)
                    {
                        costoStanza += (costoGiornaliero * giorni) * 0.75;
                    }
                    else
                    {
                        costoStanza += (costoGiornaliero * giorni) * 0.65;
                    }

                    double costoParcheggio = 0;
                    if (chk_si.Checked)
                    {
                        costoParcheggio = 5 * giorni;
                    }

                    double prezzoTotale = costoStanza + costoParcheggio;
                    lbl_total.Text = "spesa totale: " + prezzoTotale;

                }
            }
        }       
            


    private void btn_istruzioni_Click(object sender, EventArgs e)
              {
             string infoHotel = "Benvenuto nella pagina dell'Hotel Conchiglia\n" +
                 "Sotto vi riporto tutte le procedure per fare una prenotazione all' interno del nostro hotel:\n" +
                  "1) selezionare il tipo di stagione che si desidera prenotare\n" +
                 "2) selezionare il tipo di stanza che preferisce\n" +
                 "3) selezionare il numero di giorni che desidera trascorrere nel nostro hotel\n" +
                 "4) mettere la spunta nel riquadro se desidera usufruire il servizio parcheggio\n" +
                 "5) premere il tasto PRENOTA dove sarà riportato il prezzo totale di tutta il soggiorno\n";

            MessageBox.Show(infoHotel, "informazioni ulteriori", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

            }


        
     


