using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_AI {
    class Board {

        private BoardCell[] _cells;
        
        public void Init(int cellsQuantity) {
            _cells = new BoardCell[cellsQuantity];
        }

        public void UpdateCells(string messageFromServer) {

        }
    }
}
