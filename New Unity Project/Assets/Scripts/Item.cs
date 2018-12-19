using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using UnityEditor;

public class Item
{
	[XmlAttribute("id")] public uint Id;
	public static uint NextId = 0;

	public string Name;

	public uint Damage;
	public uint Durability;

	public Item(string name, uint damage, uint durability)
	{
		Id = NextId++;
		Name = name;
		Damage = damage;
		Durability = durability;
	}

	public Item()
	{
		Id = NextId++;
		Name = "";
	}

	public void ShowItem()
	{
		Debug.Log("ID: " + this.Id + "\n" + "Name : " + this.Name + "\n" + "Damage: " + this.Damage + "\n" + "Durability: " + this.Durability);
	}
	
	public string ReturnShowItem()
	{
		return ("ID: " + this.Id + "\n" + "Name : " + this.Name + "\n" + "Damage: " + this.Damage + "\n" + "Durability: " + this.Durability);
	}
}
