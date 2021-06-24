using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemReplaceTexture : MonoBehaviour
{
    public playerItemManager item;
   
    public void ChangeTexture()
    {
        item.ReplaceTexture();
    }
}
