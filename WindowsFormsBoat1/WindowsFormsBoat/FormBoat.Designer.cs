namespace WindowsFormsBoat
{
    partial class FormBoat
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBoat));
			this.pictureBoxBoat = new System.Windows.Forms.PictureBox();
			this.buttonCreate = new System.Windows.Forms.Button();
			this.buttonLeft = new System.Windows.Forms.Button();
			this.buttonRight = new System.Windows.Forms.Button();
			this.buttonDown = new System.Windows.Forms.Button();
			this.buttonUp = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoat)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxBoat
			// 
			this.pictureBoxBoat.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxBoat.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxBoat.Name = "pictureBoxBoat";
			this.pictureBoxBoat.Size = new System.Drawing.Size(917, 580);
			this.pictureBoxBoat.TabIndex = 0;
			this.pictureBoxBoat.TabStop = false;
			this.pictureBoxBoat.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonCreate
			// 
			this.buttonCreate.Location = new System.Drawing.Point(36, 12);
			this.buttonCreate.Name = "buttonCreate";
			this.buttonCreate.Size = new System.Drawing.Size(75, 23);
			this.buttonCreate.TabIndex = 1;
			this.buttonCreate.Text = "Создать";
			this.buttonCreate.UseVisualStyleBackColor = true;
			this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
			// 
			// buttonLeft
			// 
			this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft.BackgroundImage")));
			this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonLeft.Location = new System.Drawing.Point(717, 526);
			this.buttonLeft.Name = "buttonLeft";
			this.buttonLeft.Size = new System.Drawing.Size(48, 42);
			this.buttonLeft.TabIndex = 2;
			this.buttonLeft.UseVisualStyleBackColor = true;
			this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonRight
			// 
			this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRight.BackgroundImage")));
			this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonRight.Location = new System.Drawing.Point(832, 526);
			this.buttonRight.Name = "buttonRight";
			this.buttonRight.Size = new System.Drawing.Size(50, 42);
			this.buttonRight.TabIndex = 3;
			this.buttonRight.UseVisualStyleBackColor = true;
			this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonDown
			// 
			this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDown.BackgroundImage")));
			this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonDown.Location = new System.Drawing.Point(771, 526);
			this.buttonDown.Name = "buttonDown";
			this.buttonDown.Size = new System.Drawing.Size(55, 42);
			this.buttonDown.TabIndex = 4;
			this.buttonDown.UseVisualStyleBackColor = true;
			this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonUp
			// 
			this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
			this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonUp.Location = new System.Drawing.Point(771, 472);
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.Size = new System.Drawing.Size(55, 48);
			this.buttonUp.TabIndex = 5;
			this.buttonUp.UseVisualStyleBackColor = true;
			this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// FormBoat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(917, 580);
			this.Controls.Add(this.buttonUp);
			this.Controls.Add(this.buttonDown);
			this.Controls.Add(this.buttonRight);
			this.Controls.Add(this.buttonLeft);
			this.Controls.Add(this.buttonCreate);
			this.Controls.Add(this.pictureBoxBoat);
			this.Name = "FormBoat";
			this.Text = "Form1";
			this.Click += new System.EventHandler(this.buttonCreate_Click);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoat)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBoat;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
    }
}

