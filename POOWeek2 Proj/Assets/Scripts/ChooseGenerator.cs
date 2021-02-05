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
                Debug.Log(currentCharacter.getCharacterInfo.nom);
                Debug.Log(currentCharacter.getCharacterInfo.vie);
            }
            if (choice == 2)
            {
                Character currentCharacter = new Archer();
                Debug.Log(currentCharacter.getCharacterInfo.nom);
                Debug.Log(currentCharacter.getCharacterInfo.vie);
            }
            if (choice == 3)
            {
               Character currentCharacter = new Knight();
               Debug.Log(currentCharacter.getCharacterInfo.nom);
               Debug.Log(currentCharacter.getCharacterInfo.vie);
            }
            if (choice == 4)
            {
                Character currentCharacter = new Goblin();
                Debug.Log(currentCharacter.getCharacterInfo.nom);
                Debug.Log(currentCharacter.getCharacterInfo.vie);
            }
            if (choice == 5)
            {
                Character currentCharacter = new Orc();
                Debug.Log(currentCharacter.getCharacterInfo.nom);
                Debug.Log(currentCharacter.getCharacterInfo.vie);
            }
            if (choice == 6)
            {
                Character currentCharacter = new Troll();
                Debug.Log(currentCharacter.getCharacterInfo.nom);
                Debug.Log(currentCharacter.getCharacterInfo.vie);
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
                Debug.Log(currentEquipment.getEquipmentInfo.nom);
                Debug.Log(currentEquipment.getEquipmentInfo.physical_attack);
            }
            if (choice == 2)
            {
                Equipment currentEquipment = new Dagger();
                Debug.Log(currentEquipment.getEquipmentInfo.nom);
                Debug.Log(currentEquipment.getEquipmentInfo.physical_attack);
            }
            if (choice == 3)
            {
                Equipment currentEquipment = new Sword();
                Debug.Log(currentEquipment.getEquipmentInfo.nom);
                Debug.Log(currentEquipment.getEquipmentInfo.physical_attack);
            }
            if (choice == 4)
            {
                Equipment currentEquipment = new Chestplate();
                Debug.Log(currentEquipment.getEquipmentInfo.nom);
                Debug.Log(currentEquipment.getEquipmentInfo.physical_attack);
            }
            if (choice == 5)
            {
                Equipment currentEquipment = new Mantle();
                Debug.Log(currentEquipment.getEquipmentInfo.nom);
                Debug.Log(currentEquipment.getEquipmentInfo.physical_attack);
            }
            if (choice == 6)
            {
                Equipment currentEquipment = new Shield();
                Debug.Log(currentEquipment.getEquipmentInfo.nom);
                Debug.Log(currentEquipment.getEquipmentInfo.physical_attack);
            }
        }
    }
 }
