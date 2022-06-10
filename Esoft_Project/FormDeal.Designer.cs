namespace Esoft_Project
{
    partial class FormDeal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeal));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewDealSet = new System.Windows.Forms.ListView();
            this.ClientProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AgentProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientPokup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AgentPokup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelSupply = new System.Windows.Forms.Label();
            this.comboBoxSupply = new System.Windows.Forms.ComboBox();
            this.comboBoxDemand = new System.Windows.Forms.ComboBox();
            this.labelDemand = new System.Windows.Forms.Label();
            this.textBoxSellerCompanyDeductions = new System.Windows.Forms.TextBox();
            this.labelAgentSellerDeductions = new System.Windows.Forms.Label();
            this.textBoxAgentSellerDeductions = new System.Windows.Forms.TextBox();
            this.labelSellerCompanyDeductions = new System.Windows.Forms.Label();
            this.textBoxCustomerCompanyDeductions = new System.Windows.Forms.TextBox();
            this.labelAgentCustomerDeductions = new System.Windows.Forms.Label();
            this.textBoxAgentCustomerDeductions = new System.Windows.Forms.TextBox();
            this.labelCustomerCompanyDeductions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDel.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonDel.Location = new System.Drawing.Point(768, 269);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(244, 55);
            this.buttonDel.TabIndex = 31;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonEdit.Location = new System.Drawing.Point(518, 269);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(244, 55);
            this.buttonEdit.TabIndex = 30;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonAdd.Location = new System.Drawing.Point(268, 269);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(244, 55);
            this.buttonAdd.TabIndex = 29;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Esoft_Project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // listViewDealSet
            // 
            this.listViewDealSet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listViewDealSet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClientProd,
            this.AgentProd,
            this.ClientPokup,
            this.AgentPokup,
            this.Address,
            this.Count});
            this.listViewDealSet.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewDealSet.FullRowSelect = true;
            this.listViewDealSet.GridLines = true;
            this.listViewDealSet.HideSelection = false;
            this.listViewDealSet.Location = new System.Drawing.Point(268, 12);
            this.listViewDealSet.MultiSelect = false;
            this.listViewDealSet.Name = "listViewDealSet";
            this.listViewDealSet.Size = new System.Drawing.Size(744, 251);
            this.listViewDealSet.TabIndex = 55;
            this.listViewDealSet.UseCompatibleStateImageBehavior = false;
            this.listViewDealSet.View = System.Windows.Forms.View.Details;
            this.listViewDealSet.SelectedIndexChanged += new System.EventHandler(this.listViewDealSet_SelectedIndexChanged);
            // 
            // ClientProd
            // 
            this.ClientProd.Text = "Клиент-продавец";
            this.ClientProd.Width = 112;
            // 
            // AgentProd
            // 
            this.AgentProd.Text = "Риелтор клиента-продавца";
            this.AgentProd.Width = 166;
            // 
            // ClientPokup
            // 
            this.ClientPokup.Text = "Клиент-покупатель";
            this.ClientPokup.Width = 124;
            // 
            // AgentPokup
            // 
            this.AgentPokup.Text = "Риелтор клиента-покупателя";
            this.AgentPokup.Width = 180;
            // 
            // Address
            // 
            this.Address.Text = "Адрес объекта недвижимости";
            this.Address.Width = 88;
            // 
            // Count
            // 
            this.Count.Text = "Стоимость";
            this.Count.Width = 79;
            // 
            // labelSupply
            // 
            this.labelSupply.AutoSize = true;
            this.labelSupply.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSupply.Location = new System.Drawing.Point(9, 12);
            this.labelSupply.Name = "labelSupply";
            this.labelSupply.Size = new System.Drawing.Size(77, 13);
            this.labelSupply.TabIndex = 59;
            this.labelSupply.Text = "Предложения";
            // 
            // comboBoxSupply
            // 
            this.comboBoxSupply.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSupply.FormattingEnabled = true;
            this.comboBoxSupply.Location = new System.Drawing.Point(12, 28);
            this.comboBoxSupply.Name = "comboBoxSupply";
            this.comboBoxSupply.Size = new System.Drawing.Size(250, 21);
            this.comboBoxSupply.TabIndex = 58;
            this.comboBoxSupply.SelectedIndexChanged += new System.EventHandler(this.comboBoxSupply_SelectedIndexChanged);
            // 
            // comboBoxDemand
            // 
            this.comboBoxDemand.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDemand.FormattingEnabled = true;
            this.comboBoxDemand.Location = new System.Drawing.Point(12, 68);
            this.comboBoxDemand.Name = "comboBoxDemand";
            this.comboBoxDemand.Size = new System.Drawing.Size(250, 21);
            this.comboBoxDemand.TabIndex = 57;
            this.comboBoxDemand.SelectedIndexChanged += new System.EventHandler(this.comboBoxDemand_SelectedIndexChanged);
            // 
            // labelDemand
            // 
            this.labelDemand.AutoSize = true;
            this.labelDemand.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDemand.Location = new System.Drawing.Point(9, 52);
            this.labelDemand.Name = "labelDemand";
            this.labelDemand.Size = new System.Drawing.Size(73, 13);
            this.labelDemand.TabIndex = 56;
            this.labelDemand.Text = "Потребность";
            // 
            // textBoxSellerCompanyDeductions
            // 
            this.textBoxSellerCompanyDeductions.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSellerCompanyDeductions.Location = new System.Drawing.Point(12, 115);
            this.textBoxSellerCompanyDeductions.Name = "textBoxSellerCompanyDeductions";
            this.textBoxSellerCompanyDeductions.Size = new System.Drawing.Size(250, 21);
            this.textBoxSellerCompanyDeductions.TabIndex = 63;
            // 
            // labelAgentSellerDeductions
            // 
            this.labelAgentSellerDeductions.AutoSize = true;
            this.labelAgentSellerDeductions.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAgentSellerDeductions.Location = new System.Drawing.Point(9, 141);
            this.labelAgentSellerDeductions.Name = "labelAgentSellerDeductions";
            this.labelAgentSellerDeductions.Size = new System.Drawing.Size(211, 13);
            this.labelAgentSellerDeductions.TabIndex = 62;
            this.labelAgentSellerDeductions.Text = "Отчисления риелтору клиента-продавца";
            // 
            // textBoxAgentSellerDeductions
            // 
            this.textBoxAgentSellerDeductions.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAgentSellerDeductions.Location = new System.Drawing.Point(12, 157);
            this.textBoxAgentSellerDeductions.Name = "textBoxAgentSellerDeductions";
            this.textBoxAgentSellerDeductions.Size = new System.Drawing.Size(250, 21);
            this.textBoxAgentSellerDeductions.TabIndex = 61;
            // 
            // labelSellerCompanyDeductions
            // 
            this.labelSellerCompanyDeductions.AutoSize = true;
            this.labelSellerCompanyDeductions.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSellerCompanyDeductions.Location = new System.Drawing.Point(9, 99);
            this.labelSellerCompanyDeductions.Name = "labelSellerCompanyDeductions";
            this.labelSellerCompanyDeductions.Size = new System.Drawing.Size(208, 13);
            this.labelSellerCompanyDeductions.TabIndex = 60;
            this.labelSellerCompanyDeductions.Text = "Стоимость услуг для клиента-продавца";
            // 
            // textBoxCustomerCompanyDeductions
            // 
            this.textBoxCustomerCompanyDeductions.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCustomerCompanyDeductions.Location = new System.Drawing.Point(12, 200);
            this.textBoxCustomerCompanyDeductions.Name = "textBoxCustomerCompanyDeductions";
            this.textBoxCustomerCompanyDeductions.Size = new System.Drawing.Size(250, 21);
            this.textBoxCustomerCompanyDeductions.TabIndex = 67;
            // 
            // labelAgentCustomerDeductions
            // 
            this.labelAgentCustomerDeductions.AutoSize = true;
            this.labelAgentCustomerDeductions.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAgentCustomerDeductions.Location = new System.Drawing.Point(9, 226);
            this.labelAgentCustomerDeductions.Name = "labelAgentCustomerDeductions";
            this.labelAgentCustomerDeductions.Size = new System.Drawing.Size(221, 13);
            this.labelAgentCustomerDeductions.TabIndex = 66;
            this.labelAgentCustomerDeductions.Text = "Отчисления риелтору клиента-покупателя";
            // 
            // textBoxAgentCustomerDeductions
            // 
            this.textBoxAgentCustomerDeductions.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAgentCustomerDeductions.Location = new System.Drawing.Point(12, 242);
            this.textBoxAgentCustomerDeductions.Name = "textBoxAgentCustomerDeductions";
            this.textBoxAgentCustomerDeductions.Size = new System.Drawing.Size(250, 21);
            this.textBoxAgentCustomerDeductions.TabIndex = 65;
            // 
            // labelCustomerCompanyDeductions
            // 
            this.labelCustomerCompanyDeductions.AutoSize = true;
            this.labelCustomerCompanyDeductions.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCustomerCompanyDeductions.Location = new System.Drawing.Point(9, 184);
            this.labelCustomerCompanyDeductions.Name = "labelCustomerCompanyDeductions";
            this.labelCustomerCompanyDeductions.Size = new System.Drawing.Size(218, 13);
            this.labelCustomerCompanyDeductions.TabIndex = 64;
            this.labelCustomerCompanyDeductions.Text = "Стоимость услуг для клиента-покупателя";
            // 
            // FormDeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 331);
            this.Controls.Add(this.textBoxCustomerCompanyDeductions);
            this.Controls.Add(this.labelAgentCustomerDeductions);
            this.Controls.Add(this.textBoxAgentCustomerDeductions);
            this.Controls.Add(this.labelCustomerCompanyDeductions);
            this.Controls.Add(this.textBoxSellerCompanyDeductions);
            this.Controls.Add(this.labelAgentSellerDeductions);
            this.Controls.Add(this.textBoxAgentSellerDeductions);
            this.Controls.Add(this.labelSellerCompanyDeductions);
            this.Controls.Add(this.labelSupply);
            this.Controls.Add(this.comboBoxSupply);
            this.Controls.Add(this.comboBoxDemand);
            this.Controls.Add(this.labelDemand);
            this.Controls.Add(this.listViewDealSet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Предложения";
            this.Load += new System.EventHandler(this.FormDeal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewDealSet;
        private System.Windows.Forms.ColumnHeader ClientProd;
        private System.Windows.Forms.ColumnHeader AgentProd;
        private System.Windows.Forms.ColumnHeader ClientPokup;
        private System.Windows.Forms.ColumnHeader AgentPokup;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Count;
        private System.Windows.Forms.Label labelSupply;
        private System.Windows.Forms.ComboBox comboBoxSupply;
        private System.Windows.Forms.ComboBox comboBoxDemand;
        private System.Windows.Forms.Label labelDemand;
        private System.Windows.Forms.TextBox textBoxSellerCompanyDeductions;
        private System.Windows.Forms.Label labelAgentSellerDeductions;
        private System.Windows.Forms.TextBox textBoxAgentSellerDeductions;
        private System.Windows.Forms.Label labelSellerCompanyDeductions;
        private System.Windows.Forms.TextBox textBoxCustomerCompanyDeductions;
        private System.Windows.Forms.Label labelAgentCustomerDeductions;
        private System.Windows.Forms.TextBox textBoxAgentCustomerDeductions;
        private System.Windows.Forms.Label labelCustomerCompanyDeductions;
    }
}