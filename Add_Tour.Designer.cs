namespace card_app
{
    partial class Add_Tour
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
            this.openphoto = new System.Windows.Forms.OpenFileDialog();
            this.Name_Tour = new System.Windows.Forms.TextBox();
            this.Coment_Tour = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.PictureBox();
            this.add_photo = new System.Windows.Forms.PictureBox();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.check_photo = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.money_rub = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // openphoto
            // 
            this.openphoto.FileName = "openPhoto";
            // 
            // Name_Tour
            // 
            this.Name_Tour.BackColor = System.Drawing.Color.White;
            this.Name_Tour.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_Tour.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name_Tour.Location = new System.Drawing.Point(279, 32);
            this.Name_Tour.Multiline = true;
            this.Name_Tour.Name = "Name_Tour";
            this.Name_Tour.Size = new System.Drawing.Size(140, 29);
            this.Name_Tour.TabIndex = 2;
            this.Name_Tour.Text = "Название тура...";
            // 
            // Coment_Tour
            // 
            this.Coment_Tour.Location = new System.Drawing.Point(279, 91);
            this.Coment_Tour.Multiline = true;
            this.Coment_Tour.Name = "Coment_Tour";
            this.Coment_Tour.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Coment_Tour.Size = new System.Drawing.Size(354, 89);
            this.Coment_Tour.TabIndex = 3;
            this.Coment_Tour.Text = "Описание...";
            // 
            // add
            // 
            this.add.Image = global::card_app.Properties.Resources.pngegg__2_;
            this.add.Location = new System.Drawing.Point(539, 186);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(180, 85);
            this.add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add.TabIndex = 4;
            this.add.TabStop = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // add_photo
            // 
            this.add_photo.Image = global::card_app.Properties.Resources.pngegg;
            this.add_photo.Location = new System.Drawing.Point(56, 53);
            this.add_photo.Name = "add_photo";
            this.add_photo.Size = new System.Drawing.Size(101, 72);
            this.add_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add_photo.TabIndex = 1;
            this.add_photo.TabStop = false;
            this.add_photo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picture1
            // 
            this.picture1.Location = new System.Drawing.Point(12, 12);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(200, 168);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture1.TabIndex = 0;
            this.picture1.TabStop = false;
            // 
            // check_photo
            // 
            this.check_photo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))));
            this.check_photo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.check_photo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.check_photo.ForeColor = System.Drawing.Color.White;
            this.check_photo.Location = new System.Drawing.Point(57, 131);
            this.check_photo.Name = "check_photo";
            this.check_photo.Size = new System.Drawing.Size(100, 13);
            this.check_photo.TabIndex = 5;
            this.check_photo.Text = "Выберите фото";
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))));
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.price.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.ForeColor = System.Drawing.Color.White;
            this.price.Location = new System.Drawing.Point(279, 204);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(82, 21);
            this.price.TabIndex = 6;
            this.price.Text = "цена...";
            // 
            // money_rub
            // 
            this.money_rub.AutoSize = true;
            this.money_rub.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.money_rub.ForeColor = System.Drawing.Color.White;
            this.money_rub.Location = new System.Drawing.Point(388, 203);
            this.money_rub.Name = "money_rub";
            this.money_rub.Size = new System.Drawing.Size(64, 23);
            this.money_rub.TabIndex = 7;
            this.money_rub.Text = "рублей";
            // 
            // Add_Tour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(781, 534);
            this.Controls.Add(this.money_rub);
            this.Controls.Add(this.price);
            this.Controls.Add(this.check_photo);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Coment_Tour);
            this.Controls.Add(this.Name_Tour);
            this.Controls.Add(this.add_photo);
            this.Controls.Add(this.picture1);
            this.Name = "Add_Tour";
            this.Text = "Add_Tour";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))));
            ((System.ComponentModel.ISupportInitialize)(this.add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openphoto;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.PictureBox add_photo;
        private System.Windows.Forms.TextBox Name_Tour;
        private System.Windows.Forms.TextBox Coment_Tour;
        private System.Windows.Forms.PictureBox add;
        private System.Windows.Forms.TextBox check_photo;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label money_rub;
    }
}