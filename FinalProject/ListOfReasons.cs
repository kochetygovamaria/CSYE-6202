using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ListOfReasons : Form
    {
        public BindingList<Reason> reasons;
        public ListOfReasons()
        {
            InitializeComponent();
            this.reasons = new BindingList<Reason>();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datagrid_Reasons_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in datagrid_Reasons.SelectedRows)
            {
                ReasonName.Text = row.Cells[0].Value.ToString();
                Price_txt.Text = row.Cells[1].Value.ToString();

            }
        }

        private void ListOfReasons_Load(object sender, EventArgs e)
        {
            reasons = ClassHelper.LoadReason();
            LoadDataGrid();
        }
        private void LoadDataGrid()
        {
            reasons = ClassHelper.LoadReason();
            datagrid_Reasons.DataSource = reasons;

        }
        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {

        }

        private void addReason_Click(object sender, EventArgs e)
        {
            AddReason adR = new AddReason();
            adR.listOfReasons = this;
            adR.ShowDialog();
            LoadDataGrid();
        }

        private void DeleteReason_Click(object sender, EventArgs e)
        {
            // int index;
            datagrid_Reasons.Rows.RemoveAt(datagrid_Reasons.CurrentRow.Index);
            //ClassHelper.deleteReason(reasons, index);

        }

        private void UpdateReason_Click(object sender, EventArgs e)
        {
            int index = 0;
            Reason reason = null;
            reasons = ClassHelper.LoadReason();
            foreach (DataGridViewRow row in datagrid_Reasons.SelectedRows)
            {
                foreach (Reason r in reasons)
                {
                    if (r.reasonName == row.Cells[0].Value.ToString())
                    {
                        index = reasons.IndexOf(r);
                        reason = r;
                        break;

                    }
                }
            }
            UpdateReason upR = new UpdateReason(reason, index);
            upR.listOfReasons = this;
            upR.ShowDialog();
            LoadDataGrid();

        }
    }
}

