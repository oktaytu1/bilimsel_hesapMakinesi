namespace bilimselHesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //
        //----------------------------------------de�i�kenler----------------------------------------
        double sonuc;
        bool sonuclandirildi = true;
        bool aktif2nd = false;

        bool expBasildi = false;
        bool xUzeriYBasildi = false;
        bool logBasildi = false;

        //(4+1) i�lemler i�in
        string islem;
        double sayi;
        bool esittirBasildi = false;
        //----------------------------------------de�i�kenler----------------------------------------
        //

        //
        //----------------------------------------text de�i�ti�inde----------------------------------------
        private void txtbox_TextChanged(object sender, EventArgs e)
        {
            if (txtbox.Text == "")
            {
                txtbox.Text = "0";
                btn_C.Text = "C";
            }
            else
            {
                btn_C.Text = "CE";
                if (txtbox.Text.Length == 2)
                {
                    if (txtbox.Text.Substring(0, 1) == "0")
                    {
                        txtbox.Text = txtbox.Text.Substring(1, txtbox.Text.Length - 1);
                    }
                }
            }
        }
        //----------------------------------------text de�i�ti�inde----------------------------------------
        //

        //
        //----------------------------------------E��TT�R----------------------------------------
        private void btn_esittir_Click(object sender, EventArgs e)
        {
            //
            //2nd ile �al��anlar
            if (aktif2nd== false)
            {//1. fonksiyonlar�

                //x^y butonu
                if (xUzeriYBasildi == true)
                {
                    xUzeriYBasildi = false;
                    sonuc = Math.Pow(sonuc, Convert.ToInt16(txtbox.Text));
                    sonuc = 0;
                }
                //x^y butonu

            }
            else
            {//2. fonksiyonlar�

                //x^y
                if (xUzeriYBasildi == true)
                {
                    xUzeriYBasildi = false;
                    lbl.Text += txtbox.Text+" =";
                    sonuc = Math.Pow(sonuc, 1 / Convert.ToDouble(txtbox.Text));
                    sonuc = 0;
                }
                //x^y

                //log butonu
                if (logBasildi == true)
                {
                    logBasildi = false;
                    lbl.Text += txtbox.Text + " =";
                    sonuc = Math.Log(sonuc,Convert.ToDouble(txtbox.Text));
                    sonuc = 0;
                }
                //log butonu

            }
            //2nd ile �al��anlar
            //

            //exp butonu
            if (expBasildi == true)
            {
                expBasildi = false;
                int sifirSayisi = Convert.ToInt16(txtbox.Text);

                for (int i = 0; i < sifirSayisi; i++)
                {
                    sonuc *= 10;
                    lbl.Text = txtbox.Text = sonuc.ToString();
                }
                sonuc = 0;
            }
            //exp butonu

            //
            // 4+1 temel i�lemler
            switch (islem)
            {
                //toplama
                case "topla":
                    if (esittirBasildi == false)
                    {//ilk bas��
                        sayi = Convert.ToDouble(txtbox.Text);
                        lbl.Text = txtbox.Text+"+";
                    }
                    sonuc += sayi;
                    break;
                    //toplama

                //cikarma
                case "cikar":
                    if (esittirBasildi == false)
                    {//ilk bas��
                        sayi = Convert.ToDouble(txtbox.Text);
                        lbl.Text = txtbox.Text + "-";
                    }
                    sonuc -= sayi;
                    break;
                    //cikarma

                //�arpma
                case "carp":
                    if (esittirBasildi == false)
                    {//ilk bas��
                        sayi = Convert.ToDouble(txtbox.Text);
                        lbl.Text = txtbox.Text + "*";
                    }
                    sonuc *= sayi;
                    break;
                    //�arpma

                //b�lme
                case "bol":
                    if (esittirBasildi == false)
                    {//ilk bas��
                        sayi = Convert.ToDouble(txtbox.Text);
                        lbl.Text = txtbox.Text + "/";
                    }
                    sonuc /= sayi;
                    break;
                    //b�lme

                //mod alma
                case "mod":
                    if (esittirBasildi == false)
                    {//ilk bas��
                        sayi = Convert.ToDouble(txtbox.Text);
                        lbl.Text = txtbox.Text + "%";
                    }
                    sonuc %= sayi;
                    break;
                    //mod alma
            }
            // 4+1 temel i�lemler
            //

            sonuclandirildi = true;
            txtbox.Text = sonuc.ToString();
            esittirBasildi = true;
        }
        //----------------------------------------E��TT�R----------------------------------------
        //


        //
        //----------------------------------------say�lar----------------------------------------
        private void btn_0_Click(object sender, EventArgs e)
        {
            if (sonuclandirildi == true)
            {
                txtbox.Text = "0";
                sonuclandirildi = false;
            }
            else
            {
                if (txtbox.Text!="0")
                {
                    txtbox.Text += "0";
                }
            }
        }
        private void btn_1_Click(object sender, EventArgs e)
        {
            if (sonuclandirildi==true)
            {
                txtbox.Text = "1";
                sonuclandirildi = false;
            }
            else
            {
                txtbox.Text += "1";
            }
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            if (sonuclandirildi == true)
            {
                txtbox.Text = "2";
                sonuclandirildi = false;
            }
            else
            {
                txtbox.Text += "2";
            }
        }
        private void btn_3_Click(object sender, EventArgs e)
        {
            if (sonuclandirildi == true)
            {
                txtbox.Text = "3";
                sonuclandirildi = false;
            }
            else
            {
                txtbox.Text += "3";
            }
        }
        private void btn_4_Click(object sender, EventArgs e)
        {
            if (sonuclandirildi == true)
            {
                txtbox.Text = "4";
                sonuclandirildi = false;
            }
            else
            {
                txtbox.Text += "4";
            }
        }
        private void btn_5_Click(object sender, EventArgs e)
        {
            if (sonuclandirildi == true)
            {
                txtbox.Text = "5";
                sonuclandirildi = false;
            }
            else
            {
                txtbox.Text += "5";
            }
        }
        private void btn_6_Click(object sender, EventArgs e)
        {
            if (sonuclandirildi == true)
            {
                txtbox.Text = "6";
                sonuclandirildi = false;
            }
            else
            {
                txtbox.Text += "6";
            }
        }
        private void btn_7_Click(object sender, EventArgs e)
        {
            if (sonuclandirildi == true)
            {
                txtbox.Text = "7";
                sonuclandirildi = false;
            }
            else
            {
                txtbox.Text += "7";
            }
        }
        private void btn_8_Click(object sender, EventArgs e)
        {
            if (sonuclandirildi == true)
            {
                txtbox.Text = "8";
                sonuclandirildi = false;
            }
            else
            {
                txtbox.Text += "8";
            }
        }
        private void btn_9_Click(object sender, EventArgs e)
        {
            if (sonuclandirildi == true)
            {
                txtbox.Text = "9";
                sonuclandirildi = false;
            }
            else
            {
                txtbox.Text += "9";
            }
        }
        //----------------------------------------say�lar----------------------------------------
        //


        //
        //----------------------------------------kolay olanlar----------------------------------------
        private void btn_virgul_Click(object sender, EventArgs e)
        {
            bool virgulYaz = true;
            for (int i = 0; i < txtbox.Text.Length; i++)
            {//textte virg�l var m�d iye kontrol
                if (txtbox.Text.Substring(i, 1) == ",")
                {
                    virgulYaz = false;
                }
            }
            if (virgulYaz==true)
            {//textte herhangi biyerde virg�l yoksa virg�l koy
                txtbox.Text += ",";
            }
        }
        private void btn_isaretDegistir_Click(object sender, EventArgs e)
        {
            sonuc = (Convert.ToDouble(txtbox.Text)*(-1));
            txtbox.Text = sonuc.ToString();
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text.Substring(0,txtbox.Text.Length-1);
        }
        private void btn_pi_Click(object sender, EventArgs e)
        {
            txtbox.Text =  Math.PI.ToString();
        }
        private void btn_e_Click(object sender, EventArgs e)
        {
            txtbox.Text = Math.E.ToString();
        }
        private void btn_mutlakDeger_Click(object sender, EventArgs e)
        {
            sonuc = (Convert.ToDouble(txtbox.Text));
            if (sonuc<0)
            {
                sonuc = (Convert.ToDouble(txtbox.Text) * (-1));
            }
            txtbox.Text = sonuc.ToString();
        }
        private void btn_1boluX_Click(object sender, EventArgs e)
        {
            sonuc = Convert.ToDouble(txtbox.Text);
            lbl.Text = "1/"+sonuc;
            sonuc = 1 / sonuc;
            txtbox.Text = sonuc.ToString();
        }
        private void btn_C_Click(object sender, EventArgs e)
        {
            if (btn_C.Text=="CE")
            {
                txtbox.Text = "";
            }
            else if (btn_C.Text == "C")
            {
                lbl.Text = "";
            }
            sonuc = 0;
            islem = "";
            esittirBasildi = false;
        }
        private void btn_parantezAc_Click(object sender, EventArgs e)
        {
            txtbox.Text += "(";
        }
        private void btn_parantezKapa_Click(object sender, EventArgs e)
        {
            txtbox.Text += ")";
        }
        private void btn_faktoriyel_Click(object sender, EventArgs e)
        {
            int fact = 1;
            sonuc = Convert.ToDouble(txtbox.Text);
            lbl.Text = "fact(" + sonuc + ")";
            for (int i = 2; i <= sonuc; i++)
            {
                fact *= i;
            }
            txtbox.Text = fact.ToString();
            sonuclandirildi = true;
        }
        //----------------------------------------kolay olanlar----------------------------------------
        //

        //
        //----------------------------------------2. i�lev butonu----------------------------------------
        private void btn_2nd_Click(object sender, EventArgs e)
        {
            if (btn_2nd.BackColor == System.Drawing.SystemColors.MenuHighlight)
            {
                btn_2nd.BackColor = System.Drawing.SystemColors.ScrollBar;
                aktif2nd = false;
                btn_xKare.Text = "x^2";
                btn_kareKok.Text = "kare k�k";
                btn_xUzeriY.Text = "x^y";
                btn_10uzeriX.Text = "10^x";
                btn_log.Text = "log";
                btn_ln.Text = "ln";
            }
            else if (btn_2nd.BackColor == System.Drawing.SystemColors.ScrollBar)
            {
                btn_2nd.BackColor = System.Drawing.SystemColors.MenuHighlight;
                aktif2nd = true;
                btn_xKare.Text = "x^3";
                btn_kareKok.Text = "k�p k�k";
                btn_xUzeriY.Text = "y k�k x";
                btn_10uzeriX.Text = "2^x";
                btn_log.Text = "logvY X";
                btn_ln.Text = "e^x";
            }
        }
        //----------------------------------------2. i�lev butonu----------------------------------------
        //

        //
        //----------------------------------------2. i�lev kullan�lan yerler----------------------------------------
        private void btn_xKare_Click(object sender, EventArgs e)
        {
            sonuc = Convert.ToDouble(txtbox.Text);

            if (aktif2nd == false)
            {
                lbl.Text = "sqr(" + sonuc + ")";

                sonuc = sonuc * sonuc;
            }
            else
            {
                lbl.Text = "cube(" + sonuc + ")";

                sonuc = sonuc * sonuc * sonuc;
            }
            txtbox.Text = sonuc.ToString();
            sonuclandirildi = true;
        }
        private void btn_kareKok_Click(object sender, EventArgs e)
        {
            sonuc = Convert.ToDouble(txtbox.Text);
            if (aktif2nd==false)
            {
                lbl.Text = "kare_k�k(" +sonuc+")";
                sonuc =Math.Sqrt(sonuc);
            }
            else
            {
                lbl.Text = "k�p_k�k(" + sonuc + ")";
                sonuc = Math.Cbrt(sonuc);
            }
            txtbox.Text = sonuc.ToString();
            sonuclandirildi = true;
        }
        private void btn_xUzeriY_Click(object sender, EventArgs e)
        {
            sonuc = Convert.ToDouble(txtbox.Text);
            if (aktif2nd == false)
            {
                if (xUzeriYBasildi == false)
                {
                    lbl.Text = sonuc + "^";
                    xUzeriYBasildi = true;
                }
            }
            else
            {
                if (xUzeriYBasildi == false)
                {//y kuvvetinde k�k x (x ^ 1/y)
                    lbl.Text = sonuc + " yk�k ";
                    xUzeriYBasildi = true;
                }
            }
            sonuclandirildi = true;
            txtbox.Text = sonuc.ToString();
        }
        private void btn_10uzeriX_Click(object sender, EventArgs e)
        {
            sonuc = Convert.ToDouble(txtbox.Text);
            if (aktif2nd == false)
            {
                lbl.Text = "10^("+sonuc+")";
                sonuc=Math.Pow(10,sonuc);
            }
            else
            {
                lbl.Text = "2^(" + sonuc + ")";
                sonuc = Math.Pow(2, sonuc);
            }
            sonuclandirildi = true;
            txtbox.Text = sonuc.ToString();
        }
        private void btn_log_Click(object sender, EventArgs e)
        {
            sonuc = Convert.ToDouble(txtbox.Text);
            if (aktif2nd == false)
            {
                lbl.Text = "log(" + sonuc + ")";
                sonuc = Math.Log10(sonuc);
            }
            else
            {
                if (logBasildi==false)
                {
                    lbl.Text = sonuc + "log base";
                    logBasildi=true;
                }
            }
            sonuclandirildi = true;
            txtbox.Text = sonuc.ToString();
        }
        private void btn_ln_Click(object sender, EventArgs e)
        {
            sonuc = Convert.ToDouble(txtbox.Text);
            if (aktif2nd == false)
            {
                lbl.Text = "ln(" + sonuc + ")";
                sonuc = Math.Log(sonuc);
            }
            else
            {
                int s=Convert.ToInt16(sonuc);
                lbl.Text = "e^(" + s + ")";
                sonuc = 1;
                if (s>0)
                {
                    for (int i = 1; i <= s; i++)
                    {
                        sonuc *= Math.E;
                    }
                }
                else
                {
                    s *= -1;
                    for (int i = 1; i <= s; i++)
                    {
                        sonuc /= Math.E;
                    }
                }

            }
            sonuclandirildi = true;
            txtbox.Text = sonuc.ToString();
        }
        //----------------------------------------2. i�lev kullan�lan yerler----------------------------------------
        //

        //exp butonu
        private void btn_exp_Click(object sender, EventArgs e)
        {
            if (expBasildi == false)
            {
                expBasildi = true;
                sonuc = Convert.ToDouble(txtbox.Text);
                lbl.Text = sonuc + ",e+";
                txtbox.Text = "0";
                sonuclandirildi = true;
            }
        }
        //exp butonu

        //
        //---------------------------------------- 4 temel i�lem + 1 (+,-,/,*,(%)) ----------------------------------------
        private void btn_topla_Click(object sender, EventArgs e)
        {
            islem = "topla";
            sayi = sonuc = Convert.ToDouble(txtbox.Text);
            lbl.Text = txtbox.Text+"+";
            sonuclandirildi = true;
        }
        private void btn_cikar_Click(object sender, EventArgs e)
        {
            islem = "cikar";
            sayi = sonuc = Convert.ToDouble(txtbox.Text);
            lbl.Text = txtbox.Text + "-";
            sonuclandirildi = true;
        }
        private void btn_carp_Click(object sender, EventArgs e)
        {
            islem = "carp";
            sayi = sonuc = Convert.ToDouble(txtbox.Text);
            lbl.Text = txtbox.Text + "x";
            sonuclandirildi = true;
        }
        private void btn_bol_Click(object sender, EventArgs e)
        {
            islem = "bol";
            sayi = sonuc = Convert.ToDouble(txtbox.Text);
            lbl.Text = txtbox.Text + "/";
            sonuclandirildi = true;
        }
        private void btn_mod_Click(object sender, EventArgs e)
        {
            islem = "mod";
            sayi = sonuc = Convert.ToDouble(txtbox.Text);
            lbl.Text = txtbox.Text + "%";
            sonuclandirildi = true;
        }
        //---------------------------------------- 4 temel i�lem + 1 (+,-,/,*,(%)) ----------------------------------------
        //
    }
}