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
    class Statue
    {
        ModelContainer m;

        public void Create()

        {
            m = ContentManager.GetModelByName("Sculpture horse N220416.3DS");
            m.CreateDisplayList();
        }


        public void DrawAt(float x, float y)
        {
            Gl.glPushMatrix();
            Gl.glTranslatef(x, 2f, y);
            Gl.glScalef(0.008f, 0.008f, 0.008f);
            m.DrawWithTextures();
            Gl.glPopMatrix();
            Gl.glEnd();
        }
    }
}
