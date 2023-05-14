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
    class RegularHouse
    {
        ModelContainer m;

        public void Create()
        
        {
            m = ContentManager.GetModelByName("Old_wood_barrack_3DS.3DS");
            m.CreateDisplayList();
        }

        public void CreateCollisions()
        {
            
        }

        public void DrawAt(float x, float y)
        {
            Gl.glPushMatrix();
            Gl.glTranslatef(x, 1.0f, y);
            Gl.glScalef(0.02f, 0.02f, 0.02f);
            Gl.glRotatef(90f, 0.0f, 1.0f, 0.0f);
            m.DrawWithTextures();
            Gl.glPopMatrix();
            Gl.glEnd();
        }
    }
}
