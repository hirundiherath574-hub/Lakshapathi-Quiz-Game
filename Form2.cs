using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ලක්ෂපති
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            Random a1 = new Random();
            int ran1 = a1.Next(1, 5);
            if (ran1 == 1)
            {
                txtBox1.Text = "What type of food is spaghetti?";//1
                btnA.Text = "A) Pasta";
                btnB.Text = "B) Bread";
                btnC.Text = "C) Cheese";
                btnD.Text = "D) Salad";
            }
            else if (ran1 == 2)
            {
                txtBox1.Text = "What is the name of the preserved bodies of ancient Egypt?";//2
                btnA.Text = "A) Mummies";
                btnB.Text = "B) Aunties";
                btnC.Text = "C) Daddies";
                btnD.Text = "D) Grannies";
            }

            else if (ran1 == 3)
            {
                txtBox1.Text = "The fictional character Tarzan is said to be LORD of which environment?";//3
                btnA.Text = "A) The Jungle";
                btnB.Text = "B) The Skies";
                btnC.Text = "C) The Desert";
                btnD.Text = "D) The Sea";
            }

            else if (ran1 == 4)
            {
                txtBox1.Text = "Five interlocking rings is the well-know logo of which international event";//4
                btnA.Text = "Oympic Games";
                btnB.Text = "Miss World";
                btnC.Text = "Tour de France";
                btnD.Text = "FIFA World Cup";
            }
        }

        public static int score = 0;

        private void btnA_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "What type of food is spaghetti?" || txtBox1.Text == "What is the name of the preserved bodies of ancient Egypt?" || txtBox1.Text
                == "The fictional character Tarzan is said to be LORD of which environment?" || txtBox1.Text == "Five interlocking rings is the well-know logo of which international event")
            {
                Random a2 = new Random();
                int ran2 = a2.Next(1, 3);

                if (ran2 == 1)
                {
                    score = 1000;
                    btnC.Enabled = true;
                    btnD.Enabled = true;
                    txtBox1.Text = "What is the name of the boy who own Woody and Buzz in the movie ‘Toy Story’?";//C; //5
                    btnA.Text = "A) Sid";
                    btnB.Text = "B) Bob";
                    btnC.Text = "C) Andy";
                    btnD.Text = "D) Alex";
                    label1.BackColor = System.Drawing.Color.Indigo;
                }

                else if (ran2 == 2)
                {
                    score = 1000;
                    btnC.Enabled = true;
                    btnD.Enabled = true;
                    txtBox1.Text = "What is the scientific study of plant life called?"; //C //6
                    btnA.Text = "A) Meteorology";
                    btnB.Text = "B) Nuclear Physic";
                    btnC.Text = "C) Botany";
                    btnD.Text = "D) Chemistry";
                    label1.BackColor = System.Drawing.Color.Indigo;
                }
            }

            else if (txtBox1.Text == "What name is given to a golfer’s assistant who carries the clubs?" || txtBox1.Text == "What does TYING THE KNOT mean for a couple?")
            {

                score = 5000;
                btnC.Enabled = true;
                btnD.Enabled = true;
                txtBox1.Text = "What is the full name of the rest of Cristiano Ronaldo…..?";//D //7
                btnA.Text = "A) Romario Balotelli";
                btnB.Text = "B) Santos Romario";
                btnC.Text = "C) Dos Anka Sergio";
                btnD.Text = "D) Dos Santo Aveiro";
                label4.BackColor = System.Drawing.Color.Indigo;
            }
            else if (txtBox1.Text == "Who is Peter Pan’s enemy?")

            {

                score = 20000;
                btnC.Enabled = true;
                btnD.Enabled = true;
                txtBox1.Text = "What came down and washed the spider away?"; //B //8
                btnA.Text = "A) Slush";
                btnB.Text = "B) Rain";
                btnC.Text = "C) Snow";
                btnD.Text = "D) Wind";
                label6.BackColor = System.Drawing.Color.Indigo;
            }
            else if (txtBox1.Text == "At Which restaurant would you be able to order Chicken MacNuggets")
            {

                score = 5000000;
                btnB.Enabled = true;
                btnC.Enabled = true;
                txtBox1.Text = "What color is normally associated with hot temperature?";//B //9
                btnA.Text = "A) Yellow";
                btnB.Text = "B) White";
                btnC.Text = "C) Red";
                btnD.Text = "D) Blue";
                label14.BackColor = System.Drawing.Color.Indigo;
            }
            else
            {
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();

            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "With which form of transport is the name Harley Davidson particularly associated?" || txtBox1.Text == "What is the fear of confined spaces called?")
            {
                Random a3 = new Random();
                int ran3 = a3.Next(1, 3);
                if (ran3 == 1)
                {

                    score = 3000;
                    btnC.Enabled = true;
                    btnD.Enabled = true;
                    txtBox1.Text = "What name is given to a golfer’s assistant who carries the clubs?"; //A //10
                    btnA.Text = "A) Caddie";
                    btnB.Text = "B) Gopher";
                    btnC.Text = "C) Sherpa";
                    btnD.Text = "D) Donkey";
                    label3.BackColor = System.Drawing.Color.Indigo;
                }
                else if (ran3 == 2)
                {

                    score = 3000;
                    btnC.Enabled = true;
                    btnD.Enabled = true;
                    txtBox1.Text = "What does TYING THE KNOT mean for a couple?";//A //11
                    btnA.Text = "Marriage";
                    btnB.Text = "Buying a House";
                    btnC.Text = "Buying Shoes";
                    btnD.Text = "Kissing";
                    label3.BackColor = System.Drawing.Color.Indigo;
                }

            }

            else if (txtBox1.Text == "What came down and washed the spider away?")
            {

                score = 40000;
                btnA.Enabled = true;
                btnC.Enabled = true;
                txtBox1.Text = "Which of these is a mineral?";//C //12
                btnA.Text = "A) Vinegar";
                btnB.Text = "B) Mustard";
                btnC.Text = "C) Salt";
                btnD.Text = "D) Pepper";
                label7.BackColor = System.Drawing.Color.Indigo;

            }

            else if (txtBox1.Text == "How many sides doses pentagon have?")
            {

                score = 320000;
                btnA.Enabled = true;
                btnD.Enabled = true;
                txtBox1.Text = "Which of the following plays CDs?";//C //13
                btnA.Text = "A) Record play";
                btnB.Text = "B) 8 Track play";
                btnC.Text = "C) CD plays";
                btnD.Text = "D) Tape play";
                label10.BackColor = System.Drawing.Color.Indigo;
            }
            else if (txtBox1.Text == "Who wrote ‘The Merry Wives of Windsor’s ?")

            {

                score = 2500000;
                btnA.Enabled = true;
                btnC.Enabled = true;
                txtBox1.Text = "At Which restaurant would you be able to order Chicken MacNuggets";//A //14
                btnA.Text = "A) McDonald's";
                btnB.Text = "B) Wendy's";
                btnC.Text = "C) Taco Bell";
                btnD.Text = "D) Burger King";
                label13.BackColor = System.Drawing.Color.Indigo;
            }

            else
            {
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();

            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "What is the name of the boy who own Woody and Buzz in the movie ‘Toy Story’?" || txtBox1.Text == "What is the scientific study of plant life called?")
            {
                Random a4 = new Random();
                int ran4 = a4.Next(1, 3);
                if (ran4 == 1)
                {

                    score = 2000;
                    btnA.Enabled = true;
                    btnD.Enabled = true;
                    txtBox1.Text = "With which form of transport is the name Harley Davidson particularly associated?";//B //15
                    btnA.Text = "A) Powerboat";
                    btnB.Text = "B) Motorcycle";
                    btnC.Text = "C) Jeep";
                    btnD.Text = "D) Helicopter";
                    label2.BackColor = System.Drawing.Color.Indigo;
                }
                else if (ran4 == 2)
                {

                    score = 2000;
                    btnA.Enabled = true;
                    btnD.Enabled = true;
                    txtBox1.Text = "What is the fear of confined spaces called?";//B //16
                    btnA.Text = "A) Euphobia";
                    btnB.Text = "B) Claustropobia";
                    btnC.Text = "C) Acrophobia";
                    btnD.Text = "D) Bibliophobia";
                    label2.BackColor = System.Drawing.Color.Indigo;

                }
            }
            else if (txtBox1.Text == "Which of these is a mineral?")
            {

                score = 80000;
                btnA.Enabled = true;
                btnB.Enabled = true;
                txtBox1.Text = "Which medical conditions caused by the lack of insulin produced by the pancreas?";//C //17
                btnA.Text = "A) Cancer of the pancreas";
                btnB.Text = "B) Glaucoma";
                btnC.Text = "C) High Blood Pressure";
                btnD.Text = "D) Diabetes";
                label8.BackColor = System.Drawing.Color.Indigo;
            }
            else if (txtBox1.Text == "Which of the following plays CDs?")/////////////
            {
                //clap.Play();
                score = 625000;
                btnB.Enabled = true;
                btnD.Enabled = true;
                txtBox1.Text = "Of the following, which is not a dog breed?";//D //18
                btnA.Text = "A) Labrador Retriever";
                btnB.Text = "B) Cocker Spaniel";
                btnC.Text = "C) German Shepherd";
                btnD.Text = "D) American Bobtail";
                label11.BackColor = System.Drawing.Color.Indigo;
            }
            else if (txtBox1.Text == "What color is normally associated with hot temperature?")
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            else
            {
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();

            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "What is the full name of the rest of Cristiano Ronaldo…..?")
            {

                score = 10000;
                btnB.Enabled = true;
                btnC.Enabled = true;
                txtBox1.Text = "Who is Peter Pan’s enemy?";//A //19
                btnA.Text = "A) Captain Hook";
                btnB.Text = "B) Shark";
                btnC.Text = "C) Tinker Bell";
                btnD.Text = "D) Poison";
                label5.BackColor = System.Drawing.Color.Indigo;
            }
            else if (txtBox1.Text == "Which medical conditions caused by the lack of insulin produced by the pancreas?")
            {
                //clap.Play();
                score = 160000;
                btnA.Enabled = true;
                btnB.Enabled = true;
                txtBox1.Text = "How many sides doses pentagon have?";//B //20
                btnA.Text = "A) 4";
                btnB.Text = "B) 5";
                btnC.Text = "C) 6";
                btnD.Text = "D) 3";

                label9.BackColor = System.Drawing.Color.Indigo;

            }
            else if (txtBox1.Text == "Of the following, which is not a dog breed?")
            {
                //clap.Play();
                score = 1250000;
                btnA.Enabled = true;
                btnB.Enabled = true;
                txtBox1.Text = "Who wrote ‘The Merry Wives of Windsor’s ?";//B //21
                btnA.Text = "A) Hemingway";
                btnB.Text = "B) Shakespeare";
                btnC.Text = "C) Wilde";
                btnD.Text = "D) Swift";
                label12.BackColor = System.Drawing.Color.Indigo;
            }

            else
            {
                Form form4 = new Form4();
                form4.Show();
                this.Hide();
                //player.Stop();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckBox1_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (txtBox1.Text == "What type of food is spaghetti?" || txtBox1.Text == "What is the name of the preserved bodies of ancient Egypt?" || txtBox1.Text
                   == "The fictional character Tarzan is said to be LORD of which environment?" || txtBox1.Text == "Five interlocking rings is the well-know logo of which international event")
                {
                    btnC.Text = "";
                    btnD.Text = "";
                    checkBox1.Enabled = false;
                    btnC.Enabled = false;
                    btnD.Enabled = false;
                }

                if (txtBox1.Text == "What name is given to a golfer’s assistant who carries the clubs?" || txtBox1.Text == "What does TYING THE KNOT mean for a couple?")
                {
                    btnC.Text = "";
                    btnD.Text = "";
                    checkBox1.Enabled = false;
                    btnC.Enabled = false;
                    btnD.Enabled = false;
                }

                if (txtBox1.Text == "Who is Peter Pan’s enemy?")
                {
                    btnC.Text = "";
                    btnD.Text = "";
                    checkBox1.Enabled = false;
                    btnC.Enabled = false;
                    btnD.Enabled = false;
                }

                if (txtBox1.Text == "At Which restaurant would you be able to order Chicken MacNuggets")
                {
                    btnB.Text = "";
                    btnC.Text = "";
                    checkBox1.Enabled = false;
                    btnB.Enabled = false;
                    btnC.Enabled = false;

                }

                if (txtBox1.Text == "With which form of transport is the name Harley Davidson particularly associated?" || txtBox1.Text == "What is the fear of confined spaces called?")
                {
                    btnC.Text = "";
                    btnD.Text = "";
                    checkBox1.Enabled = false;
                    btnC.Enabled = false;
                    btnD.Enabled = false;
                }

                if (txtBox1.Text == "What came down and washed the spider away?")
                {
                    btnC.Text = "";
                    btnD.Text = "";
                    checkBox1.Enabled = false;
                    btnC.Enabled = false;
                    btnD.Enabled = false;
                }
                if (txtBox1.Text == "Which medical conditions caused by the lack of insulin produced by the pancreas?")
                {
                    btnA.Text = "";
                    btnB.Text = "";
                    checkBox1.Enabled = false;
                    btnA.Enabled = false;
                    btnB.Enabled = false;
                }
                if (txtBox1.Text == "Who wrote ‘The Merry Wives of Windsor’s ?")
                {
                    btnA.Text = "";
                    btnD.Text = "";
                    checkBox1.Enabled = false;
                    btnA.Enabled = false;
                    btnD.Enabled = false;
                }
                if (txtBox1.Text == "What is the name of the boy who own Woody and Buzz in the movie ‘Toy Story’?" || txtBox1.Text == "What is the scientific study of plant life called?")
                {
                    btnB.Text = "";
                    btnD.Text = "";
                    checkBox1.Enabled = false;
                    btnB.Enabled = false;
                    btnD.Enabled = false;
                }
                if (txtBox1.Text == "Which of these is a mineral?")
                {
                    btnB.Text = "";
                    btnD.Text = "";
                    checkBox1.Enabled = false;
                    btnB.Enabled = false;
                    btnD.Enabled = false;
                }
                if (txtBox1.Text == "Which of the following plays CDs?")
                {
                    btnA.Text = "";
                    btnB.Text = "";
                    checkBox1.Enabled = false;
                    btnA.Enabled = false;
                    btnB.Enabled = false;
                }
                if (txtBox1.Text == "What color is normally associated with hot temperature?")
                {
                    btnA.Text = "";
                    btnB.Text = "";
                    checkBox1.Enabled = false;
                    btnA.Enabled = false;
                    btnB.Enabled = false;
                }
                if (txtBox1.Text == "What is the full name of the rest of Cristiano Ronaldo…..?")
                {
                    btnC.Text = "";
                    btnA.Text = "";
                    checkBox1.Enabled = false;
                    btnC.Enabled = false;
                    btnA.Enabled = false;
                }

                if (txtBox1.Text == "How many sides doses pentagon have?")
                {
                    btnA.Text = "";
                    btnC.Text = "";
                    checkBox1.Enabled = false;
                    btnA.Enabled = false;
                    btnC.Enabled = false;
                }
                if (txtBox1.Text == "Of the following, which is not a dog breed?")
                {
                    btnA.Text = "";
                    btnC.Text = "";
                    checkBox1.Enabled = false;
                    btnA.Enabled = false;
                    btnC.Enabled = false;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                if (txtBox1.Text == "What type of food is spaghetti?" || txtBox1.Text == "What is the name of the preserved bodies of ancient Egypt?" || txtBox1.Text
                   == "The fictional character Tarzan is said to be LORD of which environment?" || txtBox1.Text == "Five interlocking rings is the well-know logo of which international event")
                {
                    MessageBox.Show("Mejoraty of Audiance is Saying (A) is Right Answer");
                    checkBox2.Enabled = false;
                }


                if (txtBox1.Text == "What name is given to a golfer’s assistant who carries the clubs?" || txtBox1.Text == "What does TYING THE KNOT mean for a couple?")
                {
                    MessageBox.Show("Mejoraty of Audiance is Saying (C) is Right Answer");
                    checkBox2.Enabled = false;
                }

                if (txtBox1.Text == "Who is Peter Pan’s enemy?")
                {
                    MessageBox.Show("Mejoraty of Audiance is Saying (B) is Right Answer");
                    checkBox2.Enabled = false;

                }

                if (txtBox1.Text == "At Which restaurant would you be able to order Chicken MacNuggets")
                {
                    MessageBox.Show("Mejoraty of Audiance is Saying (B) is Right Answer");
                    checkBox2.Enabled = false;
                }

                if (txtBox1.Text == "With which form of transport is the name Harley Davidson particularly associated?" || txtBox1.Text == "What is the fear of confined spaces called?")
                {
                    MessageBox.Show("Mejoraty of Audiance is Saying (C) is Right Answer");
                    checkBox2.Enabled = false;
                }
                if (txtBox1.Text == "Which of these is a mineral?")
                {
                    MessageBox.Show("Mejoraty of Audiance is Saying (A) is Right Answer");
                    checkBox2.Enabled = false;
                }
                if (txtBox1.Text == "Which of the following plays CDs?")
                {
                    MessageBox.Show("Mejoraty of Audiance is Saying (C) is Right Answer");
                    checkBox2.Enabled = false;
                }
                if (txtBox1.Text == "What color is normally associated with hot temperature?")
                {
                    MessageBox.Show("Mejoraty of Audiance is Saying (B) is Right Answer");
                    checkBox2.Enabled = false;
                }
                if (txtBox1.Text == "What is the full name of the rest of Cristiano Ronaldo…..?")
                {
                    MessageBox.Show("Mejoraty of Audiance is Saying (C) is Right Answer");
                    checkBox2.Enabled = false;
                }
                if (txtBox1.Text == "How many sides doses pentagon have?")
                {
                    MessageBox.Show("Mejoraty of Audiance is Saying (C) is Right Answer");
                    checkBox2.Enabled = false;
                }
                if (txtBox1.Text == "Of the following, which is not a dog breed?")
                {
                    MessageBox.Show("Mejoraty of Audiance is Saying (A) is Right Answer");
                    checkBox2.Enabled = false;
                }
            }
        }
    }
}
