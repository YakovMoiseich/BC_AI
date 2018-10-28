using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_AI {

    enum CellType {
        GROUND, WALL, DEAD, CONSTRUCTION, CONSTRUCTION_DESTROYED_DOWN, CONSTRUCTION_DESTROYED_UP, CONSTRUCTION_DESTROYED_LEFT, CONSTRUCTION_DESTROYED_RIGHT, CONSTRUCTION_DESTROYED_DOWN_TWICE,
        CONSTRUCTION_DESTROYED_UP_TWICE, CONSTRUCTION_DESTROYED_LEFT_TWICE, CONSTRUCTION_DESTROYED_RIGHT_TWICE, CONSTRUCTION_DESTROYED_LEFT_RIGHT, CONSTRUCTION_DESTROYED_UP_DOWN,
        CONSTRUCTION_DESTROYED_UP_LEFT, CONSTRUCTION_DESTROYED_RIGHT_UP, CONSTRUCTION_DESTROYED_DOWN_LEFT, CONSTRUCTION_DESTROYED_DOWN_RIGHT, BULLET, TANK_UP, TANK_RIGHT, TANK_DOWN,
        TANK_LEFT, OTHER_TANK_UP, OTHER_TANK_RIGHT, OTHER_TANK_DOWN, OTHER_TANK_LEFT, AUTOBOT_TANK_LEFT, AUTOBOT_TANK_RIGHT, AUTOBOT_TANK_UP, AUTOBOT_TANK_DOWN
    }

    class BoardCell {

        static Dictionary<char, CellType> CharToCellType = new Dictionary<char, CellType> {
            { ' ', CellType.GROUND }, { '☼', CellType.WALL }, { 'Ѡ', CellType.DEAD }, { '╬', CellType.CONSTRUCTION }, { '╩', CellType.CONSTRUCTION_DESTROYED_DOWN },
            { '╦', CellType.CONSTRUCTION_DESTROYED_UP }, { '╠', CellType.CONSTRUCTION_DESTROYED_LEFT }, { '╣', CellType.CONSTRUCTION_DESTROYED_RIGHT },
            { '╨', CellType.CONSTRUCTION_DESTROYED_DOWN_TWICE }, { '╥', CellType.CONSTRUCTION_DESTROYED_UP_TWICE },{ '╞', CellType.CONSTRUCTION_DESTROYED_LEFT_TWICE },
            { '╡', CellType.CONSTRUCTION_DESTROYED_RIGHT_TWICE }, { '│', CellType.CONSTRUCTION_DESTROYED_LEFT_RIGHT },{ '─', CellType.CONSTRUCTION_DESTROYED_UP_DOWN },
            { '┌', CellType.CONSTRUCTION_DESTROYED_UP_LEFT }, { '┐', CellType.CONSTRUCTION_DESTROYED_RIGHT_UP }, { '└', CellType.CONSTRUCTION_DESTROYED_DOWN_LEFT },
            { '┘', CellType.CONSTRUCTION_DESTROYED_DOWN_RIGHT }, { '•', CellType.BULLET }, { '▲', CellType.TANK_UP }, { '►', CellType.TANK_RIGHT }, { '▼', CellType.TANK_DOWN },
            { '◄', CellType.TANK_LEFT }, { '˄', CellType.OTHER_TANK_UP }, { '˃', CellType.OTHER_TANK_RIGHT }, { '˅', CellType.OTHER_TANK_DOWN }, { '˂', CellType.OTHER_TANK_LEFT },
            { '«', CellType.AUTOBOT_TANK_LEFT }, { '»', CellType.AUTOBOT_TANK_RIGHT }, { '?', CellType.AUTOBOT_TANK_UP }, { '¿', CellType.AUTOBOT_TANK_DOWN }
        };

        public static Color DANGER_MOVE_CELL = Color.Red;
        public static Color SAFE_MOVE_CELL = Color.Green;
        public static Color TARGET_CELL = Color.DarkCyan;

        public static Color DESTROYABLE_WALL_CELL = Color.DarkOrange;
        public static Color UNDESTROYABLE_WALL_CELL = Color.WhiteSmoke;
        public static Color ENEMY_TANK_CELL = Color.Green;
        public static Color BULLET_CELL = Color.Black;
        public static Color OUR_TANK_CELL = Color.DarkCyan;

        public int x, y;
        public CellType type;
        private Color _color;

        private Object containingObject;

        public void UpdateCell(int x, int y, char cellChar) {
            this.x = x;
            this.y = y;
            type = CharToCellType[cellChar];
        }

	}
}
