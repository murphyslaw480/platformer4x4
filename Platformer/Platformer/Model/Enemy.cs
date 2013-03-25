﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;

namespace Platformer.Model
{
    class Enemy : Unit
    {
        #region static
        #endregion

        #region fields
        #endregion

        #region properties
        #endregion

        #region constructor
        public Enemy(string key, Vector2 position, bool facingRight)
            :base(key, position, facingRight)
        {
        }
        #endregion

        #region methods
        public override void CollideWithObstacle(Direction direction)
        {
            base.CollideWithObstacle(direction);
            switch (direction)
            {
                case Direction.East:
                case Direction.West:
                   _velocity.X = -_velocity.X;
                   break;
            }
        }

        public override void Update(GameTime gameTime, bool onGround)
        {
            Walk(Sprite.FacingRight ? Direction.East : Direction.West);
            base.Update(gameTime, onGround);
        }
        #endregion
    }
}
