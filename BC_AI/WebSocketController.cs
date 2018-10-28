using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using WebSocket4Net;

namespace BC_AI {
	class WebSocketController
	{
		private static readonly string defaultServerUri = "ws://178.128.139.126:19899/codenjoy-contest/ws";
		private static readonly string defaultUserName = "sherbayv@gmail.com&code=3868260331090165314";

		private static readonly Regex patternRegex = new Regex("^board=(.*)$");

		public WebSocket webSocket;

		public void Init()
		{
			var serverUri = defaultServerUri;
			var userName = defaultUserName;

			try
			{
				Start(serverUri + "?user=" + userName);
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error occurred: {ex}");
			}
		}

		private void Start(string serverUri)
		{
			webSocket = new WebSocket(serverUri);

			webSocket.Opened += (sender, args) =>
			{
				Console.WriteLine("Opened");
			};
			webSocket.Closed += (sender, args) =>
			{
				Console.WriteLine("Closed");
			};

			webSocket.MessageReceived += (sender, args) =>
			{
				Console.WriteLine($"data={args.Message}");

//				ProcessMessage(args.Message)
			};

			webSocket.Error += (sender, args) =>
			{
				Console.WriteLine($"Error occurred: {args.Exception}");
			};

			webSocket.Open();
		}

		private void Stop()
		{
			if (webSocket != null)
			{
				webSocket.Close();
				webSocket.Dispose();
				webSocket = null;
			}
		}

		private void ProcessMessage(string message)
		{
			var match = patternRegex.Match(message);
			if (!match.Success)
			{
				throw new ApplicationException($"Cannot match message: '{message}'");
			}
		}
	}
}
