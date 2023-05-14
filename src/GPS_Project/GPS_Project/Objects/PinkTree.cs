using ShadowEngine;
using ShadowEngine.ContentLoading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace GPS
{
    class PinkTree
    {
        ModelContainer m;

        public void Create()
        {
            m = ContentManager.GetModelByName("pink_tree.3ds");
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
            Gl.glPushMatrix();
            Gl.glTranslatef(x, -25.5f, y);
            Gl.glScalef(0.2f, 0.2f, 0.2f);
            m.DrawWithTextures();
            Gl.glPopMatrix();
            Gl.glEnd();
        }
    }
}
