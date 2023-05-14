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
    class Lamp
    {
        ModelContainer m;

        public void Create()

        {
            m = ContentManager.GetModelByName("Lamppost N111111.3DS");
            m.CreateDisplayList();
        }


        public void DrawAt(float x, float y)
        {
            Gl.glPushMatrix();
            Gl.glTranslatef(x, 3f, y);
            Gl.glScalef(0.004f, 0.004f, 0.004f);
            m.DrawWithTextures();
            Gl.glPopMatrix();
            Gl.glEnd();
        }
    }
}
