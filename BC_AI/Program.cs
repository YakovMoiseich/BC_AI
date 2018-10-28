using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BC_AI {
	static class Program {

		private static WebSocketController _wsController;
        private static BoardController _boardController;
        private static BotController3000 _botController;

		[STAThread]
		static void Main() {
			_wsController = new WebSocketController();
            _wsController.Init();
            _boardController = new BoardController();
            _boardController.Init();
            _botController = new BotController3000();
            _botController.Init();


            _wsController.webSocket.MessageReceived += (sender, args) => {
				Console.WriteLine($"data={args.Message}");
                string board = args.Message.Remove(0, 6);
                _boardController.AddBoardFrame(board);
                string nextActions = _botController.CalculateNextActions();
                _wsController.webSocket.Send(nextActions);

            };

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}

	}

}
