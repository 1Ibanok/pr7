﻿namespace PR7
{
    partial class GoodsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodsForm));
            goodsList = new FlowLayoutPanel();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            back = new Button();
            SuspendLayout();
            // 
            // goodsList
            // 
            goodsList.AutoScroll = true;
            goodsList.BackColor = Color.FromArgb(253, 215, 167);
            goodsList.Font = new Font("Times New Roman", 10.2F);
            goodsList.Location = new Point(12, 12);
            goodsList.Name = "goodsList";
            goodsList.Size = new Size(769, 288);
            goodsList.TabIndex = 0;
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(3, 3, 149);
            back.Font = new Font("Times New Roman", 10.2F);
            back.ForeColor = Color.White;
            back.Location = new Point(613, 306);
            back.Name = "back";
            back.Size = new Size(168, 30);
            back.TabIndex = 7;
            back.Text = "Назад";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // GoodsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(793, 351);
            Controls.Add(back);
            Controls.Add(goodsList);
            Font = new Font("Times New Roman", 10.2F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GoodsForm";
            Text = "Товары";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel goodsList;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private Button back;
    }
}