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
        int selectedCamara = 2;
        int count,bustCount=0;
        Controller control = new Controller();
        int mostrado = 0;
        int moving;
        int joeMax = 45, bobMax = 50, AIMax = 75;
        bool joeWon = false, bobWon = false, AIWon = false;
        int []carno = new int[3];
        int []betValue = new int[3];
        public MainForm()
        {
            InitializeComponent();
            //identificador del lugar en donde voy a dibujar
            hdc = (uint)this.Handle;
            //toma el error que sucedio
            string error = "";
            //Comando de inicializacion de la ventana grafica
            OpenGLControl.OpenGLInit(ref hdc, this.Width, this.Height, ref error);

            //inicia la posicion de la camara asi como define en angulo de perspectiva,etc etc
            control.Camara.SetPerspective();
            if (error != "")
            {
                MessageBox.Show("Ocurrio un error al inicializar openGL");
                this.Close();   
            }

            //Habilita las luces
            
            //float[] lightAmbient = { 0.15F, 0.15F, 0.15F, 0.0F };

            //Lighting.LightAmbient = lightAmbient; 
            
            Lighting.SetupLighting();  // encapsulado en el sahdow engine 
            
            ContentManager.SetTextureList("texturas\\");
            ContentManager.LoadTextures();
            ContentManager.SetModelList("modelos\\");
            ContentManager.LoadModels();  
            control.CreateObjects();

            //Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE);   
        }

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
                mostrado = 1;
                moving = 0;
                MessageBox.Show("The winner was the: " + lblPrimero.Text);
                if (lblPrimero.Text == "Blue car")
                {
                    whowon(1);
                }
                else if (lblPrimero.Text == "Red car")
                {
                    whowon(2);
                }
                else
                {
                    whowon(3);
                }
                changeText();
                for (int i = 0; i < 3; i++)
                {
                    carno[i] = 0;
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
                                lblPrimero.ForeColor = Color.Blue;
                                break;
                            }
                        case 1:
                            {
                                lblPrimero.Text = "Red car";
                                lblPrimero.ForeColor = Color.Red;
                                break;
                            }
                        case 2:
                            {
                                lblPrimero.Text = "Black car";
                                lblPrimero.ForeColor = Color.Black;
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            numericCar.Minimum = 1;
            numericCar.Maximum = 3;
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

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            maxlbl.Text = Convert.ToString(joeMax);
            numericBet.Maximum = joeMax;
            lblWhoBets.Text = "Joe ";
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            maxlbl.Text = Convert.ToString(bobMax);
            numericBet.Maximum = bobMax;
            lblWhoBets.Text = "Bob ";
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            maxlbl.Text = Convert.ToString(AIMax);
            numericBet.Maximum = AIMax;
            lblWhoBets.Text = "AI ";
        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (lblWhoBets.Text == "Joe ")
            {
                txtJoe.Text = lblWhoBets.Text + " bets " + numericBet.Value + " on car " + numericCar.Value;
                carno[0] = Convert.ToInt32(numericCar.Value);
                betValue[0] = Convert.ToInt32(numericBet.Value);
            }
            else if (lblWhoBets.Text == "Bob ") { 
                txtBob.Text = lblWhoBets.Text + " bets " + numericBet.Value + " on car " + numericCar.Value;
                carno[1] = Convert.ToInt32(numericCar.Value);
                betValue[1] = Convert.ToInt32(numericBet.Value);
            }
            else { 
                txtAI.Text = lblWhoBets.Text + " bets " + numericBet.Value + " on car " + numericCar.Value;
                carno[2] = Convert.ToInt32(numericCar.Value);
                betValue[2] = Convert.ToInt32(numericBet.Value);
            }
        }
        private void whowon(int no)
        {
            if (carno[0] == no)
                joeWon = true;
            if (carno[1] == no)
                bobWon = true;
            if (carno[2] == no)
                AIWon = true;

        }
        private void changeText()
        {
            if (joeWon == true)
            {
                joeMax = Convert.ToInt32(joeMax + betValue[0]);
                txtJoe.Text = "Joe won and now has " + joeMax;
                joeWon = false;
            }
            else
            {
                joeMax = Convert.ToInt32(joeMax - betValue[0]);
                if(joeMax <= 0)
                {
                    txtJoe.Text = "Busted";
                    txtJoe.ForeColor = Color.Red;
                    rbJoe.Enabled = false;
                    bustCount++;
                }
                else
                {
                    txtJoe.Text = "Joe lost and now has" + joeMax;
                }
            }
            if(bobWon == true)
            {
                bobMax = Convert.ToInt32(bobMax + betValue[1]);
                txtBob.Text = "Bob won and now has " + bobMax;
                bobWon = false;
            }
            else
            {
                bobMax = Convert.ToInt32(bobMax - betValue[1]);
                if (bobMax <= 0)
                {
                    txtBob.Text = "Busted";
                    rbBob.Enabled = false;
                    txtBob.ForeColor = Color.Red;
                    bustCount++;
                }
                else
                {
                    txtBob.Text = "Bob lost and now has " + bobMax;
                }
            }
            if(AIWon == true)
            {
                AIMax = Convert.ToInt32(AIMax + betValue[2]);
                txtAI.Text = "AI won and now has " + AIMax;
                AIWon = false;
            }
            else
            {
                AIMax = Convert.ToInt32(AIMax - betValue[2]);
                if (AIMax <= 0)
                {
                    txtAI.Text = "Busted";
                    rbAI.Enabled = false;
                    txtAI.ForeColor = Color.Red;
                    bustCount++;
                }
                else
                {
                    txtAI.Text = "AI lost and now has " + AIMax;
                }
            }
            if(bustCount > 1)
            {
                MessageBox.Show("Game Over");                
            }
        }
    }
}
