using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_AI {
	class BoardController {

        private int _maxFramesQuantity = 10;
        private List<Board> _boardsFrames;

        public void Init() {
            _boardsFrames = new List<Board>();
        }

        public void AddBoardFrame(string boardState) {
            Board board = new Board();
            board.Init(boardState.Length);
            board.UpdateCells(boardState);
            UpdateBoardsFrames(board);
        }

		private void UpdateBoardsFrames(Board board) {
            if (_boardsFrames.Count >= _maxFramesQuantity) {
                _boardsFrames.RemoveAt(0);
                
            }

            _boardsFrames.Add(board);
        }

        public void DrawDebugInfo() {

        }

	}
}
