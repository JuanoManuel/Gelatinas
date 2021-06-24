using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemContainer : MonoBehaviour
{
    public Item item;
    private Animator animator;
    private ItemSpawnerManager spawner;

    private void Start()
    {
        animator = GetComponent<Animator>();
        spawner = GameObject.FindGameObjectWithTag("GameController").GetComponent<ItemSpawnerManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player")
            return;
        if (!other.gameObject.GetComponent<playerItemManager>().HasItem())
        {
            other.gameObject.GetComponent<playerItemManager>().EquipItem(item);
            item = spawner.GetRandomItem();
            StartCoroutine(ScaleDownItemContainer());
        }
    }

    private IEnumerator ScaleDownItemContainer()
    {
        animator.SetBool("pickUp", true);

        yield return new WaitForSeconds(5);

        animator.SetBool("pickUp", false);
    }
}
