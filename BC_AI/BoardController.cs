using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_AI {
	class BoardController {

        private int _maxFramesQuantity = 10;
        private Board[] _boardsFrames;

        public void Init() {
            _boardsFrames = new Board[10];
        }

		public void UpdateBoards(string boardState) {
			
		}

        public void DrawDebugInfo() {

        }

	}
}
