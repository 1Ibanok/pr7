namespace PR7
{
    partial class BasketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasketForm));
            back = new Button();
            goodsList = new FlowLayoutPanel();
            summ = new Label();
            regAnOrder = new Button();
            customer = new ComboBox();
            deliverDate = new DateTimePicker();
            label1 = new Label();
            status = new ComboBox();
            priority = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cheque = new Label();
            SuspendLayout();
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(3, 3, 149);
            back.Font = new Font("Times New Roman", 10.2F);
            back.ForeColor = Color.White;
            back.Location = new Point(486, 197);
            back.Margin = new Padding(3, 2, 3, 2);
            back.Name = "back";
            back.Size = new Size(147, 26);
            back.TabIndex = 9;
            back.Text = "Назад";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // goodsList
            // 
            goodsList.AutoScroll = true;
            goodsList.BackColor = Color.FromArgb(253, 215, 167);
            goodsList.Font = new Font("Times New Roman", 10.2F);
            goodsList.Location = new Point(14, 10);
            goodsList.Margin = new Padding(3, 2, 3, 2);
            goodsList.Name = "goodsList";
            goodsList.Size = new Size(466, 309);
            goodsList.TabIndex = 8;
            // 
            // summ
            // 
            summ.AutoSize = true;
            summ.Location = new Point(492, 137);
            summ.Name = "summ";
            summ.Size = new Size(51, 15);
            summ.TabIndex = 3;
            summ.Text = "Сумма: ";
            // 
            // regAnOrder
            // 
            regAnOrder.BackColor = Color.FromArgb(3, 3, 149);
            regAnOrder.Font = new Font("Times New Roman", 10.2F);
            regAnOrder.ForeColor = Color.White;
            regAnOrder.Location = new Point(486, 167);
            regAnOrder.Margin = new Padding(3, 2, 3, 2);
            regAnOrder.Name = "regAnOrder";
            regAnOrder.Size = new Size(147, 26);
            regAnOrder.TabIndex = 10;
            regAnOrder.Text = "Выполнить заказ";
            regAnOrder.UseVisualStyleBackColor = false;
            regAnOrder.Click += regAnOrder_Click;
            // 
            // customer
            // 
            customer.FormattingEnabled = true;
            customer.Location = new Point(580, 7);
            customer.Margin = new Padding(3, 2, 3, 2);
            customer.Name = "customer";
            customer.Size = new Size(217, 23);
            customer.TabIndex = 11;
            // 
            // deliverDate
            // 
            deliverDate.Location = new Point(492, 112);
            deliverDate.Margin = new Padding(3, 2, 3, 2);
            deliverDate.Name = "deliverDate";
            deliverDate.Size = new Size(167, 23);
            deliverDate.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(492, 10);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 13;
            label1.Text = "Покупатель:";
            // 
            // status
            // 
            status.FormattingEnabled = true;
            status.Items.AddRange(new object[] { "новый", "подготовка", "в пути", "доставлен" });
            status.Location = new Point(580, 32);
            status.Margin = new Padding(3, 2, 3, 2);
            status.Name = "status";
            status.Size = new Size(133, 23);
            status.TabIndex = 14;
            // 
            // priority
            // 
            priority.FormattingEnabled = true;
            priority.Items.AddRange(new object[] { "низкий", "средний", "высокий", "срочный" });
            priority.Location = new Point(580, 58);
            priority.Margin = new Padding(3, 2, 3, 2);
            priority.Name = "priority";
            priority.Size = new Size(133, 23);
            priority.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(492, 35);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 16;
            label2.Text = "Статус:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(491, 60);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 17;
            label3.Text = "Приоритет:";
            // 
            // cheque
            // 
            cheque.AutoSize = true;
            cheque.Location = new Point(492, 86);
            cheque.Name = "cheque";
            cheque.Size = new Size(33, 15);
            cheque.TabIndex = 18;
            cheque.Text = "Чек: ";
            // 
            // BasketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(832, 330);
            Controls.Add(cheque);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(priority);
            Controls.Add(status);
            Controls.Add(label1);
            Controls.Add(deliverDate);
            Controls.Add(customer);
            Controls.Add(regAnOrder);
            Controls.Add(back);
            Controls.Add(summ);
            Controls.Add(goodsList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "BasketForm";
            Text = "Корзина";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private FlowLayoutPanel goodsList;
        private Label summ;
        private Button regAnOrder;
        private ComboBox customer;
        private DateTimePicker deliverDate;
        private Label label1;
        private ComboBox status;
        private ComboBox priority;
        private Label label2;
        private Label label3;
        private Label cheque;
    }
}