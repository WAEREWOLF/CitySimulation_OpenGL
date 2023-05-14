using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ShadowEngine;
using ShadowEngine.OpenGL; 
using Tao.OpenGl;
using ShadowEngine.ContentLoading;
using System.Runtime.InteropServices;  

namespace GPS
{
    public partial class MainForm : Form
    {
        //handle viewport
        uint hdc;
        MainClass main = new MainClass();
        int move;
        Point formPos;
        Point mousePos;
        static MainForm mainForm;

        public static MainForm Instance
        {
            get { return MainForm.mainForm; }
            set { MainForm.mainForm = value; }
        }

        public Point MousePos
        {
            get { return mousePos; }
            set { mousePos = value; }
        }

        public Point FormPos
        {
            get { return formPos; }
            set { formPos = value; }
        }

        public MainForm()
        {
            mainForm = this; 
            
            InitializeComponent();
            hdc = (uint)this.Handle;
            string error = "";
            
            OpenGLControl.OpenGLInit(ref hdc, this.Width, this.Height, ref error);

            if (error != "")
            {
                MessageBox.Show("OpenGL initializer error");
            }

            
            main.Camera.PlaceCamera(this.Width, this.Height);
            
            Lighting.SetupLighting();  
            ContentManager.SetTextureList("textures\\");
            ContentManager.LoadTextures(); 
            ContentManager.SetModelList("model\\"); 
            ContentManager.LoadModels();        
            Camera.CenterMouse();
            main.CreateObjects();
            //Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE);  
        }

        private void tmrPaint_Tick(object sender, EventArgs e)
        {
           
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
           
            main.Camera.Update(move);   
            main.DrawScene();
        
            SwapBuffers(hdc);
         
            Gl.glFlush();
        }

        [DllImport("GDI32.dll")]
        public static extern void SwapBuffers(uint hdc);

        [DllImport("user32.dll")]
        public static extern void SetCursorPos(int x, int y);

        private void MainForm_Load(object sender, EventArgs e)
        {
            formPos = new Point(this.Left, this.Top);   
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close(); 
            }
            if (e.KeyCode == Keys.W)
            {
                 move = 1;
            }
        }

        private void pnlViewPort_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                move = 1;  
            }
            if (e.Button == MouseButtons.Right)
            {
                move = -1;
            }
        }

        private void pnlViewPort_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            move = 0;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            mousePos.X = e.X;
            mousePos.Y = e.Y;
        }

        public void CenterMouse()
        {
            if (this.Focused)
            {
                SetCursorPos(this.formPos.X + 512, this.formPos.Y + 384);       
            }
        }

        public Point ScreenCenter()
        {
            return new Point(512, 384); 
        }
    }
}
