using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;

namespace ControlCreator
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
            fill_comboTable();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_main_Load(object sender, EventArgs e)
        {

        }

        private void fill_comboTable(string db = "Sales")
        {
            cbox_table.Items.Clear();

            string conStr = "Data Source = DESKTOP-K30D8QK\\SQLEXPRESS; Initial Catalog = " + db + "; Integrated Security = true;";
            string cmdstr = "select name from sys.tables";

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmdstr, conStr);

                sda.Fill(dt);
                //cbox_table.DataSource = dt.Rows.Find("name"); ;
                foreach (DataRow row in dt.Rows)
                {
                    cbox_table.Items.Add(row["name"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fill_dgvTable(string db = "Sales", string tableName = "")
        {
            string conStr = "Data Source = DESKTOP-K30D8QK\\SQLEXPRESS; Initial Catalog = " + db + "; Integrated Security = true;";
            string cmdstr = "SELECT ROW_NUMBER() OVER ( ORDER BY ORDINAL_POSITION) row_num, COLUMN_NAME, 0 selectdata, " +
                "'' controlType, '' label_txt " +
                "FROM INFORMATION_SCHEMA.COLUMNS " +
                "WHERE TABLE_NAME = '" + tableName + "'";

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmdstr, conStr);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sda);
                DataSet ds = new DataSet();

                sda.Fill(ds);
                //dgvTable.ReadOnly = true;
                dgvTable.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_database_Click(object sender, EventArgs e)
        {
            fill_comboTable(txt_db.Text);
        }

        private void btn_strTable_Click(object sender, EventArgs e)
        {
            if (cbox_table.Text != "")
                fill_dgvTable(txt_db.Text, cbox_table.Text);
        }

        private void btn_genCode_Click(object sender, EventArgs e)
        {
            if (dgvTable.Rows.Count > 0)
                genCode();
        }

        private void genCode()
        {
            rtxt_code.Text = "";

            string strFirst = "", strSub = "";
            int l = 25;
            foreach (DataGridViewRow row in dgvTable.Rows)
            {
                if (row.Cells["select"].Value.ToString() == "1")
                {
                    if (row.Cells["controlType"].Value.ToString() == "")
                    {
                        MessageBox.Show("الرجاء اختيار نوع الاداة");
                        strFirst = "";
                        strSub = "";
                        break;
                    }

                    //str += row.Cells["name"].Value.ToString() + " \n";
                    //str += row.Cells["controlType"].Value.ToString() + " \n";
                    strFirst += "// " + row.Cells["name"].Value.ToString() + "\n";

                    switch (row.Cells["controlType"].Value.ToString())
                    {
                        case "TextBox":
                            strFirst += "this." + row.Cells["name"].Value.ToString() + " = new System.Windows.Forms.TextBox();" + "\n";
                            strSub += "private System.Windows.Forms.TextBox " + row.Cells["name"].Value.ToString() + ";" + "\n";
                            break;
                        case "Label":
                            strFirst += "this." + row.Cells["name"].Value.ToString() + " = new System.Windows.Forms.Label();" + "\n";
                            strFirst += "this." + row.Cells["name"].Value.ToString() + ".Text = \"" + row.Cells["name"].Value.ToString() + "\";" + "\n";
                            strFirst += "this." + row.Cells["name"].Value.ToString() + ".TextAlign = System.Drawing.ContentAlignment.MiddleCenter;" + "\n";
                            strSub += "private System.Windows.Forms.Label " + row.Cells["name"].Value.ToString() + ";" + "\n";
                            break;
                        case "CheckBox":
                            strFirst += "this." + row.Cells["name"].Value.ToString() + " = new System.Windows.Forms.CheckBox();" + "\n";
                            strSub += "private System.Windows.Forms.CheckBox " + row.Cells["name"].Value.ToString() + ";" + "\n";
                            break;
                        case "Button":
                            strFirst += "this." + row.Cells["name"].Value.ToString() + " = new System.Windows.Forms.Button();" + "\n";
                            strSub += "private System.Windows.Forms.Button " + row.Cells["name"].Value.ToString() + ";" + "\n";
                            break;
                    }
                    
                    strFirst += "this." + row.Cells["name"].Value.ToString() + ".Name = \"" + row.Cells["name"].Value.ToString() + "\";" + "\n";
                    strFirst += "this." + row.Cells["name"].Value.ToString() + ".Size = new System.Drawing.Size(200, 20);" + "\n";
                    strFirst += "this." + row.Cells["name"].Value.ToString() + ".Location = new System.Drawing.Point(96, " + l.ToString() + ");" + "\n";
                    strFirst += "this.Controls.Add(this." + row.Cells["name"].Value.ToString() + ");" + "\n";

                    if (row.Cells["label"].Value.ToString() != "")
                    {
                        strFirst += "\n";
                        strFirst += "this.lbl_" + row.Cells["name"].Value.ToString() + " = new System.Windows.Forms.Label();" + "\n";
                        strFirst += "this.lbl_" + row.Cells["name"].Value.ToString() + ".Name = \"lbl_" + row.Cells["name"].Value.ToString() + "\";" + "\n";
                        strFirst += "this.lbl_" + row.Cells["name"].Value.ToString() + ".Text = \"" + row.Cells["label"].Value.ToString() + "\";" + "\n";
                        strFirst += "this.lbl_" + row.Cells["name"].Value.ToString() + ".Size = new System.Drawing.Size(75, 20);" + "\n";
                        strFirst += "this.lbl_" + row.Cells["name"].Value.ToString() + ".Location = new System.Drawing.Point(15, " + l.ToString() + ");" + "\n";
                        strFirst += "this.lbl_" + row.Cells["name"].Value.ToString() + ".TextAlign = System.Drawing.ContentAlignment.MiddleCenter;" + "\n";
                        strFirst += "this.Controls.Add(this.lbl_" + row.Cells["name"].Value.ToString() + ");" + "\n";
                        strSub += "private System.Windows.Forms.Label lbl_" + row.Cells["name"].Value.ToString() + ";" + "\n";
                    }

                    l += 25;
                    strFirst += "\n";
                }
            }

            rtxt_code.Text = strFirst;
            rtxt_code.Text += "}" + "\n\n" + "#endregion" + "\n\n";
            rtxt_code.Text += strSub;
        }

        private void btn_clearCode_Click(object sender, EventArgs e)
        {
            rtxt_code.Text = "";
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            if (rtxt_code.Text != "")
            {
                rtxt_code.SelectAll();
                rtxt_code.Copy();

                MessageBox.Show("تم النسخ", "Control Creator", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_saveFile_Click(object sender, EventArgs e)
        {
            if (rtxt_code.Text != "")
                saveFile();
        }

        private void saveFile()
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.txt";
            saveFile1.Filter = "TXT Files|*.txt";
            saveFile1.FileName = txt_db.Text + "-" + cbox_table.Text;

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                rtxt_code.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("تم الحفظ", saveFile1.FileName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
