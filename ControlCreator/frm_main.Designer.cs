namespace ControlCreator
{
    partial class frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_db = new System.Windows.Forms.TextBox();
            this.btn_strTable = new System.Windows.Forms.Button();
            this.btn_database = new System.Windows.Forms.Button();
            this.cbox_table = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.chBox_selectAll = new System.Windows.Forms.CheckBox();
            this.rtxt_code = new System.Windows.Forms.RichTextBox();
            this.btn_clearCode = new System.Windows.Forms.Button();
            this.btn_genCode = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_saveFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_db);
            this.groupBox1.Controls.Add(this.btn_strTable);
            this.groupBox1.Controls.Add(this.btn_database);
            this.groupBox1.Controls.Add(this.cbox_table);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الاتصال بقاعدة البيانات";
            // 
            // txt_db
            // 
            this.txt_db.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txt_db.Location = new System.Drawing.Point(106, 28);
            this.txt_db.Name = "txt_db";
            this.txt_db.Size = new System.Drawing.Size(212, 22);
            this.txt_db.TabIndex = 5;
            this.txt_db.Text = "sales";
            // 
            // btn_strTable
            // 
            this.btn_strTable.Location = new System.Drawing.Point(65, 56);
            this.btn_strTable.Name = "btn_strTable";
            this.btn_strTable.Size = new System.Drawing.Size(35, 22);
            this.btn_strTable.TabIndex = 4;
            this.btn_strTable.Text = "...";
            this.btn_strTable.UseVisualStyleBackColor = true;
            this.btn_strTable.Click += new System.EventHandler(this.btn_strTable_Click);
            // 
            // btn_database
            // 
            this.btn_database.Location = new System.Drawing.Point(65, 28);
            this.btn_database.Name = "btn_database";
            this.btn_database.Size = new System.Drawing.Size(35, 22);
            this.btn_database.TabIndex = 1;
            this.btn_database.Text = "...";
            this.btn_database.UseVisualStyleBackColor = true;
            this.btn_database.Click += new System.EventHandler(this.btn_database_Click);
            // 
            // cbox_table
            // 
            this.cbox_table.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_table.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_table.FormattingEnabled = true;
            this.cbox_table.Location = new System.Drawing.Point(106, 56);
            this.cbox_table.Name = "cbox_table";
            this.cbox_table.Size = new System.Drawing.Size(212, 22);
            this.cbox_table.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(324, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "الجدول :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(324, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "قاعدة البيانات :";
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.name,
            this.select,
            this.label,
            this.controlType});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTable.Location = new System.Drawing.Point(12, 149);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.Size = new System.Drawing.Size(469, 392);
            this.dgvTable.TabIndex = 1;
            // 
            // no
            // 
            this.no.DataPropertyName = "row_num";
            this.no.HeaderText = "ر.م";
            this.no.Name = "no";
            this.no.Width = 40;
            // 
            // name
            // 
            this.name.DataPropertyName = "COLUMN_NAME";
            this.name.HeaderText = "اسم الحقل";
            this.name.Name = "name";
            this.name.Width = 130;
            // 
            // select
            // 
            this.select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.select.DataPropertyName = "selectdata";
            this.select.HeaderText = "اختيار";
            this.select.Name = "select";
            this.select.Width = 46;
            // 
            // label
            // 
            this.label.DataPropertyName = "label_txt";
            this.label.HeaderText = "label";
            this.label.Name = "label";
            this.label.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.label.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // controlType
            // 
            this.controlType.DataPropertyName = "controlType";
            this.controlType.HeaderText = "نوع الاداة";
            this.controlType.Items.AddRange(new object[] {
            "TextBox",
            "Label",
            "CheckBox",
            "Button"});
            this.controlType.Name = "controlType";
            // 
            // chBox_selectAll
            // 
            this.chBox_selectAll.AutoSize = true;
            this.chBox_selectAll.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBox_selectAll.Location = new System.Drawing.Point(12, 126);
            this.chBox_selectAll.Name = "chBox_selectAll";
            this.chBox_selectAll.Size = new System.Drawing.Size(86, 18);
            this.chBox_selectAll.TabIndex = 2;
            this.chBox_selectAll.Text = "تحديد الكل";
            this.chBox_selectAll.UseVisualStyleBackColor = true;
            // 
            // rtxt_code
            // 
            this.rtxt_code.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_code.Location = new System.Drawing.Point(487, 60);
            this.rtxt_code.Name = "rtxt_code";
            this.rtxt_code.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtxt_code.Size = new System.Drawing.Size(687, 529);
            this.rtxt_code.TabIndex = 3;
            this.rtxt_code.Text = "";
            // 
            // btn_clearCode
            // 
            this.btn_clearCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearCode.Location = new System.Drawing.Point(232, 547);
            this.btn_clearCode.Name = "btn_clearCode";
            this.btn_clearCode.Size = new System.Drawing.Size(132, 42);
            this.btn_clearCode.TabIndex = 5;
            this.btn_clearCode.Text = "مسح البيانات";
            this.btn_clearCode.UseVisualStyleBackColor = true;
            this.btn_clearCode.Click += new System.EventHandler(this.btn_clearCode_Click);
            // 
            // btn_genCode
            // 
            this.btn_genCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_genCode.Location = new System.Drawing.Point(94, 547);
            this.btn_genCode.Name = "btn_genCode";
            this.btn_genCode.Size = new System.Drawing.Size(132, 42);
            this.btn_genCode.TabIndex = 6;
            this.btn_genCode.Text = "انشاء الادوات";
            this.btn_genCode.UseVisualStyleBackColor = true;
            this.btn_genCode.Click += new System.EventHandler(this.btn_genCode_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_copy.Location = new System.Drawing.Point(487, 12);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(132, 42);
            this.btn_copy.TabIndex = 7;
            this.btn_copy.Text = "نسخ الكود";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_saveFile
            // 
            this.btn_saveFile.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveFile.Location = new System.Drawing.Point(625, 12);
            this.btn_saveFile.Name = "btn_saveFile";
            this.btn_saveFile.Size = new System.Drawing.Size(132, 42);
            this.btn_saveFile.TabIndex = 8;
            this.btn_saveFile.Text = "حفظ الملف";
            this.btn_saveFile.UseVisualStyleBackColor = true;
            this.btn_saveFile.Click += new System.EventHandler(this.btn_saveFile_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 601);
            this.Controls.Add(this.btn_saveFile);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.btn_genCode);
            this.Controls.Add(this.btn_clearCode);
            this.Controls.Add(this.rtxt_code);
            this.Controls.Add(this.chBox_selectAll);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "منشئ الادوات";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbox_table;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.CheckBox chBox_selectAll;
        private System.Windows.Forms.RichTextBox rtxt_code;
        private System.Windows.Forms.Button btn_clearCode;
        private System.Windows.Forms.Button btn_genCode;
        private System.Windows.Forms.TextBox txt_db;
        private System.Windows.Forms.Button btn_strTable;
        private System.Windows.Forms.Button btn_database;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn label;
        private System.Windows.Forms.DataGridViewComboBoxColumn controlType;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_saveFile;
    }
}

