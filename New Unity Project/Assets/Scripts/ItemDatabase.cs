using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Xml.Serialization;

[XmlRoot("ItemDatabase")]
public class ItemDatabase
{
	[XmlArray("Items")] [XmlArrayItem("Item")]
	public List<Item> Items;

	public ItemDatabase GetItems()
	{
		return this;
	}

	public void SetItems(List<Item> items)
	{
		Items = items;
	}

	public void Save(string path)
	{
		var serializer = new XmlSerializer(typeof(ItemDatabase));
		using (var stream = new FileStream(path, FileMode.Create))
		{
			serializer.Serialize(stream, this);
		}
	}

	public ItemDatabase()
	{
		Items = new List<Item>();
	}

	public static ItemDatabase Load(string path)
	{
		var serializer = new XmlSerializer(typeof(ItemDatabase));
		using (var stream = new FileStream(path, FileMode.Open))
		{
			return serializer.Deserialize(stream) as ItemDatabase;
		}
	}

	public static void ShowDatabase(ItemDatabase itemDatabase)
	{
		foreach (var item in itemDatabase.Items)
		{
			item.ShowItem();
		}
	}

	public static ItemDatabase LoadFromText(string text)
	{
		var serializer = new XmlSerializer(typeof(ItemDatabase));
		return serializer.Deserialize(new StringReader(text)) as ItemDatabase;
	}
}