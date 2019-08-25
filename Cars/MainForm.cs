using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ShadowEngine;
using Tao.OpenGl;
using ShadowEngine.OpenGL;
using ShadowEngine.ContentLoading; 

namespace CarRace
{
    public partial class MainForm : Form
    {
        uint hdc;
        int selectedCamara = 3; 
        int count,bustCount=0; //initializing variables for race
        Controller control = new Controller();
        int mostrado = 0;
        int moving;
        int joe_total = 50, bob_total = 50, ai_total = 50; //setting total amount
        bool joewins = false, bobwins = false, aiwins = false; //no one wins initially
        int []betno = new int[3]; //betting for betters 
        int[] betValue = new int[3]; //betvalue for betters
        public MainForm()
        {
            InitializeComponent();
           
            hdc = (uint)this.Handle;
            string error = "";
            OpenGLControl.OpenGLInit(ref hdc, this.Width, this.Height, ref error);

            control.Camara.SetPerspective();
            if (error != "")
            {
                MessageBox.Show("an error occurred ");
                this.Close();   
            }

            
            //float[] lightAmbient = { 0.15F, 0.15F, 0.15F, 0.0F };

            //Lighting.LightAmbient = lightAmbient; 
            
            Lighting.SetupLighting(); 
            
            ContentManager.SetTextureList("texturas\\");
            ContentManager.LoadTextures();
            ContentManager.SetModelList("modelos\\");
            ContentManager.LoadModels();  
            control.CreateObjects();

            //Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE);   
        }
        //initializing local variables for unit testing
        public MainForm(bool joewon,bool bobwon, bool aiwon,int totalMoney)
        {
            joewins = joewon;
            bobwins = bobwon;
            aiwins = aiwon;
            joe_total = totalMoney;
            bob_total = totalMoney + 10;
            ai_total = totalMoney + 20;
            
        }
        /// <summary>
        /// race ends 
        /// </summary>
        public void UpdateLogic()
        {
            if (moving == 1)
            {
                Gl.glTranslatef(0, 0, 0.35f);
            }
            else
                if (moving == -1)
                {
                    Gl.glTranslatef(0, 0, -0.35f);
                }
            count++;
            if (Controller.FinishedRace == true && mostrado == 0)
            {
                int result;
                MainBetterClass obj = new MainBetterClass();
                mostrado = 1;
                moving = 0;
                //Display Result
                MessageBox.Show("The winner was the: " + lblPrimero.Text + " (car no: " +lblbetno.Text+ ")");
                //Update Amount Remaining and wining status 
                if (lblPrimero.Text == "Blue car") 
                {
                    result = obj.whowon(betno,1);
                }
                else if (lblPrimero.Text == "Red car")
                {
                    result = obj.whowon(betno,2);
                }
                else if (lblPrimero.Text == "Green car")
                {
                    result = obj.whowon(betno,3);
                }
                else
                {
                    result = obj.whowon(betno,4);
                }
                if (result == 0)
                {
                    joewins = true;
                }
                else if(result == 1)
                {
                    bobwins = true;
                }
                else if(result == 2)
                {
                    aiwins = true;
                }
                //function to update textboxes for betting amount left and status of betters 
                changeText();
                //set old betno and betvalue to 0
                for (int i = 0; i < 3; i++)
                {
                    betno[i] = 0;
                    betValue[i] = 0;
                }

            }

            if (count == 10)
            {
                if (Controller.StartedRace == true && mostrado == 0)
                {
                    int primero = control.GetFirstPlace();
                    float distanciaRecorrida = control.GetDistanceInMeters(primero);
                    lblDistancia.Text = Convert.ToString((int)distanciaRecorrida);
                    switch (primero)
                    {
                        case 0:
                            {
                                lblPrimero.Text = "Blue car";
                                lblbetno.Text = "1";
                                lblPrimero.ForeColor = Color.Blue;
                                break;
                            }
                        case 1:
                            {
                                lblPrimero.Text = "Red car";
                                lblbetno.Text = "2";
                                lblPrimero.ForeColor = Color.Red;
                                break;
                            }
                        case 2:
                            {
                                lblPrimero.Text = "Green car";
                                lblbetno.Text = "3";
                                lblPrimero.ForeColor = Color.Green;
                                break;
                            }
                        case 3:
                            {
                                lblPrimero.Text = "Gold car";
                                lblbetno.Text = "4";
                                lblPrimero.ForeColor = Color.Goldenrod;
                                break;
                            }
                    }
                }
                count = 0;
            }
        }


        private void tmrPaint_Tick(object sender, EventArgs e)
        {
            UpdateLogic(); 
            // clean opengl to draw
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            //draws the entire scene
            control.DrawScene();
            //change buffers
            Winapi.SwapBuffers(hdc);
            //tell opengl to drop any operation he is doing and to prepare for a new frame
            Gl.glFlush(); 
        }
        //Minimum value for carno to bet no = 4
        private void MainForm_Load(object sender, EventArgs e)
        {
            numericCar.Minimum = 1;
            numericCar.Maximum = 4;
            maxlbl.ForeColor = Color.Yellow;
            lblWhoBets.ForeColor = Color.Yellow;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedCamara--;
            if (selectedCamara == 0)
            {
                selectedCamara = 4;
            }
            //lblCamara.Text = Convert.ToString(selectedCamara);
            control.Camara.SelectCamara(selectedCamara - 1);    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedCamara++;
            if (selectedCamara == 5)
            {
                selectedCamara = 1;
            }
            //lblCamara.Text = Convert.ToString(selectedCamara);
            control.Camara.SelectCamara(selectedCamara-1);   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Controller.StartedRace = true;   
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            lblPrimero.Text = "None";
            lblDistancia.Text = "0";
            control.ResetRace();
            
            mostrado = 0;
            count = 0;
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            Gl.glViewport(0, 0, this.Width, this.Height);
            //select the projection matrix
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            //la reseteo
            Gl.glLoadIdentity();
            //45 = angulo de vision
            //1  = proporcion de alto por ancho
            //0.1f = distancia minima en la que se pinta
            //1000 = distancia maxima
            Glu.gluPerspective(55, this.Width/(float)this.Height  , 0.1f, 1000);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            control.Camara.SelectCamara(selectedCamara - 1); 
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.W)
            {
                moving = 1;
            }
            if (e.KeyData == Keys.S)
            {
                moving = -1;
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            moving = 0;
        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }
        //update better name and better total amount based on radio button click and 
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            maxlbl.Text = Convert.ToString(joe_total);
            numericBet.Maximum = joe_total;
            lblWhoBets.Text = "Joe ";
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            maxlbl.Text = Convert.ToString(bob_total);
            numericBet.Maximum = bob_total;
            lblWhoBets.Text = "Bob ";
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            maxlbl.Text = Convert.ToString(ai_total);
            numericBet.Maximum = ai_total;
            lblWhoBets.Text = "AI ";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericBet_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        //initialize bets placed before race start
        private void Button4_Click(object sender, EventArgs e)
        {
            if (lblWhoBets.Text == "Joe ")
            {
                txtJoe.Text = lblWhoBets.Text + " bets " + numericBet.Value + " on car " + numericCar.Value;
                betno[0] = Convert.ToInt32(numericCar.Value);
                betValue[0] = Convert.ToInt32(numericBet.Value);
            }
            else if (lblWhoBets.Text == "Bob ") { 
                txtBob.Text = lblWhoBets.Text + " bets " + numericBet.Value + " on car " + numericCar.Value;
                betno[1] = Convert.ToInt32(numericCar.Value);
                betValue[1] = Convert.ToInt32(numericBet.Value);
            }
            else { 
                txtAI.Text = lblWhoBets.Text + " bets " + numericBet.Value + " on car " + numericCar.Value;
                betno[2] = Convert.ToInt32(numericCar.Value);
                betValue[2] = Convert.ToInt32(numericBet.Value);
            }
        }
        //change bet values placed with winners and win amount , losers and lost amount
        public void changeText()
        {
            MainBetterClass better = new MainBetterClass();
            if (joewins == true)
            {
                joe_total = Convert.ToInt32(joe_total + betValue[0]);
                txtJoe.Text = better.getName(0) + " won and now has " + joe_total;
                joewins = false;
            }
            else
            {
                joe_total = Convert.ToInt32(joe_total - betValue[0]);
                if(joe_total <= 0)
                {
                    txtJoe.Text = "Busted";
                    txtJoe.ForeColor = Color.Red;
                    rbJoe.Enabled = false;
                    bustCount++;
                }
                else
                {
                    txtJoe.Text = better.getName(0) + " lost and now has" + joe_total;
                }
            }
            if(bobwins == true)
            {
                bob_total = Convert.ToInt32(bob_total + betValue[1]);
                txtBob.Text = better.getName(1) + " won and now has " + bob_total;
                bobwins = false;
            }
            else
            {
                bob_total = Convert.ToInt32(bob_total - betValue[1]);
                if (bob_total <= 0)
                {
                    txtBob.Text = "Busted";
                    rbBob.Enabled = false;
                    txtBob.ForeColor = Color.Red;
                    bustCount++;
                }
                else
                {
                    txtBob.Text = better.getName(1) + " lost and now has " + bob_total;
                }
            }
            if(aiwins == true)
            {
                ai_total = Convert.ToInt32(ai_total + betValue[2]);
                txtAI.Text = better.getName(2) + " won and now has " + ai_total;
                aiwins = false;
            }
            else
            {
                ai_total = Convert.ToInt32(ai_total - betValue[2]);
                if (ai_total <= 0)
                {
                    txtAI.Text = "Busted";
                    rbAI.Enabled = false;
                    txtAI.ForeColor = Color.Red;
                    bustCount++;
                }
                else
                {
                    txtAI.Text = better.getName(2) + " lost and now has " + ai_total;
                }
            }
            if(bustCount > 1)
            {
                MessageBox.Show("Game Over");                
            }
        }
        /// <summary>
        /// Unit Testing 
        /// </summary>
        /// <returns></returns>
        public string unitTest()
        {
            string result = "";
            if (joewins == true)
            {
                result += "joe won " + (2 * joe_total) + Environment.NewLine;
            }
            else
            {
                result += "Busted" + Environment.NewLine;
            }
            if (bobwins == true)
            {
                result += "bob won " + (2 * bob_total) + Environment.NewLine;
            }
            else
            {
                result += "Busted" + Environment.NewLine;
            }
            if (aiwins == true)
            {
                result += "ai won " + (2 * ai_total) + Environment.NewLine;
            }
            else
            {
                result += "Busted" + Environment.NewLine;
            }
            return result;
        }
    }
}
