namespace Kółki_krzyżyk
{
    public partial class Form1 : Form
    {

        char activePlayer = 'O';

        public Form1()
        {
            InitializeComponent();
            lblAktywnyGracz.Text = "Aktywny gracz: " + activePlayer;
        }

        void SwitchPlayer()
        {
            activePlayer = (activePlayer == 'O') ? 'X' : 'O';
            lblAktywnyGracz.Text = "Aktywny gracz: " + activePlayer;
        }

        void Wygrana()
        {
            btnLewoGora1.Enabled = false;
            btnGora2.Enabled = false;
            btnPrawoGora3.Enabled = false;
            btnLewo4.Enabled = false;
            btnSrodek5.Enabled = false;
            btnPrawo6.Enabled = false;
            btnLewoDol7.Enabled = false;
            btnDol8.Enabled = false;
            btnPrawoDol9.Enabled = false;
        }

        bool CheckResult()
        {
            if (btnLewoGora1.Text != String.Empty &&
                btnGora2.Text != String.Empty &&
                btnPrawoGora3.Text != String.Empty)
            {
                if (btnLewoGora1.Text == btnGora2.Text && btnGora2.Text == btnPrawoGora3.Text)
                {
                    return true;
                }
            }

            if (btnLewo4.Text != String.Empty &&
                btnSrodek5.Text != String.Empty &&
                btnPrawo6.Text != String.Empty)
            {
                if (btnLewo4.Text == btnSrodek5.Text && btnSrodek5.Text == btnPrawo6.Text)
                {
                    return true;
                }
            }

            if (btnLewoDol7.Text != String.Empty &&
                btnDol8.Text != String.Empty &&
                btnPrawoDol9.Text != String.Empty)
            {
                if (btnLewoDol7.Text == btnDol8.Text && btnDol8.Text == btnPrawoDol9.Text)
                {
                    return true;
                }
            }

            if (btnLewoGora1.Text != String.Empty &&
                btnLewo4.Text != String.Empty &&
                btnLewoDol7.Text != String.Empty)
            {
                if (btnLewoGora1.Text == btnLewo4.Text && btnLewo4.Text == btnLewoDol7.Text)
                {
                    return true;
                }
            }

            if (btnGora2.Text != String.Empty &&
                btnSrodek5.Text != String.Empty &&
                btnDol8.Text != String.Empty)
            {
                if (btnGora2.Text == btnSrodek5.Text && btnSrodek5.Text == btnDol8.Text)
                {
                    return true;
                }
            }

            if (btnPrawoGora3.Text != String.Empty &&
                btnPrawo6.Text != String.Empty &&
                btnPrawoDol9.Text != String.Empty)
            {
                if (btnPrawoGora3.Text == btnPrawo6.Text && btnPrawo6.Text == btnPrawoDol9.Text)
                {
                    return true;
                }
            }

            if (btnLewoGora1.Text != String.Empty &&
                btnSrodek5.Text != String.Empty &&
                btnPrawoDol9.Text != String.Empty)
            {
                if (btnLewoGora1.Text == btnSrodek5.Text && btnSrodek5.Text == btnPrawoDol9.Text)
                {
                    return true;
                }
            }

            if (btnPrawoGora3.Text != String.Empty &&
                btnSrodek5.Text != String.Empty &&
                btnLewoDol7.Text != String.Empty)
            {
                if (btnPrawoGora3.Text == btnSrodek5.Text && btnSrodek5.Text == btnLewoDol7.Text)
                {
                    return true;
                }
            }

            return false;

        }

        bool CheckDraw()
        {
            if (btnLewoGora1.Text != String.Empty && btnGora2.Text != String.Empty && btnPrawoGora3.Text != String.Empty && btnLewo4.Text != String.Empty && btnSrodek5.Text != String.Empty && btnPrawo6.Text != String.Empty && btnLewoDol7.Text != String.Empty && btnDol8.Text != String.Empty && btnPrawoDol9.Text != String.Empty)
            {
                return true;
            }
            return false;
        }

        private void GameButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text != "")
            {
                return;
            }
            button.Text = activePlayer.ToString();
            if (CheckResult())
            {
                MessageBox.Show("Wygrał gracz: " + activePlayer);
                Wygrana();
                return;
            }
            if (CheckDraw())
            {
                MessageBox.Show("Remis!");
                Wygrana();
                return;
            }

            SwitchPlayer();
            //button.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnLewoGora1.Text = "";
            btnGora2.Text = "";
            btnPrawoGora3.Text = "";
            btnLewo4.Text = "";
            btnSrodek5.Text = "";
            btnPrawo6.Text = "";
            btnLewoDol7.Text = "";
            btnDol8.Text = "";
            btnPrawoDol9.Text = "";

            btnLewoGora1.Enabled = true;
            btnGora2.Enabled = true;
            btnPrawoGora3.Enabled = true;
            btnLewo4.Enabled = true;
            btnSrodek5.Enabled = true;
            btnPrawo6.Enabled = true;
            btnLewoDol7.Enabled = true;
            btnDol8.Enabled = true;
            btnPrawoDol9.Enabled = true;
        }

        private void btnLewoGora1_Click(object sender, EventArgs e)
        {
            GameButtonClick(sender, e);
        }

        private void btnGora2_Click(object sender, EventArgs e)
        {
            GameButtonClick(sender, e);
        }

        private void btnPrawoGora3_Click(object sender, EventArgs e)
        {
            GameButtonClick(sender, e);
        }

        private void btnLewo4_Click(object sender, EventArgs e)
        {
            GameButtonClick(sender, e);
        }

        private void btnSrodek5_Click(object sender, EventArgs e)
        {
            GameButtonClick(sender, e);
        }

        private void btnPrawo6_Click(object sender, EventArgs e)
        {
            GameButtonClick(sender, e);
        }

        private void btnLewoDol7_Click(object sender, EventArgs e)
        {
            GameButtonClick(sender, e);
        }

        private void btnDol8_Click(object sender, EventArgs e)
        {
            GameButtonClick(sender, e);
        }

        private void btnPrawoDol9_Click(object sender, EventArgs e)
        {
            GameButtonClick(sender, e);
        }
    }
}