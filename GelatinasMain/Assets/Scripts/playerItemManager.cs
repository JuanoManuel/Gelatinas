using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerItemManager : MonoBehaviour
{
    Item itemEquipped;
    public string itemEquippedName;
    public GameObject itemCard;
    public Texture questionTexture;

    private Animator animator;
    private void Start()
    {
        animator = itemCard.GetComponent<Animator>();
    }

    private IEnumerator UseItemEquipped()
    {
        yield return new WaitForSeconds(6);
        animator.SetBool("Show", false);
        itemEquipped.UseItem();
        itemEquipped = null;
    }

    public void EquipItem(Item item)
    {
        itemEquipped = item;
        itemEquippedName = item.itemType;
        itemCard.GetComponent<Renderer>().materials[0].mainTexture = questionTexture;
        animator.SetBool("Show", true);
        StartCoroutine(UseItemEquipped());

    }

    public bool HasItem()
    {
        return itemEquipped == null ? false : true;
    }

    public void ReplaceTexture()
    {
        itemCard.GetComponent<Renderer>().materials[0].mainTexture = itemEquipped.itemIcon;
    }
}
