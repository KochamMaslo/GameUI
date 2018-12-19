using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayGUI : MonoBehaviour {
	
	public ItemDatabase itemsDatabase = new ItemDatabase();

	public void SetItemDatabase(ItemDatabase itemDatabase)
	{
		this.itemsDatabase = itemDatabase;
	}

	void OnGUI()
	{
		GUILayout.BeginArea(new Rect((int)Screen.width/2 - 250/2, (int)Screen.height/2 - 55 * (itemsDatabase.Items.Count/2), 250, 55 * itemsDatabase.Items.Count), GUI.skin.GetStyle("Button"));
		foreach(var items in itemsDatabase.Items)
		{
			GUILayout.Label(items.ReturnShowItem());
		}
		GUILayout.EndArea();
	}
}