namespace Esoft_Project
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonOpenClients = new System.Windows.Forms.Button();
            this.buttonOpenDeals = new System.Windows.Forms.Button();
            this.buttonOpenSupplySet = new System.Windows.Forms.Button();
            this.buttonOpenSupplies = new System.Windows.Forms.Button();
            this.buttonOpenRealEstates = new System.Windows.Forms.Button();
            this.buttonOpenAgents = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.labelHello = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenClients
            // 
            this.buttonOpenClients.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenClients.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenClients.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonOpenClients.Location = new System.Drawing.Point(12, 135);
            this.buttonOpenClients.Margin = new System.Windows.Forms.Padding(15);
            this.buttonOpenClients.Name = "buttonOpenClients";
            this.buttonOpenClients.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenClients.TabIndex = 1;
            this.buttonOpenClients.Text = "Клиенты";
            this.buttonOpenClients.UseVisualStyleBackColor = false;
            this.buttonOpenClients.Click += new System.EventHandler(this.buttonOpenClients_Click);
            // 
            // buttonOpenDeals
            // 
            this.buttonOpenDeals.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenDeals.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenDeals.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenDeals.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenDeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenDeals.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenDeals.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonOpenDeals.Location = new System.Drawing.Point(12, 444);
            this.buttonOpenDeals.Name = "buttonOpenDeals";
            this.buttonOpenDeals.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenDeals.TabIndex = 2;
            this.buttonOpenDeals.Text = "Сделки";
            this.buttonOpenDeals.UseVisualStyleBackColor = false;
            this.buttonOpenDeals.Click += new System.EventHandler(this.buttonOpenDeals_Click);
            // 
            // buttonOpenSupplySet
            // 
            this.buttonOpenSupplySet.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenSupplySet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenSupplySet.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenSupplySet.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonOpenSupplySet.Location = new System.Drawing.Point(12, 336);
            this.buttonOpenSupplySet.Name = "buttonOpenSupplySet";
            this.buttonOpenSupplySet.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenSupplySet.TabIndex = 3;
            this.buttonOpenSupplySet.Text = "Предложения";
            this.buttonOpenSupplySet.UseVisualStyleBackColor = false;
            this.buttonOpenSupplySet.Click += new System.EventHandler(this.buttonOpenDemands_Click);
            // 
            // buttonOpenSupplies
            // 
            this.buttonOpenSupplies.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenSupplies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenSupplies.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenSupplies.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonOpenSupplies.Location = new System.Drawing.Point(12, 390);
            this.buttonOpenSupplies.Name = "buttonOpenSupplies";
            this.buttonOpenSupplies.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenSupplies.TabIndex = 4;
            this.buttonOpenSupplies.Text = "Потребности";
            this.buttonOpenSupplies.UseVisualStyleBackColor = false;
            this.buttonOpenSupplies.Click += new System.EventHandler(this.buttonOpenSupplies_Click);
            // 
            // buttonOpenRealEstates
            // 
            this.buttonOpenRealEstates.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenRealEstates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenRealEstates.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenRealEstates.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonOpenRealEstates.Location = new System.Drawing.Point(12, 244);
            this.buttonOpenRealEstates.Name = "buttonOpenRealEstates";
            this.buttonOpenRealEstates.Size = new System.Drawing.Size(265, 86);
            this.buttonOpenRealEstates.TabIndex = 5;
            this.buttonOpenRealEstates.Text = "Объекты недвижимости";
            this.buttonOpenRealEstates.UseVisualStyleBackColor = false;
            this.buttonOpenRealEstates.Click += new System.EventHandler(this.buttonOpenRealEstates_Click);
            // 
            // buttonOpenAgents
            // 
            this.buttonOpenAgents.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenAgents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenAgents.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenAgents.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonOpenAgents.Location = new System.Drawing.Point(12, 190);
            this.buttonOpenAgents.Name = "buttonOpenAgents";
            this.buttonOpenAgents.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenAgents.TabIndex = 6;
            this.buttonOpenAgents.Text = "Риелторы";
            this.buttonOpenAgents.UseVisualStyleBackColor = false;
            this.buttonOpenAgents.Click += new System.EventHandler(this.buttonOpenAgents_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::Esoft_Project.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(12, 23);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(265, 108);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Roboto Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHello.Location = new System.Drawing.Point(8, 0);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(71, 20);
            this.labelHello.TabIndex = 7;
            this.labelHello.Text = "Привет!";
            this.labelHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHello.Click += new System.EventHandler(this.labelHello_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 501);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.buttonOpenAgents);
            this.Controls.Add(this.buttonOpenRealEstates);
            this.Controls.Add(this.buttonOpenSupplies);
            this.Controls.Add(this.buttonOpenSupplySet);
            this.Controls.Add(this.buttonOpenDeals);
            this.Controls.Add(this.buttonOpenClients);
            this.Controls.Add(this.Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esoft";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button buttonOpenClients;
        private System.Windows.Forms.Button buttonOpenDeals;
        private System.Windows.Forms.Button buttonOpenSupplySet;
        private System.Windows.Forms.Button buttonOpenSupplies;
        private System.Windows.Forms.Button buttonOpenRealEstates;
        private System.Windows.Forms.Button buttonOpenAgents;
        private System.Windows.Forms.Label labelHello;
    }
}

