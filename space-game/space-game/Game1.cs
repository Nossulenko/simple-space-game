using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace space_game
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

       

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferHeight = 1200;
            graphics.PreferredBackBufferWidth = 1900;
        }

        Texture2D meteorite;
        Texture2D spaceship;
        Texture2D space;

        SpriteFont spaceF;
        SpriteFont timerF;

        Spaceship player = new Spaceship();
      
        Controller gameController = new Controller();
        
       
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            meteorite = Content.Load<Texture2D>("asteroid");
            space = Content.Load<Texture2D>("space");
            spaceship = Content.Load<Texture2D>("ship");

            spaceF = Content.Load<SpriteFont>("spaceFont");
            timerF = Content.Load<SpriteFont>("timerFont");
        }

       
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

      
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            player.shipUpdate(gameTime, gameController);
            gameController.conUpdate(gameTime);

            for (int i = 0; i < gameController.meteorites.Count; i++)
            {
                gameController.meteorites[i].meteoriteUpdate(gameTime);

                int sum = gameController.meteorites[i].radius + 30;
                if (Vector2.Distance(gameController.meteorites[i].position, player.position) < sum)
                {
                    gameController.inGame = false;
                    player.position = Spaceship.defaultPosition;
                    i = gameController.meteorites.Count;
                    gameController.meteorites.Clear();
                    
                }
            }

            base.Update(gameTime);
        }

      
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            spriteBatch.Draw(space, new Vector2(0, 0), Color.White);
            spriteBatch.Draw(spaceship, new Vector2(player.position.X - 34, player.position.Y - 50), Color.White);

            if (gameController.inGame == false) 
            {
                string menuMessage = "Press Enter to Begin!";
                Vector2 sizeOfText = spaceF.MeasureString(menuMessage);
                spriteBatch.DrawString(spaceF, menuMessage, new Vector2(900 - sizeOfText.X / 2, 200), Color.White);
            }
            for (int i = 0; i < gameController.meteorites.Count; i++)
            {
                Vector2 tempPos = gameController.meteorites[i].position;
                int tempRadius = gameController.meteorites[i].radius;
                spriteBatch.Draw(meteorite, new Vector2(tempPos.X - tempRadius, tempPos.Y - tempRadius), Color.White);
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
