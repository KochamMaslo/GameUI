using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using System.Xml.Serialization;
using System.IO;

public class SaveItemDatabase : MonoBehaviour
{
	void Start()
	{
		ItemDatabase database = new ItemDatabase();

		database.Items.Add(new Item("Duzy miecz", 12, 120));
		database.Items.Add(new Item("Mala tarcza", 0, 600));
		database.Items.Add(new Item("Slaby kolczan", 20, 300));
		database.Items.Add(new Item("Ciezka kolczuga", 0, 900));
		database.Items.Add(new Item("Wielka pulapka", 1100, 10000));
		database.Items.Add(new Item("Poczwarna swieca", 1, 12));
		database.Items.Add(new Item("Dwureczny topor", 123, 532));
		database.Items.Add(new Item("Krzeslo gracza", 200, 111));
		database.Items.Add(new Item("Poduszka spiocha", 1, 1));
		
		database.Save("D:/Program Files/Unity/Projects/UI System/New Unity Project/Assets/Saves/items.xml");
		
		Debug.Log("Database Saved");
	}
}