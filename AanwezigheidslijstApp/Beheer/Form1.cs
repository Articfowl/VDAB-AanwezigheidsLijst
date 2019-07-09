using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpleidingKlasses;
namespace Beheer
{
    public partial class frmBeheer : Form
    {
        public frmBeheer()
        {
            InitializeComponent();
        }

        private void FrmBeheer_Load(object sender, EventArgs e)
        {
            Size = new Size(330, 300);
        }

        private void BtnOpleiding_Click(object sender, EventArgs e)
        {
            pnlButtons.Visible = false;
            Size = new Size(450, 300);
            pnlInformatie.Visible = true;
            pnlInformatie.Location = new Point(12, 12);
            using (var context = new OpleidingContext())
            {
                Opleidingsinformatie info = context.OpleidingsInformatie.SingleOrDefault(x => x.Id == 1);
                if (info != null)
                {
                    lblContactPersoon.Text = info.Contactpersoon;
                    lblOENummer.Text = info.OeNummer.ToString();
                    lblOpleiding.Text = info.Opleiding;
                    lblOpleidingcode.Text = info.Opleidingscode.ToString();
                    lblOpleidingsplaats.Text = info.Opleidingsplaats.ToString();
                    lblOpleidngsInstelling.Text = info.Opleidingsinstelling;
                    lblReferentieOpleiding.Text = info.ReferentieOpleidingsPlaats;
                    lblStartEindDatum.Text = string.Concat(info.StartDatum.ToShortDateString(), " - ", info.EindDatum.ToShortDateString());
                }
            }
        }

        private void BtnInfoBeheer_Click(object sender, EventArgs e)
        {
            Size = new Size(330, 300);
            pnlInformatie.Visible = false;
            pnlButtons.Visible = true;
        }

        private void BtnDeelnemers_Click(object sender, EventArgs e)
        {
            pnlButtons.Visible = false;
            Size = new Size(330, 530);
            pnlDeelnemers.Visible = true;
            pnlDeelnemers.Location = new Point(12, 12);
            using(var context = new OpleidingContext())
            {
                foreach (var deelnemer in context.Deelnemers)
                {
                    lstbDeelnemers.Items.Add(deelnemer.Id.ToString() + " - " + deelnemer.BadgeNummer + " - " + deelnemer.Naam +
                        " - " + deelnemer.GeboorteDatum.ToString() + " - " + deelnemer.Woonplaats);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Size = new Size(330, 300);
            pnlDeelnemers.Visible = false;
            pnlButtons.Visible = true;
        }
    }
}