using ShadowEngine;
using ShadowEngine.ContentLoading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace GPS.WorldObjects
{
    class Road
    {
        ModelContainer m;

        public void Create()

        {
            m = ContentManager.GetModelByName("Bridge N250218.3ds");
            m.CreateDisplayList();
        }

        public void CreateCollisions()
        {
            
        }

        public void DrawAt(float x, float y, float angle, float scale)
        {
            Gl.glPushMatrix();
            Gl.glTranslatef(x, 0f, y);
            Gl.glScalef(scale, 0.0002f, 0.0002f);
            Gl.glRotatef(angle, 0.0f, 1.0f, 0f);
            m.DrawWithTextures();
            Gl.glPopMatrix();
            Gl.glEnd();
        }
    }
}
