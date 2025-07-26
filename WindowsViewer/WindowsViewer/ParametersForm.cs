using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using oec;
namespace WindowsViewer
{
    public partial class ParametersForm : Form
    {
        public ParametersForm(ConfigurationManaged config)
        {
            this.Config = config;
            this.InitializeComponent();
            foreach (var key in this.Config.ParameterList.ParameterDictionary.Keys)
            {
                using (StringWriter stringWriter = new StringWriter())
                {
                    TextWriter textWriter = stringWriter;
                    this.Config.ParameterList.ParameterDictionary[key].Save(ref textWriter);
                    this.dataGridView1.Rows.Add(new object[]
                    {
                       key,
                       stringWriter.ToString().Substring(key.Length + 2).Trim()
                    });
                }
            }
        }

        public void RefreshValues()
        {
            foreach (object obj in ((IEnumerable)this.dataGridView1.Rows))
            {
                DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                using (StringWriter stringWriter = new StringWriter())
                {
                    string text = dataGridViewRow.Cells["ColumnName"].Value.ToString();
                    TextWriter textWriter = stringWriter;
                    this.Config.ParameterList.ParameterDictionary[text].Save(ref textWriter);
                    dataGridViewRow.Cells["ColumnValue"].Value = stringWriter.ToString().Substring(text.Length + 2).Trim();
                }
            }
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataGridViewRow = this.dataGridView1.Rows[e.RowIndex];
            object value = dataGridViewRow.Cells["ColumnValue"].Value;
            double num;
            if (double.TryParse((value != null) ? value.ToString() : null, out num))
            {
                this.Config.ReadValue(dataGridViewRow.Cells["ColumnName"].Value.ToString(), num);
            }
            this.RefreshValues();
        }

        private void dataGridView1_Paint(object sender, DataGridViewCellEventArgs e)
        {
            this.RefreshValues();
        }

        private void ScrollToMatchingRow(string searchText, bool SelectCell)
        {
            int nameColumnIndex = 0;
            int valueColumnIndex = 1;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[nameColumnIndex].Value != null &&
                    row.Cells[nameColumnIndex].Value.ToString().StartsWith(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    this.dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                    this.dataGridView1.ClearSelection();
                    this.dataGridView1.CurrentCell = row.Cells[valueColumnIndex];
                    row.Cells[valueColumnIndex].Selected = true;
                    break;
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (dataGridView1.IsCurrentCellInEditMode)
                return base.ProcessCmdKey(ref msg, keyData);

            if (keyData == Keys.Enter)
            {
                this.ParameterSearch = null;

                if (dataGridView1.CurrentCell != null)
                {
                    dataGridView1.BeginEdit(true);
                    return true;
                }
            }
            else if (keyData == Keys.Back)
            {
                this.ParameterSearch = null;
                return true;
            }
            else if (keyData == Keys.Up || keyData == Keys.Down ||
                     keyData == Keys.Left || keyData == Keys.Right)
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
            else
            {
                this.ParameterSearch += keyData;
                ScrollToMatchingRow(this.ParameterSearch, false);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        public string _Author = "Added by BlueAmulet";
        private string ParameterSearch;
        private readonly ConfigurationManaged Config;
    }
}
