using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int yatırılanPara, kazanan, at1, at2, at3;
        double yüzOtuz, yüzElli, yüzSeksen, numericDeger, bakiye;
        private void BtnBaslat_Click(object sender, EventArgs e)
        {

            timer1.Start();


        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            switch (kazanan)
            {
                case 1:
                    pbAt1.Left += rnd.Next(30, 50);
                    pbAt2.Left += rnd.Next(10, 50);
                    pbAt3.Left += rnd.Next(10, 50);
                    break;

                case 2:
                    pbAt1.Left += rnd.Next(10, 50);
                    pbAt2.Left += rnd.Next(30, 50);
                    pbAt3.Left += rnd.Next(10, 50);
                    break;

                case 3:
                    pbAt1.Left += rnd.Next(10, 50);
                    pbAt2.Left += rnd.Next(10, 50);
                    pbAt3.Left += rnd.Next(30, 50);
                    break;
            }


            if (pbAt1.Right >= pbAt2.Right && pbAt1.Right >= pbAt3.Right)
            {
                lblSpiker.Text = "1. At önde gidiyor";
            }
            else if (pbAt2.Right > pbAt1.Right && pbAt2.Right > pbAt3.Right)
            {
                lblSpiker.Text = "2. At önde gidiyor";
            }
            else if (pbAt3.Right > pbAt1.Right && pbAt3.Right > pbAt2.Right)
            {
                lblSpiker.Text = "3. At önde gidiyor";
            }

            if (pbAt1.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("1. At kazandı\ntekrar oynamak ister misin", "oyun bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                

                if (dr == DialogResult.Yes)
                {
                    if (bahisOynanaAt == 1) 

                    {
                        
                        bakiye += yatırılanPara * 1.30;
                        lblBakiye.Text = bakiye.ToString("C");
                        listBahis.Items.Add("Kazanılan Para :" + (yatırılanPara * 1.30));
                        yatırılanPara = 0;

                        
                    }

                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;

                    btnYatir3.Enabled = true;
                    numeric3.Enabled = true;
                    btnYatir2.Enabled = true;
                    numeric2.Enabled = true;
                    btnYatir1.Enabled = true;
                    numeric1.Enabled = true;



                    renk = rnd.Next(1, 4);
                    switch (renk)
                    {
                        case 1:
                            this.BackColor = Color.Blue;
                            kazanan = 1;
                            break;
                        case 2:
                            this.BackColor = Color.Sienna;
                            kazanan = 2;
                            break;
                        case 3:
                            this.BackColor = Color.Green;
                            kazanan = 3;
                            break;
                    }



                }
                else
                {

                }
            }

            else if (pbAt2.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("2. At kazandı\ntekrar oynamak ister misin", "oyun bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    if (bahisOynanaAt==2)
                    {
                        bakiye += yatırılanPara * 1.50;
                        lblBakiye.Text = bakiye.ToString("C");
                        listBahis.Items.Add("Kazanılan Para :" + yatırılanPara * 1.50);
                        yatırılanPara = 0;

                        
                    }

                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;

                    btnYatir3.Enabled = true;
                    numeric3.Enabled = true;
                    btnYatir2.Enabled = true;
                    numeric2.Enabled = true;
                    btnYatir1.Enabled = true;
                    numeric1.Enabled = true;

                    renk = rnd.Next(1, 4);
                    switch (renk)
                    {
                        case 1:
                            this.BackColor = Color.Blue;
                            kazanan = 1;
                            break;
                        case 2:
                            this.BackColor = Color.Sienna;
                            kazanan = 2;
                            break;
                        case 3:
                            this.BackColor = Color.Green;
                            kazanan = 3;
                            break;
                    }
                }
            }

            else if (pbAt3.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("3. At kazandı\ntekrar oynamak ister misin", "oyun bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {

                    if (bahisOynanaAt == 3)
                    {
                        bakiye += yatırılanPara * 1.80;
                        lblBakiye.Text = bakiye.ToString("C");
                        listBahis.Items.Add("Kazanılan Para :" + yatırılanPara * 1.80);
                        yatırılanPara = 0;

                        
                    }

                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;

                    btnYatir3.Enabled = true;
                    numeric3.Enabled = true;
                    btnYatir2.Enabled = true;
                    numeric2.Enabled = true;
                    btnYatir1.Enabled = true;
                    numeric1.Enabled = true;

                    renk = rnd.Next(1, 4);
                    switch (renk)
                    {
                        case 1:
                            this.BackColor = Color.Blue;
                            kazanan = 1;
                            break;
                        case 2:
                            this.BackColor = Color.Sienna;
                            kazanan = 2;
                            break;
                        case 3:
                            this.BackColor = Color.Green;
                            kazanan = 3;
                            break;
                    }
                }
            }
        }

        private void btnYatir3_Click(object sender, EventArgs e)
        {
            bahisOynanaAt = 3;
            yatırılanPara = int.Parse(numeric3.Value.ToString());

            //yüzSeksen = Convert.ToDouble(lblYüzSeksen.Text);
            numericDeger = Convert.ToDouble(numeric3.Value);
            bakiye = Convert.ToDouble(lblBakiye.Text);
            //lblYatırılanPara.Text = (yüzSeksen * numericDeger).ToString();
            lblYatırılanPara.Text = numericDeger.ToString();

            listBahis.Items.Add("Çekilen Para :" + lblYatırılanPara.Text);
            lblBakiye.Text = (bakiye - numericDeger).ToString();
            btnYatir3.Enabled = false;
            numeric3.Enabled = false;
            btnYatir2.Enabled = false;
            numeric2.Enabled = false;
            btnYatir1.Enabled = false;
            numeric1.Enabled = false;
        }

        private void btnYatir2_Click(object sender, EventArgs e)
        {
            bahisOynanaAt = 2;
            yatırılanPara = int.Parse(numeric2.Value.ToString());

            //yüzElli = Convert.ToDouble(lblYüzElli.Text);
            numericDeger = Convert.ToDouble(numeric2.Value);
            bakiye = Convert.ToDouble(lblBakiye.Text);
            //lblYatırılanPara.Text = (yüzElli * numericDeger).ToString();
            lblYatırılanPara.Text = numericDeger.ToString();

            listBahis.Items.Add("Çekilen Para :" + lblYatırılanPara.Text);
            lblBakiye.Text = (bakiye - numericDeger).ToString();
            btnYatir2.Enabled = false;
            numeric2.Enabled = false;
            btnYatir3.Enabled = false;
            numeric3.Enabled = false;
            btnYatir1.Enabled = false;
            numeric1.Enabled = false;
        }
        int bahisOynanaAt;
        private void btnYatir1_Click(object sender, EventArgs e)
        {
            bahisOynanaAt = 1;
            yatırılanPara = int.Parse(numeric1.Value.ToString());
            //yüzOtuz = Convert.ToDouble(lblYüzOtuz.Text);
            numericDeger = Convert.ToDouble(numeric1.Value);
            bakiye = Convert.ToDouble(lblBakiye.Text);
            //lblYatırılanPara.Text = (yüzOtuz * numericDeger).ToString();
            lblYatırılanPara.Text = numericDeger.ToString();

            listBahis.Items.Add("Çekilen Para :" + lblYatırılanPara.Text);
            lblBakiye.Text = (bakiye - numericDeger).ToString();
            btnYatir1.Enabled = false;
            numeric1.Enabled = false;
            btnYatir2.Enabled = false;
            numeric2.Enabled = false;
            btnYatir3.Enabled = false;
            numeric3.Enabled = false;



        }
        int renk;
        private void Form1_Load(object sender, EventArgs e)
        {   //rastgele 1-3 arası bir deger atadık ve  atadığımız değere göre arkaplan rengini değiştirdik.
            renk = rnd.Next(1, 4);
            switch (renk)
            {
                case 1:
                    this.BackColor = Color.Blue;
                    kazanan = 1;
                    break;
                case 2:
                    this.BackColor = Color.Sienna;
                    kazanan = 2;
                    break;
                case 3:
                    this.BackColor = Color.Green;
                    kazanan = 3;
                    break;

            }

            //mesela şey 1. at kazandı ama hesaba para yatma işi o çok hata verdi o zaman konuşmuştuk olmadı
            //dur bi dk
            lblBakiye.Text = "500";
            if (lblBakiye.Text == "0")
            {
                MessageBox.Show("Bakiyenizde Para Kalmamıştır");
            }
        }


    }
}
