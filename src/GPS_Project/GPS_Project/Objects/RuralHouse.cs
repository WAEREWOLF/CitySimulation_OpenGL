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
    class RuralHouse
    {
        ModelContainer m;

        public void Create()

        {
            m = ContentManager.GetModelByName("House type 2.3ds");
            m.CreateDisplayList();
        }


        public void DrawAt(float x, float y, bool wantRotate180)
        {
            Gl.glPushMatrix();
            Gl.glTranslatef(x, 1.0f, y);
            Gl.glScalef(0.5f, 0.5f, 0.5f);
            if (wantRotate180)
            {
                Gl.glRotatef(180f, 0.0f, 1.0f, 0.0f);
            }
            m.DrawWithTextures();
            Gl.glPopMatrix();
            Gl.glEnd();
        }
    }
}
