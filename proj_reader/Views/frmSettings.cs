using proj_reader.Controllers;
using proj_reader.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_reader.Views
{
    public partial class frmSettings : Form
    {

        string kindText = "";
        Kind getKindLocal;

        public frmSettings()
        {
            InitializeComponent();

            getKindLocal = new Kind();

            //show
            BindingSource source = new BindingSource();
            source.DataSource = KindController.getListKind();
            this.dataKinds.DataSource = source;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Kind kind = new Kind();
            kind.kind = txtKind.Text;

            Kind kindCheck = KindController.getKind(txtKind.Text);

            if (kindCheck == null)
            {
                if (KindController.addKind(kind) == false)
                {
                    MessageBox.Show("Error add kind");
                }
                txtKind.Text = "";
            }

            //show
            BindingSource source = new BindingSource();
            source.DataSource = KindController.getListKind();
            this.dataKinds.DataSource = source;
        }

        private void dataKinds_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Kind kind = new Kind();

            kind.kind = this.dataKinds.CurrentRow.Cells[1].Value.ToString();            

            if (kind.kind.Length <= 0)
            {
                return;
            }

            try
            {
                getKindLocal.kind = kind.kind;
            }
            catch
            {
                getKindLocal.kind = "";
            }

            //update data user to database
            KindController.updateKind(getKindLocal);

            BindingSource source = new BindingSource();
            source.DataSource = KindController.getListKind();
            this.dataKinds.DataSource = source;
        }

        private void dataKinds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kindText = this.dataKinds.CurrentRow.Cells[1].Value.ToString();
            
            getKindLocal = KindController.getKind(kindText);           
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (getKindLocal != null)
            {
                List<Link> listLink = LinkController.getListLink(kindText);
                for (int i = 0; i < listLink.Count; i++)
                {
                    LinkController.deleteLink(listLink[i]);
                }
                KindController.deleteKind(getKindLocal);
            }

            //show
            BindingSource source = new BindingSource();
            source.DataSource = KindController.getListKind();
            this.dataKinds.DataSource = source;
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }

        private void btnMini_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnMaxi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataKinds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
