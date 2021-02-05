using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            }
            if (choice == 2)
            {
                Character currentCharacter = new Archer();
                Debug.Log("-- Personnage -- : " + currentCharacter.GetCharacterInfo.nom);
                Debug.Log("Vie: " + currentCharacter.GetCharacterInfo.vie);
                Debug.Log("Défense: " + currentCharacter.GetCharacterInfo.defense);
                Debug.Log("Attaque: " + currentCharacter.GetCharacterInfo.attack);
            }
            if (choice == 3)
            {
                Character currentCharacter = new Knight();
                Debug.Log("-- Personnage -- : " + currentCharacter.GetCharacterInfo.nom);
                Debug.Log("Vie: " + currentCharacter.GetCharacterInfo.vie);
                Debug.Log("Défense: " + currentCharacter.GetCharacterInfo.defense);
                Debug.Log("Attaque: " + currentCharacter.GetCharacterInfo.attack);
            }
            if (choice == 4)
            {
                Character currentCharacter = new Goblin();
                Debug.Log("-- Personnage -- : " + currentCharacter.GetCharacterInfo.nom);
                Debug.Log("Vie: " + currentCharacter.GetCharacterInfo.vie);
                Debug.Log("Défense: " + currentCharacter.GetCharacterInfo.defense);
                Debug.Log("Attaque: " + currentCharacter.GetCharacterInfo.attack);
            }
            if (choice == 5)
            {
                Character currentCharacter = new Orc();
                Debug.Log("-- Personnage -- : " + currentCharacter.GetCharacterInfo.nom);
                Debug.Log("Vie: " + currentCharacter.GetCharacterInfo.vie);
                Debug.Log("Défense: " + currentCharacter.GetCharacterInfo.defense);
                Debug.Log("Attaque: " + currentCharacter.GetCharacterInfo.attack);
            }
            if (choice == 6)
            {
                Character currentCharacter = new Troll();
                Debug.Log("-- Personnage -- : " + currentCharacter.GetCharacterInfo.nom);
                Debug.Log("Vie: " + currentCharacter.GetCharacterInfo.vie);
                Debug.Log("Défense: " + currentCharacter.GetCharacterInfo.defense);
                Debug.Log("Attaque: " + currentCharacter.GetCharacterInfo.attack);
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
            }
            if (choice == 2)
            {
                Equipment currentEquipment = new Dagger();
                Debug.Log("-- Equipement -- : " + currentEquipment.getEquipmentInfo.nom);
                Debug.Log("Attaque physique :" + currentEquipment.getEquipmentInfo.physical_attack);
                Debug.Log("Attaque magique :" + currentEquipment.getEquipmentInfo.magic_attack);
                Debug.Log("Défense :" + currentEquipment.getEquipmentInfo.defense);
            }
            if (choice == 3)
            {
                Equipment currentEquipment = new Sword();
                Debug.Log("-- Equipement -- : " + currentEquipment.getEquipmentInfo.nom);
                Debug.Log("Attaque physique :" + currentEquipment.getEquipmentInfo.physical_attack);
                Debug.Log("Attaque magique :" + currentEquipment.getEquipmentInfo.magic_attack);
                Debug.Log("Défense :" + currentEquipment.getEquipmentInfo.defense);
            }
            if (choice == 4)
            {
                Equipment currentEquipment = new Chestplate();
                Debug.Log("-- Equipement -- : " + currentEquipment.getEquipmentInfo.nom);
                Debug.Log("Attaque physique :" + currentEquipment.getEquipmentInfo.physical_attack);
                Debug.Log("Attaque magique :" + currentEquipment.getEquipmentInfo.magic_attack);
                Debug.Log("Défense :" + currentEquipment.getEquipmentInfo.defense);
            }
            if (choice == 5)
            {
                Equipment currentEquipment = new Mantle();
                Debug.Log("-- Equipement -- : " + currentEquipment.getEquipmentInfo.nom);
                Debug.Log("Attaque physique :" + currentEquipment.getEquipmentInfo.physical_attack);
                Debug.Log("Attaque magique :" + currentEquipment.getEquipmentInfo.magic_attack);
                Debug.Log("Défense :" + currentEquipment.getEquipmentInfo.defense);
            }
            if (choice == 6)
            {
                Equipment currentEquipment = new Shield();
                Debug.Log("-- Equipement -- : " + currentEquipment.getEquipmentInfo.nom);
                Debug.Log("Attaque physique :" + currentEquipment.getEquipmentInfo.physical_attack);
                Debug.Log("Attaque magique :" + currentEquipment.getEquipmentInfo.magic_attack);
                Debug.Log("Défense :" + currentEquipment.getEquipmentInfo.defense);
            }
        }
    }
 }
