using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New Item",menuName = "Gelatinas/Item")]
public class Item : ScriptableObject
{
    public string itemType;
    public Texture itemIcon;

    public void UseItem()
    {
        Debug.Log($"El item {itemType} fue usado");
    }
}
