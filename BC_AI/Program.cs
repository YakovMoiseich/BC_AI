using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using PureWebSockets;

namespace BC_AI {
	static class Program {

		private static WebSocketController _wsController;

		[STAThread]
		static void Main() {
			_wsController = new WebSocketController();
			_wsController.Init();
			_wsController.webSocket.MessageReceived += (sender, args) => {
				Console.WriteLine($"data={args.Message}");
//				ProcessInputMessage(args.Message);
			};

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}

//		void ProcessInputMessage() {
//			
//		}
	}
}
