using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using xTile;
using System.Reflection;
using System.IO;

namespace TestXNB
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public void processXnb(string contentName)
        {
            Map m = Content.Load<Map>(contentName);
            foreach (xTile.Tiles.TileSheet tileSheet in m.TileSheets)
            {
                tileSheet.ImageSource += ".png";
            }
            Type tBinFormat = typeof(xTile.Format.IMapFormat).Assembly.GetType("xTile.Format.TbinFormat");
            object format = Activator.CreateInstance(tBinFormat);
            if (!Directory.Exists("ContentOut/"))
                Directory.CreateDirectory("ContentOut/");
            using (FileStream fs = File.OpenWrite("ContentOut/" + contentName + ".tbin"))
            {
                tBinFormat.InvokeMember("Store", BindingFlags.Public | BindingFlags.InvokeMethod | BindingFlags.Instance, null, format, new object[] { m, fs as Stream });
            }
        }

        public Game1()
        {
            //graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            foreach (string file in Directory.GetFiles(Content.RootDirectory)) {
                if (file.EndsWith(".xnb")) {
                    processXnb(Path.GetFileNameWithoutExtension(file));
                }
            }
            this.Exit();
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            //if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                //this.Exit();

            // TODO: Add your update logic here

            //base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            //GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            //base.Draw(gameTime);
        }
    }
}
