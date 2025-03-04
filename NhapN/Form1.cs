namespace NhapN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool is_ngto(int n)
        {
            if (n == 0 || n == 1)
            {
                return false;
            }
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        bool is_socp(int n)
        {
            if(n > 0)
            {
                int sqrt = (int)Math.Sqrt(n);
                return sqrt * sqrt == n;
            }
            return false;
            
        }

        bool is_sohh(int n)
        {
            if(n > 0)
            {
                int sum = 0;
                for (int i = 1; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        sum += i;
                    }
                }
                return sum == n;
            }
            return false;
        }


        void showDisplay()
        {
            try
            {
                int n;
                n = Convert.ToInt32(tbSoN.Text);

                for (int i = 0; i < n; i++)
                {
                    if (is_ngto(i))
                    {
                        lbsoNgto.Text += " " + Convert.ToString(i);
                    }
                    if (is_socp(i))
                    {
                        lbsoCP.Text += " " + Convert.ToString(i);
                    }
                    if (is_sohh(i))
                    {
                        lbsoHh.Text += " " + Convert.ToString(i);
                    }

                }

            }
            catch
            {
                MessageBox.Show("Nhap sai, moi nhap lai!");
            }
        }

        private void tbSoN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btHienthi_Click(sender, e);
            }
        }

        private void btHienthi_Click(object sender, EventArgs e)
        {
            showDisplay();
        }

    }
}
