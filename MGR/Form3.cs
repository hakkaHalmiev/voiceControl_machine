using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.Platform.Windows;
using System.Drawing.Design;
namespace MGR
{
    public partial class Form3 : Form
    { 
        float rotX = 0;
        float rotY=0;
        float rotZ = 0;
        public Form3()
        {
            InitializeComponent();
            OpenGlControl.InitializeContexts();
            Gl.glClearColor(0, 0, 0.1f, 0);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glOrtho(-2, 2, -2,2,-2,2);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glEnable(Gl.GL_DEPTH_TEST);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
           string fileName = @"C:\Users\User\Desktop\3 Boyut Mecal\CAD3D\Data\Drill.stl";
            OpenFileDialog newFileDialog = new OpenFileDialog();
            newFileDialog.Filter = "STL Files|*.stl;*.txt;*.png;*.obj;";

            //  if (newFileDialog.ShowDialog() == DialogResult.OK)
            //{
            
            //}
        }
        float[][] pt =
        {
            new float[]{-1,-1,-1},new float[]{-1,1,-1},
            new float[]{1,-1,-1},new float[]{1,1,-1},
            new float[]{-1,-1,1},new float[]{-1,1,1},
            new float[]{1,-1,1},new float[]{1,1,1}
        };
        public void quad(int n1, int n2, int n3, int n4)
        {
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3f(0.0f, 0.0f, 0.0f);  Gl.glVertex3fv(pt[n1]);
            Gl.glColor3f(0.0f, 0.0f, 0.6f); Gl.glVertex3fv(pt[n2]);
            Gl.glColor3f(0.0f, 0.0f, 0.3f); Gl.glVertex3fv(pt[n3]);
            Gl.glColor3f(0.0f, 0.0f, 0.1f); Gl.glVertex3fv(pt[n4]);
            Gl.glEnd();

        }
        public void cube()
        {

            quad(6, 2, 3, 7);quad(5, 1, 0, 4);
            quad(7, 3, 1, 5);quad(4, 0, 2, 6);
            quad(2, 0, 1, 3);quad(7, 5, 4, 6);
        }
        private void MyPaint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT|Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glShadeModel(Gl.GL_SMOOTH);
            Gl.glPushMatrix();
            Gl.glRotatef(rotX, 1, 0, 0);
            Gl.glRotatef(rotY, 0, 1, 0);
            Gl.glRotatef(rotZ, 0, 0, 1);
            cube();
            Gl.glPopMatrix();
            /*  
               Gl.glTranslatef(0.5f, 0.5f, 0);
               Gl.glRotatef(alfa, 0, 0, 1);
               Gl.glTranslatef(-0.5f, -0.5f, 0);
               Gl.glBegin(Gl.GL_TRIANGLES);
               Gl.glColor3f(1.7f, 1.2f, 0.0f);
               Gl.glVertex3f(0.5f, 1.0f, 0.0f);
               Gl.glColor3f(2.7f, 0.2f, 0.6f);
               Gl.glVertex3f(0.0f, 0.0f, 0.0f);
               Gl.glColor3f(0.3f, 2.2f, 1.0f);
               Gl.glVertex3f(1.0f, 0.0f, 0.0f);
             */
            Gl.glEnd();
            timer1.Enabled = true;
            timer1.Interval = 50;
            
          

            
        }

       

        private void MyKey(object sender, KeyEventArgs e)
        {
            
        }

        private void buttonZDondur_Click(object sender, EventArgs e)
        {
            rotZ = (rotZ + 5) % 360;
            OpenGlControl.Refresh();
        }

        private void buttonYDondur_Click(object sender, EventArgs e)
        {
            rotY = (rotY + 5) % 360;
            OpenGlControl.Refresh();
        }

        private void buttonXDondur_Click(object sender, EventArgs e)
        {
            rotX = (rotX + 5) % 360;
            OpenGlControl.Refresh();
        }

        private void MyKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
                rotX = (rotX - 5) % 360;
            if (e.KeyCode == Keys.W)
                rotX = (rotX + 5) % 360;
            if (e.KeyCode == Keys.A)
                rotZ = (rotZ + 5) % 360;
            if (e.KeyCode == Keys.D)
                rotZ = (rotZ -5) % 360;
            OpenGlControl.Refresh();
        }

        private void MyMouseMove(object sender, MouseEventArgs e)
        {

            
        }

        private void MyMouseHover(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rotX = (rotX - 5) % 360;
            rotZ = (rotZ + 5) % 360;
            OpenGlControl.Refresh();
        }

        private void OpenGlControl_Load(object sender, EventArgs e)
        {

        }
    }
}
