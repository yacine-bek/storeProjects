using System.DirectoryServices.ActiveDirectory;

namespace storeProjects
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            ReadProducts();
            nbr = producte_lenght();
            panel_add.Visible = false;
            panel_F2.Visible = false;
            special_panel_filling();
            this.KeyDown += new KeyEventHandler(YourForm_KeyDown);
            this.Focus();
            input_barcode.Focus();
            this.ActiveControl = null;
            //-tryyyyyyyyyyy
            this.Click += new EventHandler(panel_F1_Click);
        }


        private void panel_F1_Click(object sender, EventArgs e)
        {
            // Cast sender to Panel to access the MouseEventArgs
            Panel panel = sender as Panel;

            // Get the mouse position from the event arguments
            MouseEventArgs me = e as MouseEventArgs;
            this.ActiveControl = null;
            panel_add.Visible = false;
        }





        //dont need it any more
        private void panel_F2_Paint(object sender, PaintEventArgs e)
        {
        }
        private void button_F1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            panel_F1.Visible = true;
            panel_F2.Visible = false;
            update_total_price_c1();
        }
        private void button_F2_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            panel_F1.Visible = false;
            panel_F2.Visible = true;
            update_total_price_c2();
        }
        private void add_button_Click(object sender, EventArgs e)
        {
            panel_add.Visible = true;
            this.ActiveControl = null;
        }

        private void SaveProducts()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Products.dat");
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                for (int i = 0; i < products.Length; i++)
                {
                    string price, name, code, special;

                    if (products[i] == null)
                    {
                        price = "";
                        name = "";
                        code = "";
                        special = "";
                    }
                    else
                    {
                        price = products[i].price.ToString();
                        name = products[i].name.ToString();
                        code = products[i].barcode.ToString();
                        special = products[i].special.ToString();
                    }


                    // Write the length of each string followed by the string itself
                    writer.Write(code.Length);
                    writer.Write(code.ToCharArray());

                    writer.Write(name.Length);
                    writer.Write(name.ToCharArray());

                    writer.Write(price.Length);
                    writer.Write(price.ToCharArray());

                    writer.Write(special.Length);
                    writer.Write(special.ToCharArray());
                }
            }
        }
        private void ReadProducts()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Products.dat");
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    for (int i = 0; i < products.Length; i++)
                    {
                        // Read the length of each string and then the string itself
                        int codeLength = reader.ReadInt32();
                        String code = new string(reader.ReadChars(codeLength));


                        int nameLength = reader.ReadInt32();
                        String name = new string(reader.ReadChars(nameLength));

                        int priceLength = reader.ReadInt32();
                        string tmp = new string(reader.ReadChars(priceLength));
                        double price = Convert.ToDouble(tmp);

                        int specialLength = reader.ReadInt32();
                        tmp = new string(reader.ReadChars(specialLength));
                        Boolean special = Convert.ToBoolean(tmp);

                        products[i] = new Products(name, price, code, special);

                    }
                }
            }
            catch (Exception)
            {
                // Erooooree
            }
        }
        private int producte_lenght()
        {
            ReadProducts();
            int lenght = 0;
            for (int j = 0; j < products.Length; j++)
            {
                if (products[j] != null)
                {
                    lenght++;
                }
            }
            return lenght;
        }

        private void cancel_adding_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            barcode_input.Text = "";
            name_input.Text = "";
            price_input.Text = "";
            special_check.Checked = false;
            panel_add.Visible = false;
        }

        private void button_done_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            try
            {
                if (barcode_input.Text == "" || name_input.Text == "" || price_input.Text == "")
                {
                    error_screen("you gotta fill every thing HAHA", "Fill this shit");
                }
                else if (special_check.Checked == true && (Convert.ToDouble(barcode_input.Text)<9 || Convert.ToDouble(barcode_input.Text)>100))
                {
                    error_screen("The special bar code must have Two degits", "This is a special Product!!");
                }
                else
                {
                    products[nbr] = new Products(name_input.Text, Convert.ToDouble(price_input.Text), barcode_input.Text, special_check.Checked);
                    if (products[nbr].special == true)
                    {
                        special_panel_filling();
                    }
                    nbr++;
                    barcode_input.Text = "";
                    name_input.Text = "";
                    price_input.Text = "";
                    special_check.Checked = false;
                    panel_add.Visible = false;
                    input_barcode.Text = "";
                    SaveProducts();
                }
            }
            catch
            {
                error_screen("You've inserted wrong data", "Wrong Data");
            }
        }

        private void YourForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Subtract:
                    button_sub.PerformClick();
                    break;
                case Keys.Add:
                    button_add.PerformClick();
                    break;
                case Keys.Escape:
                    input_barcode.Focus();
                    break;
                case Keys.F1:
                    button_F1.PerformClick();
                    break;
                case Keys.F2:
                    button_F2.PerformClick();
                    break;
                case Keys.Space:
                    input_barcode.Focus();
                    break;
                case Keys.Enter:

                    break;
            }
        }

        private bool check_product_existence(String bcode)
        {
            for (int i = 0; i < producte_lenght(); i++)
            {
                if (bcode == products[i].barcode)
                {
                    return true;
                }
            }
            return false;
        }

        private void error_screen(String message, String title)
        {
            MessageBox.Show(message, title);
            this.ActiveControl = null;
        }
        //trash hhh ----------------------
        public class Products
        {
            public double price;
            public string name;
            public string barcode;
            public bool special;
            public Products(string name, double price, string barcode, bool special)
            {
                this.name = name;
                this.barcode = barcode;
                this.price = price;
                this.special = special;
            }
        }
        public class Clent : Products
        {
            public int quantity;
            public Clent(string name, double price, string barcode, bool special, int quantity) : base(name, price, barcode, special)
            {
                this.quantity = quantity;
            }
        }
        private Products[] products = new Products[100];
        private Clent[] curent_client1 = new Clent[100];
        private Clent[] curent_client2 = new Clent[100];
        private int c1 = 0;
        private int c2 = 0;
        private int nbr = 0;
        //lkhdmaaaaaaaaaa
        private bool check_curent_client_1(string code)
        {
            for (int j = 0; j < c1; j++)
            {
                if (code == curent_client1[j].barcode)
                {
                    curent_client1[j].quantity++;
                    input_barcode.Text = "";
                    return true;
                }
            }
            return false;
        }
        private bool check_curent_client_2(string code)
        {
            for (int j = 0; j < c2; j++)
            {
                if (code == curent_client2[j].barcode)
                {
                    curent_client2[j].quantity++;
                    input_barcode.Text = "";
                    return true;
                }
            }
            return false;
        }




        private void updateBox1()
        {
            groupBox_F1.Controls.Clear();
            int j = 0;
            for (int i = 0; i < c1; i++)
            {
                if (curent_client1[i].quantity!=0)
                {
                    creatGroupbox1(curent_client1[i].name, curent_client1[i].quantity, curent_client1[i].price, j + 1, j , i);
                    j++;
                }
            }
        }
        private void updateBox2()
        {
            groupBox_F2.Controls.Clear();
            int j = 0;
            for (int i = 0; i < c2; i++)
            {
                if (curent_client2[i].quantity != 0)
                {
                    creatGroupbox2(curent_client2[i].name, curent_client2[i].quantity, curent_client2[i].price, j + 1, j , i);
                    j++;
                }
            }
        }

        private void creatGroupbox1(string n, int q, double p, int clasment, int j,int i)
        {
            //creat group box
            GroupBox groupbox = new GroupBox();
            groupbox.Text = "";
            groupbox.Size = new Size(390, 40);
            if (j < 12)
            {
                groupbox.Location = new Point(0, 40 * j);
            }
            else
            {
                groupbox.Location = new Point(410, (40 * j) - 40 * 11);
            }

            //creat lable
            Label label = new Label();
            label.Text = clasment + ".";
            label.Size = new Size(16, 15);
            label.Location = new Point(0, 12);
            groupbox.Controls.Add(label);

            //creat name product text box
            TextBox name = new TextBox();
            name.Text = n;
            name.Size = new Size(187, 38);
            name.Font = new Font("Arial", 17);
            name.Location = new Point(22, 8);
            name.ReadOnly = true;
            groupbox.Controls.Add(name);

            //creat quantity product text box
            TextBox quantity = new TextBox();
            quantity.Text = q.ToString();
            quantity.Size = new Size(39, 38);
            quantity.Location = new Point(208, 8);
            quantity.Font = new Font("Arial", 17);
            quantity.ReadOnly = true;
            groupbox.Controls.Add(quantity);

            //creat price product text box
            TextBox price = new TextBox();
            price.Text = (q * p).ToString() + " DA";
            price.Size = new Size(108, 38);
            price.Location = new Point(245, 8);
            price.Font = new Font("Arial", 17);
            price.ReadOnly = true;
            groupbox.Controls.Add(price);

            //creat delete button
            Button button = new Button();
            button.Text = "X";
            button.Size = new Size(40, 40);
            button.Location = new Point(350, 5);
            button.Click += (sender, e) => { curent_client1[i].quantity = 0; updateBox1(); update_total_price_c1(); this.ActiveControl = null; };
            groupbox.Controls.Add(button);

            groupBox_F1.Controls.Add(groupbox);
        }
        
        private void creatGroupbox2(string n, int q, double p, int clasment, int j,int i)
        {
            //creat group box
            GroupBox groupbox = new GroupBox();
            groupbox.Text = "";
            groupbox.Size = new Size(390, 40);
            if (j < 12)
            {
                groupbox.Location = new Point(0, 40 * j);
            }
            else
            {
                groupbox.Location = new Point(410, (40 * j) - 40 * 11);
            }

            //creat lable
            Label label = new Label();
            label.Text = clasment + ".";
            label.Size = new Size(16, 15);
            label.Location = new Point(0, 12);
            groupbox.Controls.Add(label);

            //creat name product text box
            TextBox name = new TextBox();
            name.Text = n;
            name.Size = new Size(187, 38);
            name.Font = new Font("Arial", 17);
            name.Location = new Point(22, 8);
            name.ReadOnly = true;
            groupbox.Controls.Add(name);

            //creat quantity product text box
            TextBox quantity = new TextBox();
            quantity.Text = q.ToString();
            quantity.Size = new Size(39, 38);
            quantity.Location = new Point(208, 8);
            quantity.Font = new Font("Arial", 17);
            quantity.ReadOnly = true;
            groupbox.Controls.Add(quantity);

            //creat price product text box
            TextBox price = new TextBox();
            price.Text = (q * p).ToString() + " DA";
            price.Size = new Size(108, 38);
            price.Location = new Point(245, 8);
            price.Font = new Font("Arial", 17);
            price.ReadOnly = true;
            groupbox.Controls.Add(price);

            //creat delete button
            Button button = new Button();
            button.Text = "X";
            button.Size = new Size(40, 40);
            button.Location = new Point(350, 5);
            button.Click += (sender, e) => { curent_client2[i].quantity = 0; updateBox2(); update_total_price_c2(); this.ActiveControl = null; };
            groupbox.Controls.Add(button);


            groupBox_F2.Controls.Add(groupbox);
        }

        private void update_total_price_c1()
        {
            double total = 0;
            for (int j = 0; j < c1; j++)
            {
                total += curent_client1[j].price * curent_client1[j].quantity;
            }
            price_output.Text = total.ToString() + " DA";
        }

        private void update_total_price_c2()
        {
            double total = 0;
            for (int j = 0; j < c2; j++)
            {
                total += curent_client2[j].price * curent_client2[j].quantity;
            }
            price_output.Text = total.ToString() + " DA";
        }

        private void input_barcode_TextChanged_1(object sender, EventArgs e)
        {
            if (input_barcode.Text == "+")
            {
                this.ActiveControl = null;
                input_barcode.Text = "";
            }
            else if (input_barcode.Text == "-")
            {
                this.ActiveControl = null;
                input_barcode.Text = "";
            }
            ReadProducts();
            if (panel_F1.Visible == true)
            {
                if (check_product_existence(input_barcode.Text) == true)
                {
                    if (check_curent_client_1(input_barcode.Text) == false)
                    {
                        for (int j = 0; j < producte_lenght(); j++)
                        {
                            if (input_barcode.Text == products[j].barcode)
                            {
                                curent_client1[c1] = new Clent(products[j].name, Convert.ToDouble(products[j].price), products[j].barcode, products[j].special, 1);

                                c1++;
                                input_barcode.Text = "";
                            }
                        }
                    }
                    updateBox1();
                    update_total_price_c1();
                }
            }
            else
            {
                if (check_product_existence(input_barcode.Text) == true)
                {
                    if (check_curent_client_2(input_barcode.Text) == false)
                    {
                        for (int j = 0; j < producte_lenght(); j++)
                        {
                            if (input_barcode.Text == products[j].barcode)
                            {
                                curent_client2[c2] = new Clent(products[j].name, Convert.ToDouble(products[j].price), products[j].barcode, products[j].special, 1);

                                c2++;
                                input_barcode.Text = "";
                            }
                        }
                    }
                    updateBox2();
                    update_total_price_c2();
                }
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (panel_F1.Visible == true)
            {
                try
                {
                    curent_client1[c1 - 1].quantity++;
                    updateBox1();
                    update_total_price_c1();
                }
                catch
                {
                    //there is a problem
                }
                this.ActiveControl = null;
            }
            else
            {
                try
                {
                    curent_client2[c2 - 1].quantity++;
                    updateBox2();
                    update_total_price_c2();
                }
                catch
                {
                    //there is a problem
                }
                this.ActiveControl = null;
            }

        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            if (panel_F1.Visible == true)
            {
                try
                {
                    if (curent_client1[c1 - 1].quantity == 1)
                    {
                        c1--;
                    }
                    else
                    {
                        curent_client1[c1 - 1].quantity--;
                    }
                    updateBox1();
                    update_total_price_c1();
                }
                catch
                {
                    //there is a problem
                }
                this.ActiveControl = null;
            }
            else
            {
                try
                {
                    if (curent_client2[c2 - 1].quantity == 1)
                    {
                        c2--;
                    }
                    else
                    {
                        curent_client2[c2 - 1].quantity--;
                    }
                    updateBox2();
                    update_total_price_c2();
                }
                catch
                {
                    //there is a problem
                }
                this.ActiveControl = null;
            }
        }

        private void special_panel_filling()
        {
            int k = 0;
            for (int i = 0; i < producte_lenght(); i++)
            {
                if (products[i].special == true)
                {
                    TextBox special = new TextBox();
                    special.Text = products[i].name + "   " + products[i].price.ToString() + " DA";
                    special.Size = new Size(270, 40);
                    special.Font = new Font("Arial", 17);
                    special.Location = new Point(0, 35 * k);
                    special.ReadOnly = true;
                    groupBox_special.Controls.Add(special);
                    k++;
                }
            }
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            if (panel_F1.Visible == true)
            {
                groupBox_F1.Controls.Clear();
                c1 = 0;
                update_total_price_c1();
            }
            else
            {
                groupBox_F2.Controls.Clear();
                c2 = 0;
                update_total_price_c2();
            }
        }

        private void special_check_CheckedChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void price_output_TextChanged(object sender, EventArgs e)
        {
        }
    }
}