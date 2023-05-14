using ShadowEngine;
using ShadowEngine.ContentLoading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace GPS.WorldObjects
{
    class Firetree
    {
        private float x;
        private float y;

        ModelContainer m;

        public void Create()

        {
            m = ContentManager.GetModelByName("Tree Abies Pardei N151117.3DS");
            m.CreateDisplayList();
        }

        public void CreateCollisions()
        {
            /*
            Collision.AddCollisionPoint(new Point3D(1.5f, 9.0f, 0), 2);
            Collision.AddCollisionPoint(new Point3D(-0.35f, -3.97f, 0), 0.3f);
            Collision.AddCollisionSegment(new Point3D(-14.4f, 28.3f, 0), new Point3D(-14.5f, -11.6f, 0), 0.5f);
            Collision.AddCollisionSegment(new Point3D(-14.4f, -11.6f, 0), new Point3D(20.1f, -11.7f, 0), 0.5f);
            */
        }

        public void DrawAt(float x, float y)
        {
            this.x = x;
            this.y = y;
           
                Gl.glPushMatrix();
                Gl.glTranslatef(x, 8f, y);
                Gl.glScalef(0.003f, 0.003f, 0.003f);
                Gl.glRotatef(90.0f, 0.0f, 1.0f, 0.0f);
                m.DrawWithTextures();
                Gl.glPopMatrix();
                Gl.glEnd();                          
        }

        public void Move()
        {
            float currentY = y;
            while (true)
            {
                currentY += 1.0f;
                //Gl.glTranslatef(x, 3f, currentY);
                
                if (currentY >= 200)
                {
                    currentY = y;
                }
            }
        }
    }
}
