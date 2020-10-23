namespace _123
{
    partial class Form1
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.button1 = new System.Windows.Forms.Button();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      this.SuspendLayout();
      // 
      // progressBar1
      // 
      resources.ApplyResources(this.progressBar1, "progressBar1");
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
      // 
      // button1
      // 
      this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      resources.ApplyResources(this.button1, "button1");
      this.button1.Name = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "Безымянный.png");
      // 
      // pictureBox2
      // 
      resources.ApplyResources(this.pictureBox2, "pictureBox2");
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.TabStop = false;
      // 
      // textBox1
      // 
      resources.ApplyResources(this.textBox1, "textBox1");
      this.textBox1.Name = "textBox1";
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
      // 
      // Form1
      // 
      this.AcceptButton = this.button1;
      this.AllowDrop = true;
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.CancelButton = this.button1;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.progressBar1);
      this.KeyPreview = true;
      this.Name = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.TextBox textBox1;
  }
}

