namespace card_app
{
    partial class _default
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_default));
            this.Tour = new System.Windows.Forms.Label();
            this.Clients = new System.Windows.Forms.Label();
            this.staff = new System.Windows.Forms.Label();
            this.Archives = new System.Windows.Forms.Label();
            this.toursBindingSource = new System.Windows.Forms.BindingSource(this.components);
           
            
          
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
        
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.create_new_Tour = new System.Windows.Forms.PictureBox();
            this.LOGO = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.create_new_Tour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOGO)).BeginInit();
            this.SuspendLayout();
            // 
            // Tour
            // 
            this.Tour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tour.AutoSize = true;
            this.Tour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tour.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tour.ForeColor = System.Drawing.Color.White;
            this.Tour.Location = new System.Drawing.Point(118, 127);
            this.Tour.Name = "Tour";
            this.Tour.Size = new System.Drawing.Size(51, 23);
            this.Tour.TabIndex = 1;
            this.Tour.Text = "Туры";
            this.Tour.Click += new System.EventHandler(this.Tour_Click);
            // 
            // Clients
            // 
            this.Clients.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Clients.AutoSize = true;
            this.Clients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clients.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clients.ForeColor = System.Drawing.Color.White;
            this.Clients.Location = new System.Drawing.Point(253, 127);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(79, 23);
            this.Clients.TabIndex = 2;
            this.Clients.Text = "Клиенты";
            // 
            // staff
            // 
            this.staff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.staff.AutoSize = true;
            this.staff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staff.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.staff.ForeColor = System.Drawing.Color.White;
            this.staff.Location = new System.Drawing.Point(459, 127);
            this.staff.Name = "staff";
            this.staff.Size = new System.Drawing.Size(100, 23);
            this.staff.TabIndex = 3;
            this.staff.Text = "Сотрудники";
            this.staff.Click += new System.EventHandler(this.staff_Click);
            // 
            // Archives
            // 
            this.Archives.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Archives.AutoSize = true;
            this.Archives.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Archives.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Archives.ForeColor = System.Drawing.Color.White;
            this.Archives.Location = new System.Drawing.Point(672, 127);
            this.Archives.Name = "Archives";
            this.Archives.Size = new System.Drawing.Size(105, 23);
            this.Archives.TabIndex = 4;
            this.Archives.Text = "Архив туров";
            // 
            // toursBindingSource
            // 
            this.toursBindingSource.DataMember = "Tours";
            // 
            // travel_companyDataSet1
            // 
            // 
            // toursTableAdapter
            // 
            // 
            // travel_companyDataSet2
            // 
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            // 
            // staffTableAdapter
            // 
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktopPanel.AutoScroll = true;
            this.panelDesktopPanel.Controls.Add(this.create_new_Tour);
            this.panelDesktopPanel.Location = new System.Drawing.Point(12, 169);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(914, 358);
            this.panelDesktopPanel.TabIndex = 5;
            // 
            // create_new_Tour
            // 
            this.create_new_Tour.Image = global::card_app.Properties.Resources.pngegg__2_;
            this.create_new_Tour.Location = new System.Drawing.Point(367, 3);
            this.create_new_Tour.Name = "create_new_Tour";
            this.create_new_Tour.Size = new System.Drawing.Size(111, 55);
            this.create_new_Tour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.create_new_Tour.TabIndex = 0;
            this.create_new_Tour.TabStop = false;
            this.create_new_Tour.Click += new System.EventHandler(this.create_new_Tour_Click);
            // 
            // LOGO
            // 
            this.LOGO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LOGO.Image = global::card_app.Properties.Resources.unnamed;
            this.LOGO.Location = new System.Drawing.Point(-130, -3);
            this.LOGO.Name = "LOGO";
            this.LOGO.Size = new System.Drawing.Size(1163, 115);
            this.LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LOGO.TabIndex = 0;
            this.LOGO.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // _default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(928, 558);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.Archives);
            this.Controls.Add(this.staff);
            this.Controls.Add(this.Clients);
            this.Controls.Add(this.Tour);
            this.Controls.Add(this.LOGO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_default";
            this.Text = "Belanja Sekarang";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this._default_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.panelDesktopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.create_new_Tour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOGO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LOGO;
        private System.Windows.Forms.Label Tour;
        private System.Windows.Forms.Label Clients;
        private System.Windows.Forms.Label staff;
        private System.Windows.Forms.Label Archives;

        private System.Windows.Forms.BindingSource toursBindingSource;


        private System.Windows.Forms.BindingSource staffBindingSource;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox create_new_Tour;
    }
}

