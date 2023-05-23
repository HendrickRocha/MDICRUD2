using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace MDICRUD
{
    public partial class agenda : Form
    {
        private Repositorio repositorio;
        public agenda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void agenda_Load(object sender, EventArgs e)
        {
            repositorio = new Repositorio();
            bsAgenda.DataSource = repositorio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            frmDetalhe frm = new frmDetalhe();
            frm.agenda = agenda;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                repositorio.Create(agenda);
                bsAgenda.Add(agenda);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            repositorio.Delete(bsAgenda.Current as Agenda);
            bsAgenda.Remove(bsAgenda.Current as Agenda);
            bsAgenda.ResetBindings(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmDetalhe frm = new frmDetalhe();
            frm.agenda = bsAgenda.Current as Agenda;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                repositorio.Udpate(frm.agenda);
                bsAgenda.ResetBindings(false);
            }
        }
    }
}
