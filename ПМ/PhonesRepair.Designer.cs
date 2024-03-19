namespace ПМ
{
    partial class PhonesRepair
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhonesRepair));
            this.buttonBack = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataGridViewRepair = new System.Windows.Forms.DataGridView();
            this.comboBoxTypeOfOrders = new System.Windows.Forms.ComboBox();
            this.labelOrders = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepair)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.ForeColor = System.Drawing.Color.Snow;
            this.buttonBack.Location = new System.Drawing.Point(314, 383);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(190, 55);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 52);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.Snow;
            this.buttonUpdate.Location = new System.Drawing.Point(39, 329);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(152, 48);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewRepair
            // 
            this.dataGridViewRepair.AllowUserToAddRows = false;
            this.dataGridViewRepair.AllowUserToOrderColumns = true;
            this.dataGridViewRepair.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridViewRepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRepair.Location = new System.Drawing.Point(39, 12);
            this.dataGridViewRepair.Name = "dataGridViewRepair";
            this.dataGridViewRepair.RowHeadersWidth = 51;
            this.dataGridViewRepair.RowTemplate.Height = 24;
            this.dataGridViewRepair.Size = new System.Drawing.Size(717, 311);
            this.dataGridViewRepair.TabIndex = 8;
            // 
            // comboBoxTypeOfOrders
            // 
            this.comboBoxTypeOfOrders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeOfOrders.FormattingEnabled = true;
            this.comboBoxTypeOfOrders.Location = new System.Drawing.Point(615, 333);
            this.comboBoxTypeOfOrders.Name = "comboBoxTypeOfOrders";
            this.comboBoxTypeOfOrders.Size = new System.Drawing.Size(136, 24);
            this.comboBoxTypeOfOrders.TabIndex = 9;
            // 
            // labelOrders
            // 
            this.labelOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrders.ForeColor = System.Drawing.Color.Snow;
            this.labelOrders.Location = new System.Drawing.Point(498, 329);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(111, 28);
            this.labelOrders.TabIndex = 10;
            this.labelOrders.Text = "Заказы";
            this.labelOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhonesRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOrders);
            this.Controls.Add(this.comboBoxTypeOfOrders);
            this.Controls.Add(this.dataGridViewRepair);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PhonesRepair";
            this.ShowIcon = false;
            this.Text = "RemTech";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PhonesRepair_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.DataGridView dataGridViewRepair;
        private System.Windows.Forms.ComboBox comboBoxTypeOfOrders;
        private System.Windows.Forms.Label labelOrders;
    }
}