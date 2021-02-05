using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ChooseGenerator : MonoBehaviour
{
    public void SpawnCharacters() 
    {
        for (int i = 0; i < 3; i++)
        {

            int choice = Random.Range(1, 7);
             
            if (choice == 1)
            {
                Character currentCharacter = new Warlock();
                Debug.Log("-- Personnage -- : " + currentCharacter.GetCharacterInfo.nom);
                Debug.Log("Vie: " + currentCharacter.GetCharacterInfo.vie);
                Debug.Log("Défense: " + currentCharacter.GetCharacterInfo.defense);
                Debug.Log("Attaque: " + currentCharacter.GetCharacterInfo.attack);
                InventorySlot AddCharac(Character Warlock);
                Inventory AddPerso(Character Warlock);
            }
            if (choice == 2)
            {
                Character currentCharacter = new Archer();
                Debug.Log("-- Personnage -- : " + currentCharacter.GetCharacterInfo.nom);
                Debug.Log("Vie: " + currentCharacter.GetCharacterInfo.vie);
                Debug.Log("Défense: " + currentCharacter.GetCharacterInfo.defense);
                Debug.Log("Attaque: " + currentCharacter.GetCharacterInfo.attack);
                InventorySlot AddCharac(Character Archer);
                Inventory AddPerso(Character Archer);
            }
            if (choice == 3)
            {
                Character currentCharacter = new Knight();
                Debug.Log("-- Personnage -- : " + currentCharacter.GetCharacterInfo.nom);
                Debug.Log("Vie: " + currentCharacter.GetCharacterInfo.vie);
                Debug.Log("Défense: " + currentCharacter.GetCharacterInfo.defense);
                Debug.Log("Attaque: " + currentCharacter.GetCharacterInfo.attack);
                InventorySlot AddCharac(Character Knight);
                Inventory AddPerso(Character Knight);
            }
            if (choice == 4)
            {
                Character currentCharacter = new Goblin();
                Debug.Log("-- Personnage -- : " + currentCharacter.GetCharacterInfo.nom);
                Debug.Log("Vie: " + currentCharacter.GetCharacterInfo.vie);
                Debug.Log("Défense: " + currentCharacter.GetCharacterInfo.defense);
                Debug.Log("Attaque: " + currentCharacter.GetCharacterInfo.attack);
                InventorySlot AddCharac(Character Goblin);
                Inventory AddPerso(Character Goblin);
            }
            if (choice == 5)
            {
                Character currentCharacter = new Orc();
                Debug.Log("-- Personnage -- : " + currentCharacter.GetCharacterInfo.nom);
                Debug.Log("Vie: " + currentCharacter.GetCharacterInfo.vie);
                Debug.Log("Défense: " + currentCharacter.GetCharacterInfo.defense);
                Debug.Log("Attaque: " + currentCharacter.GetCharacterInfo.attack);
                InventorySlot AddCharac(Character Orc);
                Inventory AddPerso(Character Orc);
            }
            if (choice == 6)
            {
                Character currentCharacter = new Troll();
                Debug.Log("-- Personnage -- : " + currentCharacter.GetCharacterInfo.nom);
                Debug.Log("Vie: " + currentCharacter.GetCharacterInfo.vie);
                Debug.Log("Défense: " + currentCharacter.GetCharacterInfo.defense);
                Debug.Log("Attaque: " + currentCharacter.GetCharacterInfo.attack);
                InventorySlot AddCharac(Character Troll);
                Inventory AddPerso(Character Troll);
            }
        }
    }

    public void SpawnEquipements()
    {
        for (int i = 0; i < 3; i++)
        {
            int choice = Random.Range(1, 7);

            if (choice == 1)
            {
                Equipment currentEquipment = new Staff();
                Debug.Log("-- Equipement -- : " + currentEquipment.getEquipmentInfo.nom);
                Debug.Log("Attaque physique :" + currentEquipment.getEquipmentInfo.physical_attack);
                Debug.Log("Attaque magique :" + currentEquipment.getEquipmentInfo.magic_attack);
                Debug.Log("Défense :" + currentEquipment.getEquipmentInfo.defense);
                InventorySlot AddItem(Equipment Staff);
                Inventory AddItem(Equipment Staff);
            }
            if (choice == 2)
            {
                Equipment currentEquipment = new Dagger();
                Debug.Log("-- Equipement -- : " + currentEquipment.getEquipmentInfo.nom);
                Debug.Log("Attaque physique :" + currentEquipment.getEquipmentInfo.physical_attack);
                Debug.Log("Attaque magique :" + currentEquipment.getEquipmentInfo.magic_attack);
                Debug.Log("Défense :" + currentEquipment.getEquipmentInfo.defense);
                InventorySlot AddItem(Equipment Dagger);
                Inventory AddItem(Equipment Dagger);
            }
            if (choice == 3)
            {
                Equipment currentEquipment = new Sword();
                Debug.Log("-- Equipement -- : " + currentEquipment.getEquipmentInfo.nom);
                Debug.Log("Attaque physique :" + currentEquipment.getEquipmentInfo.physical_attack);
                Debug.Log("Attaque magique :" + currentEquipment.getEquipmentInfo.magic_attack);
                Debug.Log("Défense :" + currentEquipment.getEquipmentInfo.defense);
                InventorySlot AddItem(Equipment Sword);
                Inventory AddItem(Equipment Sword);
            }
            if (choice == 4)
            {
                Equipment currentEquipment = new Chestplate();
                Debug.Log("-- Equipement -- : " + currentEquipment.getEquipmentInfo.nom);
                Debug.Log("Attaque physique :" + currentEquipment.getEquipmentInfo.physical_attack);
                Debug.Log("Attaque magique :" + currentEquipment.getEquipmentInfo.magic_attack);
                Debug.Log("Défense :" + currentEquipment.getEquipmentInfo.defense);
                InventorySlot AddItem(Equipment Chestplate);
                Inventory AddItem(Equipment Chestplate);
            }
            if (choice == 5)
            {
                Equipment currentEquipment = new Mantle();
                Debug.Log("-- Equipement -- : " + currentEquipment.getEquipmentInfo.nom);
                Debug.Log("Attaque physique :" + currentEquipment.getEquipmentInfo.physical_attack);
                Debug.Log("Attaque magique :" + currentEquipment.getEquipmentInfo.magic_attack);
                Debug.Log("Défense :" + currentEquipment.getEquipmentInfo.defense);
                InventorySlot AddItem(Equipment Mantle);
                Inventory AddItem(Equipment Mantle);
            }
            if (choice == 6)
            {
                Equipment currentEquipment = new Shield();
                Debug.Log("-- Equipement -- : " + currentEquipment.getEquipmentInfo.nom);
                Debug.Log("Attaque physique :" + currentEquipment.getEquipmentInfo.physical_attack);
                Debug.Log("Attaque magique :" + currentEquipment.getEquipmentInfo.magic_attack);
                Debug.Log("Défense :" + currentEquipment.getEquipmentInfo.defense);
                InventorySlot AddItem(Equipment Shield);
                Inventory AddItem(Equipment Shield);
            }
        }
    }
 }
