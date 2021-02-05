using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

	#region Singleton

	public static Inventory instance;

	void Awake ()
	{
		instance = this;
	}

	#endregion

	public delegate void OnItemChanged();
	public OnItemChanged onItemChangedCallback;

	public List<Character> persos = new List<Character>();
	public List<Equipment> items = new List<Equipment>();

	public void AddEquip (Equipment item)
	{
		items.Add (item);

		if (onItemChangedCallback != null)
		onItemChangedCallback.Invoke ();
	}

	public void AddPerso (Character perso)
	{
		persos.Add(perso);

		if (onItemChangedCallback != null) 
			onItemChangedCallback.Invoke();
	}
}
