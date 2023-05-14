using System;
using System.Collections.Generic;
using System.Text;
using GPS.WorldObjects;
using ShadowEngine;
using Tao.OpenGl;


namespace GPS
{
    public class MainClass
    {
        Camera camera = new Camera(); 
        SkyBox sky = new SkyBox();
       
        PinkTree tree = new PinkTree();
        RegularHouse regularHouse = new RegularHouse();
        RuralHouse ruralHouse = new RuralHouse();
        Lamp lampPost = new Lamp();
        Road road = new Road();
        Statue statue = new Statue();
        Firetree fireTree = new Firetree();

        public void CreateObjects()
        {              
            tree.Create();            
                        
            regularHouse.Create();
            ruralHouse.Create();
            lampPost.Create();
            road.Create();
            statue.Create();
            fireTree.Create();
            Sprite.Create(); 
        }

        public Camera Camera
        {
            get { return camera; }
        }

        public void DrawScene()
        {
            //SIDE 1
            // one side trees
            float x = -120.0f;
            float y = -100.0f;
            for (int tree_nr = 0; tree_nr < 10; ++tree_nr)
            {
                tree.DrawAt(x, y);
                x += 30;
            }

            //regular house 1
            x = -120.0f;
            y = -50.0f;
            
            for (int house_nr = 0; house_nr < 10; ++house_nr)
            {
                ruralHouse.DrawAt(x, y, false);
                x += 20;
            }

            road.DrawAt(-60f, -30f, 660f, 0.0006f);
            road.DrawAt(-10f, -9f, -509f, 0.0003f);
            road.DrawAt(10f, -9f, -509f, 0.0003f);

            //SIDE 2
            // other side trees
            x = -120.0f;
            y = 100.0f;
            for (int tree_nr = 10; tree_nr < 20; ++tree_nr)
            {
                tree.DrawAt(x, y);
                x += 30;
            }

            //other side barn
            x = -120.0f;
            y = 50.0f;
           
            for (int house_nr = 0; house_nr < 7; ++house_nr)
            {
                regularHouse.DrawAt(x, y);
                x += 35;
            }

            road.DrawAt(-60f, 30f, 660f, 0.0006f);
            road.DrawAt(-30f, 9f, -509f, 0.0003f);
            road.DrawAt(40f, 9f, -509f, 0.0003f);
                        
            statue.DrawAt(-60, 0);
            statue.DrawAt(-20, 0);
            statue.DrawAt(90, 0);

            lampPost.DrawAt(-120, -60);
            lampPost.DrawAt(-120, -30);
            lampPost.DrawAt(-120, 60);
            lampPost.DrawAt(-120, 30);
            lampPost.DrawAt(-20, 10);
            lampPost.DrawAt(90, -10);

            fireTree.DrawAt(0, 0);
            fireTree.DrawAt(20, 0);
            fireTree.DrawAt(30, 0);
            fireTree.DrawAt(60, 0);

            sky.DrawSky();


            
            Sprite.Begin();
            Sprite.End();
        }
    }
}
