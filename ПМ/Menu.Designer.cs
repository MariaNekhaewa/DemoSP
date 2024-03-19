namespace ПМ
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
            this.labelNameOfProgramm = new System.Windows.Forms.Label();
            this.buttonRepairs = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNameOfProgramm
            // 
            this.labelNameOfProgramm.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameOfProgramm.ForeColor = System.Drawing.Color.Snow;
            this.labelNameOfProgramm.Location = new System.Drawing.Point(3, 0);
            this.labelNameOfProgramm.Name = "labelNameOfProgramm";
            this.labelNameOfProgramm.Size = new System.Drawing.Size(201, 63);
            this.labelNameOfProgramm.TabIndex = 1;
            this.labelNameOfProgramm.Text = "RemTech";
            this.labelNameOfProgramm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRepairs
            // 
            this.buttonRepairs.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonRepairs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRepairs.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRepairs.ForeColor = System.Drawing.Color.Snow;
            this.buttonRepairs.Location = new System.Drawing.Point(8, 194);
            this.buttonRepairs.Name = "buttonRepairs";
            this.buttonRepairs.Size = new System.Drawing.Size(190, 59);
            this.buttonRepairs.TabIndex = 2;
            this.buttonRepairs.Text = "Список телефонов на ремонт";
            this.buttonRepairs.UseVisualStyleBackColor = false;
            this.buttonRepairs.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClients.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClients.ForeColor = System.Drawing.Color.Snow;
            this.buttonClients.Location = new System.Drawing.Point(8, 129);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(190, 59);
            this.buttonClients.TabIndex = 3;
            this.buttonClients.Text = "Форма заполнения на ремонт ";
            this.buttonClients.UseVisualStyleBackColor = false;
            this.buttonClients.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.SlateBlue;
            this.panelButtons.Controls.Add(this.labelNameOfProgramm);
            this.panelButtons.Controls.Add(this.buttonClients);
            this.panelButtons.Controls.Add(this.buttonRepairs);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(208, 450);
            this.panelButtons.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(208, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 450);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelButtons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.ShowIcon = false;
            this.Text = "RemTech";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelNameOfProgramm;
        private System.Windows.Forms.Button buttonRepairs;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

