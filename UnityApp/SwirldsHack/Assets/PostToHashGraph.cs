﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostToHashGraph : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
		Debug.Log("Lance - Start");

		var postData = @"{
""phoneNumber"": ""16464092810"",
""name"": ""Ina Yosun"",
""latitude"": ""37.7780897"",
""longitude"": ""-122.3846353"",
""type"": ""person"",
""crisis"": ""fire"",
""startTime"": 1505616761856,
""endTime"": 1505616761859,
""status"": ""open""
		}";
		var rawData = System.Text.Encoding.UTF8.GetBytes(postData);

		string url = "http://localhost:9111";

		Hashtable headers = new Hashtable();
		WWW www = new WWW(url, rawData, headers);
		yield return www;

		Debug.Log("Lance - www result: " + www.text);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
