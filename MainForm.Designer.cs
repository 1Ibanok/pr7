using System.Drawing;

namespace PR7
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            label1 = new Label();
            saveBtn = new Button();
            pictureBoxLogo = new PictureBox();
            goods = new Button();
            basket = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(253, 215, 167);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Font = new Font("Segoe UI", 9F);
            dataGridView1.Location = new Point(11, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(1050, 339);
            dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(253, 215, 167);
            comboBox1.Font = new Font("Times New Roman", 10.2F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(736, 50);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(287, 27);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F);
            label1.Location = new Point(736, 28);
            label1.Name = "label1";
            label1.Size = new Size(143, 19);
            label1.TabIndex = 2;
            label1.Text = "Выберите таблицу:";
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(3, 3, 149);
            saveBtn.Font = new Font("Times New Roman", 10.2F);
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(736, 83);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(287, 32);
            saveBtn.TabIndex = 3;
            saveBtn.Text = "Сохранить";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(11, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(114, 103);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 5;
            pictureBoxLogo.TabStop = false;
            // 
            // goods
            // 
            goods.BackColor = Color.FromArgb(3, 3, 149);
            goods.Font = new Font("Times New Roman", 10.2F);
            goods.ForeColor = Color.White;
            goods.Location = new Point(131, 67);
            goods.Name = "goods";
            goods.Size = new Size(127, 48);
            goods.TabIndex = 6;
            goods.Text = "Товары";
            goods.UseVisualStyleBackColor = false;
            goods.Click += goods_Click;
            // 
            // basket
            // 
            basket.BackColor = Color.FromArgb(3, 3, 149);
            basket.Font = new Font("Times New Roman", 10.2F);
            basket.ForeColor = Color.White;
            basket.Location = new Point(131, 14);
            basket.Name = "basket";
            basket.Size = new Size(127, 47);
            basket.TabIndex = 7;
            basket.Text = "Корзина";
            basket.UseVisualStyleBackColor = false;
            basket.Click += basket_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1078, 472);
            Controls.Add(basket);
            Controls.Add(goods);
            Controls.Add(pictureBoxLogo);
            Controls.Add(saveBtn);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Главная";
            FormClosing += MainForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private Button goods;
        private Button basket;
    }
}
