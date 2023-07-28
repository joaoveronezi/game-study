using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace firstProject
{
    public class Character
    {
        private Texture2D texture;
        private Vector2 position;
        private Vector2 velocity;
        private bool hasJumped;


        // Constructor
        public Character(Vector2 position, Texture2D texture)
        {

            this.position = position;
            this.texture = texture;
            velocity = new Vector2(0, 0);
            hasJumped = true;


        }
        public void Update(GameTime gameTime)
        {
            position += velocity;

            if (Keyboard.GetState().IsKeyDown(Keys.Right)) velocity.X = 3f;
            else  if (Keyboard.GetState().IsKeyDown(Keys.Left)) velocity.X -= 3f; else velocity.X = 0f;

            if (Keyboard.GetState().IsKeyDown(Keys.Space) && hasJumped == false)
            {
                position.Y -= -10f;
                velocity.Y = -5f;
                hasJumped = true;
            }

            if (hasJumped == true)
            {
                float i = 1;
                velocity.Y += 0.15f * i;
            } 


            if(position.Y + texture.Height > 350)
            {
                hasJumped = false;
            }

            if (hasJumped == false)
            {
                velocity.Y += 0;
            }

        }

        // Draw method, basically put it on screen.

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);

        }
    }




}
