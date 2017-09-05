using UnityEngine;
using System.Collections;
using WebSocketSharp;
using WebSocketSharp.Net;

public class ClientExample: MonoBehaviour {

	WebSocket ws;

	void Start()
	{
		ws = new WebSocket("ws://192.168.10.103:8080/WebSocketUnity/loadMessage");

		ws.OnOpen += (sender, e) =>
		{
			Debug.Log("WebSocket Open");
		};

		ws.OnMessage += (sender, e) =>
		{
			Debug.Log(e.Data);
		};

		ws.OnError += (sender, e) =>
		{
			Debug.Log("WebSocket Error Message: " + e.Message);
		};

		ws.OnClose += (sender, e) =>
		{
			Debug.Log("WebSocket Close");
		};

		ws.Connect();

	}

	void Update()
	{

		if (Input.GetKeyUp("s"))
		{
			ws.Send("1");
		}

	}

	void OnDestroy()
	{
		ws.Close();
		ws = null;
	}
}