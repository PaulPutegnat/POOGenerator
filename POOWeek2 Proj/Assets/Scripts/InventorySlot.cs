using UnityEngine;

public class InventorySlot : MonoBehaviour
{

	Equipment item; 


	public void AddItem(Equipment newItem)
	{
		item = newItem;
	}

}
