using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_AI {

	class BoardCell {

		public static Color DANGER_MOVE_CELL = Color.Red;
		public static Color SAFE_MOVE_CELL = Color.Green;
		public static Color TARGET_CELL = Color.DarkCyan;

		public static Color DESTROYABLE_WALL_CELL = Color.DarkOrange;
		public static Color UNDESTROYABLE_WALL_CELL = Color.WhiteSmoke;
		public static Color ENEMY_TANK_CELL = Color.Green;
		public static Color BULLET_CELL = Color.Black;
		public static Color OUR_TANK_CELL = Color.DarkCyan;

		private int _x, _y;
		private Color _color;

		public void UpdateCell(string cellState) {
			
		}

	}
}
