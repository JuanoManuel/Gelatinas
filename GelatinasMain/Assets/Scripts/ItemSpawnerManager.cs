using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ItemSpawnerManager : MonoBehaviour
{
    public Item[] items;

    public Item GetRandomItem()
    {
        System.Random rand = new System.Random();
        return items[rand.Next(items.Length)];
    }

}
