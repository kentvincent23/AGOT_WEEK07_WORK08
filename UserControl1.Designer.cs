namespace AGOT_WEEK07_WORK08
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_usercontrol = new System.Windows.Forms.Panel();
            this.grp_itemdetails = new System.Windows.Forms.GroupBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.cmb_amount = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_prompt = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.pnl_usercontrol.SuspendLayout();
            this.grp_itemdetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_usercontrol
            // 
            this.pnl_usercontrol.Controls.Add(this.lbl_prompt);
            this.pnl_usercontrol.Controls.Add(this.dataGridView1);
            this.pnl_usercontrol.Controls.Add(this.grp_itemdetails);
            this.pnl_usercontrol.Location = new System.Drawing.Point(22, 17);
            this.pnl_usercontrol.Name = "pnl_usercontrol";
            this.pnl_usercontrol.Size = new System.Drawing.Size(729, 366);
            this.pnl_usercontrol.TabIndex = 0;
            this.pnl_usercontrol.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_usercontrol_Paint);
            // 
            // grp_itemdetails
            // 
            this.grp_itemdetails.Controls.Add(this.btn_delete);
            this.grp_itemdetails.Controls.Add(this.btn_add);
            this.grp_itemdetails.Controls.Add(this.cmb_amount);
            this.grp_itemdetails.Controls.Add(this.txt_amount);
            this.grp_itemdetails.Controls.Add(this.txt_description);
            this.grp_itemdetails.Controls.Add(this.lbl_amount);
            this.grp_itemdetails.Controls.Add(this.lbl_description);
            this.grp_itemdetails.Location = new System.Drawing.Point(3, 3);
            this.grp_itemdetails.Name = "grp_itemdetails";
            this.grp_itemdetails.Size = new System.Drawing.Size(679, 84);
            this.grp_itemdetails.TabIndex = 0;
            this.grp_itemdetails.TabStop = false;
            this.grp_itemdetails.Text = "Item Details";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(25, 20);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(60, 13);
            this.lbl_description.TabIndex = 0;
            this.lbl_description.Text = "Description";
            this.lbl_description.Click += new System.EventHandler(this.lbl_description_Click);
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Location = new System.Drawing.Point(28, 54);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(43, 13);
            this.lbl_amount.TabIndex = 1;
            this.lbl_amount.Text = "Amount";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(91, 17);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(376, 20);
            this.txt_description.TabIndex = 2;
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(91, 51);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(188, 20);
            this.txt_amount.TabIndex = 3;
            // 
            // cmb_amount
            // 
            this.cmb_amount.FormattingEnabled = true;
            this.cmb_amount.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.cmb_amount.Location = new System.Drawing.Point(286, 51);
            this.cmb_amount.Name = "cmb_amount";
            this.cmb_amount.Size = new System.Drawing.Size(121, 21);
            this.cmb_amount.TabIndex = 4;
            this.cmb_amount.SelectedIndexChanged += new System.EventHandler(this.cmb_amount_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(651, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbl_prompt
            // 
            this.lbl_prompt.BackColor = System.Drawing.Color.Brown;
            this.lbl_prompt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_prompt.Location = new System.Drawing.Point(3, 322);
            this.lbl_prompt.Name = "lbl_prompt";
            this.lbl_prompt.Size = new System.Drawing.Size(726, 23);
            this.lbl_prompt.TabIndex = 2;
            this.lbl_prompt.Text = "Prompt";
            this.lbl_prompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(564, 17);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(564, 49);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_usercontrol);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(787, 409);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.pnl_usercontrol.ResumeLayout(false);
            this.grp_itemdetails.ResumeLayout(false);
            this.grp_itemdetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnl_usercontrol;
        private System.Windows.Forms.GroupBox grp_itemdetails;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.ComboBox cmb_amount;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_prompt;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
    }
}
