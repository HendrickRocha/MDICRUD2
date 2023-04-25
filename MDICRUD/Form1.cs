using MDICRUD;

namespace MDICRUD
{
    public partial class CRUD : Form
    {
        cep cep;
        sobre sobre;
        agenda agenda;

        public CRUD()
        {
            InitializeComponent();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(cep == null)
            {
                cep cepForm = new cep();

                cepForm.MdiParent = this;   
                cepForm.WindowState = FormWindowState.Maximized;
                cepForm.Show();
                
            }
            else
            {
                cep.Activate();
            }
        }

        private void agendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (agenda == null)
            {
                agenda agendaForm = new agenda();

                agendaForm.MdiParent = this;
                agendaForm.WindowState = FormWindowState.Maximized;
                agendaForm.Show();

            }
            else
            {
                agenda.Activate();
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sobre == null)
            {
                sobre sobreForm = new sobre();

                sobreForm.ShowDialog();

            }
            else
            {
                sobre.Activate();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}