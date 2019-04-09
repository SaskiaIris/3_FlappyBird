using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace FlappyBird.GameStates {
	class PlayingState : GameObjectList {
		private SpriteGameObject background;

		public PlayingState() {
			background = new SpriteGameObject("spr_background");

			this.Add(background);
		}

		public override void Update(GameTime gameTime) {
			base.Update(gameTime);
		}
	}
}
