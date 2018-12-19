using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using System.Xml.Serialization;
using System.IO;
using UnityEngine.UI;
using UnityEditor;

public class LoadItemDatabase : MonoBehaviour
{
	private static ItemDatabase _database = new ItemDatabase();
	
	void Start()
	{
		_database = ItemDatabase.Load("D:/Program Files/Unity/Projects/UI System/New Unity Project/Assets/Saves/items.xml");
		_database.SetItems(_database.Items);
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.E) && GameObject.Find("DisplayGUI") == null)
		{
			GameObject displayGUIGO = new GameObject("DisplayGUI");
			displayGUIGO.AddComponent<DisplayGUI>();

			DisplayGUI displayGUI = displayGUIGO.GetComponent<DisplayGUI>();

			displayGUI.SetItemDatabase(_database);
		}

		if (Input.GetKeyUp(KeyCode.E) && GameObject.Find("DisplayGUI") != null)
		{
			GameObject toDelete = GameObject.Find("DisplayGUI");
			Destroy(toDelete.GetComponent("DisplayGUI"));
			Destroy(toDelete);
		}
	}
}