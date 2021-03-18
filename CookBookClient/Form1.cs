using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


namespace CookBookClient
{
    public partial class Form1 : Form
    {
        private IPAddress iP;
        private IPEndPoint IPEnd;
        private Socket client;
        private string adress = "127.0.0.1";
        private int port = 1025;
        private string products;
        private List<string> recipes;
        private int countRecipes = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectServer()
        {
            iP = IPAddress.Parse(adress);
            IPEnd = new IPEndPoint(iP, port);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client.Connect(IPEnd);
                MessageBox.Show("Подключение к серверу прошло успешно!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            ConnectServer();
            buttonCloseConnect.Enabled = true;
            buttonConnect.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonCloseConnect.Enabled = false;
            buttonSendProducts.Enabled = false;
        }

        private void textBoxProducts_TextChanged(object sender, EventArgs e)
        {
            if (client.Connected)
                buttonSendProducts.Enabled = true;
        }

        private void buttonCloseConnect_Click(object sender, EventArgs e)
        {
            client.Close();
            buttonConnect.Enabled = true;
            buttonCloseConnect.Enabled = false;
            buttonSendProducts.Enabled = false;
        }

        private void buttonSendProducts_Click(object sender, EventArgs e)
        {
            if (listBoxRecipes.Items.Count > 0)
            {
                listBoxRecipes.Items.Clear();
                recipes.Clear();
            }
            products = textBoxProducts.Text;
            textBoxProducts.Text = "";
            if (!products.Equals(""))
            {
                SendProducts();
            }
            else
            {
                MessageBox.Show("Введите перечень продуктов!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Task task = Task.Run(() => ReceiveRecipes());
            task.Wait();
            if (recipes.Count == 1 && recipes[0] == "Нет подходящих рецептов")
                MessageBox.Show("Нет подходящих рецептов!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in recipes)
                {
                    listBoxRecipes.Items.Add(item);
                    listBoxRecipes.Items.Add("\n\n");
                    countRecipes++;
                    labelCountRecipes.Text = countRecipes.ToString();
                }
            }
        }

        private void SendProducts()
        {
            Task.Run(() =>
            {
                try
                {
                    while (true)
                    {
                        byte[] buff = Encoding.Unicode.GetBytes(products);
                        client.Send(BitConverter.GetBytes(buff.Length));
                        client.Send(buff);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            });
        }

        private void ReceiveRecipes()
        {
            recipes = new List<string>();
            do
            {

                byte[] buff = new byte[4];
                client.Receive(buff);
                int length = BitConverter.ToInt32(buff, 0);
                byte[] data = new byte[length];
                client.Receive(data);
                string prod = Encoding.Unicode.GetString(data);
                recipes.Add(prod);
            } while (client.Available > 0);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (client.Connected)
            {
                client.Close();
                Close();
            }
            else
                Close();
        }
    }
}
