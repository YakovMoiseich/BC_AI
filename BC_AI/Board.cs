using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_AI {
    class Board {

        private List<BoardCell> _cells;

        public void Init(int cellsQuantity) {
            _cells = new List<BoardCell>();
        }

        public void UpdateCells(string messageFromServer) {
            int battlefieldSize = (int)Math.Sqrt(messageFromServer.Length);
            int x, y = 0;
            for (int i = 0; i < messageFromServer.Length; ++i) {
                BoardCell cell = new BoardCell();
                y = i / battlefieldSize;
                x = i - y * battlefieldSize;
                char ch = messageFromServer[i];
                cell.UpdateCell(x, y, messageFromServer[i]);
                _cells.Add(cell);
            }

            BoardCell cellTest = GetCellByCoords(35, -1);
            BoardCell cellTest2 = GetCellByCoords(13, 9);
        }

        public BoardCell GetCellByCoords(int x, int y) {
            int boardSize = (int)Math.Sqrt(_cells.Count);
            if (x >= boardSize || y >= boardSize) {
                return null;
            }

            return _cells[y * boardSize + x];
        }
    }

}
