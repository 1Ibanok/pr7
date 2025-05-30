using Npgsql;

namespace PR7
{
  
    public partial class GoodsForm : Form
    {
        NpgsqlCommand cmd;
        NpgsqlDataReader reader;
        public GoodsForm()
        {
            InitializeComponent(); 
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximumSize = this.Size;
            LoadSales();
        }

        void LoadSales()
        {
            cmd = new NpgsqlCommand("select * from товары;", MainForm.conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                int productId = Convert.ToInt32(reader["ин"]);
                decimal price = Convert.ToDecimal(reader["цена"]);
                int count = Convert.ToInt32(reader["количество"]);

                NumericUpDown quantityInput = new NumericUpDown();
                quantityInput.Minimum = 1;
                quantityInput.Maximum = 100;
                quantityInput.Value = 1;
                quantityInput.Location = new Point(480, 35);
                quantityInput.Width = 50;

                Button AddToBacket = new Button();
                AddToBacket.BackColor = Color.FromArgb(57, 121, 61);
                AddToBacket.Font = new Font("Times New Roman", 10.2F);
                AddToBacket.ForeColor = Color.White;
                AddToBacket.Location = new Point(480, 105);
                AddToBacket.Name = productId.ToString();
                AddToBacket.Size = new Size(160, 30);
                AddToBacket.TabIndex = 7;
                AddToBacket.Text = "Заказать";
                AddToBacket.UseVisualStyleBackColor = false;
                AddToBacket.Click += (sender, e) => AddToBacket_Click(productId, count, (int)quantityInput.Value, price);

                Panel panel = new Panel();
                panel.Controls.Add(quantityInput);
                panel.Controls.Add(AddToBacket);
                panel.Location = new Point(3, 3);
                panel.Name = "panel";
                panel.Size = new Size(650, 140);
                panel.TabIndex = 1;
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Margin = new Padding(2);

                CreateLabel(panel, new Point(10, 10), "Категория: " + reader[1].ToString());
                CreateLabel(panel, new Point(10, 25), "Артикул: " + reader[2].ToString());
                CreateLabel(panel, new Point(10, 40), "Наименование: " + reader[3].ToString());
                CreateLabel(panel, new Point(10, 55), "Страна: " + reader[4].ToString());
                CreateLabel(panel, new Point(10, 70), "Цена: " + reader[5].ToString());
                CreateLabel(panel, new Point(10, 85), "Количество: " + reader[6].ToString());

                goodsList.Controls.Add(panel);
            }
            cmd.Dispose();
            reader.Close();
        }

        private void CreateLabel(Panel parent, Point pos, string text, string? name = "label")
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = pos;
            label.Name = name;
            label.Size = new Size(80, 15);
            label.TabIndex = 11;
            label.Text = text;
            parent.Controls.Add(label);
        }

        private void AddToBacket_Click(int productId, int count, int inputCount, decimal price)
        {
            if(inputCount > count)
            {
                MessageBox.Show("На складе недостаточное количество данного товара!");
                return;
            }

            if (Buff.goodsDict == null) 
                Buff.goodsDict = new Dictionary<string, string[]>();

            string[] productInfo = { inputCount.ToString(), price.ToString("0.00"), count.ToString() };
            Buff.goodsDict[productId.ToString()] = productInfo;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public static class Buff
    {
        public static Dictionary<string, string[]> goodsDict;
    }
}
