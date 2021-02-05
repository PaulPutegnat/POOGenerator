using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour
{
	public Character equip = new Character();
	public Equipment perso = new Equipment();

	public Text name;



	public void AddCharac(Character newCharac)
	{
		name.text = newCharac.GetCharacterInfo.nom;
	}

	public void AddItem(Equipment newItem)
	{
		name.text = newItem.getEquipmentInfo.nom;
	}

}
