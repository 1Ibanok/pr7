using System;
using System.Windows.Forms;
using Npgsql;

namespace PR7
{
    public partial class BasketForm : Form
    {

        NpgsqlCommand cmd;
        NpgsqlDataReader reader;
        Dictionary<string, string> customers = new Dictionary<string, string>();
        string productIds;
        decimal sum;
        int newChequeNum;
        public BasketForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximumSize = this.Size;
            LoadGoods();
        }

        public void LoadGoods()
        {
            if (Buff.goodsDict == null || Buff.goodsDict.Count == 0)
            {
                MessageBox.Show("кУпИтЕ чТо-НиБуДь!");
                return;
            }

            //Получение нового номера чека
            {
                cmd = new NpgsqlCommand("select max(чек) + 1 новый_чек from покупки;", MainForm.conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    newChequeNum = Convert.ToInt32(reader[0]);
                }
                cmd.Cancel();
                reader.Close();
                cheque.Text += " " + newChequeNum.ToString();
            }

            //Получение списка покупателей для comboBox
            {
                cmd = new NpgsqlCommand("select ин, фио from покупатели;", MainForm.conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    customers[reader["фио"].ToString()] = reader["ин"].ToString();
                    customer.Items.Add(reader["фио"].ToString());
                }
                cmd.Cancel();
                reader.Close();
            }

            //Получение таблицы товаров и итоговой цены заказа
            {
                productIds = string.Join(",", Buff.goodsDict.Keys);
                string query = $"select *, sum(цена) over() сумма from товары where ин in ({productIds})";

                cmd = new NpgsqlCommand(query, MainForm.conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string productId = reader["ин"].ToString();
                    string[] productInfo = Buff.goodsDict[productId];
                    int q = int.Parse(productInfo[0]);
                    decimal p = decimal.Parse(productInfo[1]);
                    decimal tp = q * p;

                    Panel productPanel = new Panel();
                    productPanel.Location = new Point(3, 3);
                    productPanel.Name = "productPanel";
                    productPanel.Size = new Size(400, 120);
                    productPanel.TabIndex = 0;
                    productPanel.BorderStyle = BorderStyle.FixedSingle;
                    productPanel.Margin = new Padding(2);

                    CreateLabel(productPanel, new Point(10, 10), "Категория: " + reader[1].ToString());
                    CreateLabel(productPanel, new Point(10, 35), "Наименование: " + reader[3].ToString());
                    CreateLabel(productPanel, new Point(10, 60), $"Цена: {p} * {q} = {tp}");
                    goodsList.Controls.Add(productPanel);
                    sum += tp;
                }

                summ.Text = "Сумма: " + sum.ToString();
                cmd.Cancel();
                reader.Close();
            }
         
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
        private void regAnOrder_Click(object sender, EventArgs e)
        {
            if (Buff.goodsDict == null || Buff.goodsDict.Count == 0){
                MessageBox.Show("кУпИтЕ чТо-НиБуДь!");
                return;
            }
            if(customer.Text == "") {
                MessageBox.Show("Выберите покупателя!");
                return;
            }
            if (status.Text == ""){
                MessageBox.Show("Выберите статус!");
                return;
            }
            if (priority.Text == ""){
                MessageBox.Show("Выберите приоритет!");
                return;
            }
            DateTime currentDate = DateTime.Now.Date;
            string query = $"insert into покупки (чек, товар, количество, покупатель, дата_покупки, сумма, дата_доставки, исполнитель_доставки, статус, приоритет) values ";
            foreach(var item in Buff.goodsDict)
            {
                query += $"('{newChequeNum}', '{item.Key}', {item.Value[0]}, {customers[customer.Text]}, date(now()), {(int.Parse(item.Value[0]) * decimal.Parse(item.Value[1])).ToString().Replace(',','.')}, '{deliverDate.Value.ToString("yy-MM-dd")}', '', '{status.Text}', '{priority.Text}'),";
            }
            query = query.Remove(query.Length - 1);
            query += ";";

            cmd = new NpgsqlCommand(query, MainForm.conn);
            cmd.ExecuteNonQuery();

            query = "";
            foreach (var item in Buff.goodsDict)
            {
                query += $"update товары set количество = {int.Parse(item.Value[2]) - int.Parse(item.Value[0])} where ин = {item.Key};";
            }
            query = query.Remove(query.Length - 1);
            query += ";";

            cmd = new NpgsqlCommand(query, MainForm.conn);
            cmd.ExecuteNonQuery();
            Buff.goodsDict.Clear();
            MessageBox.Show("Заказ оформлен!");
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
