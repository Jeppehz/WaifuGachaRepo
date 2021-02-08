using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryControl : MonoBehaviour
{
    private List<WaifuItem> waifuInventory;

    [SerializeField]
    private GameObject buttonTemplate;
    [SerializeField]
    private GridLayoutGroup gridGroup;

    [SerializeField]
    private Sprite[] iconSprites;

    void Start()
    {
        waifuInventory = new List<WaifuItem>();

        for (int i = 1; i <= 100; i++)
        {
            WaifuItem newItem = new WaifuItem();
            newItem.iconSprite = iconSprites[Random.Range(0, iconSprites.Length)];

            waifuInventory.Add(newItem);
        }
        GenInventory();
    }

    void GenInventory()
    {
        if (waifuInventory.Count < 11)
        {
            gridGroup.constraintCount = waifuInventory.Count;
        }
        else
        {
            gridGroup.constraintCount = 10;
        }

        foreach(WaifuItem newItem in waifuInventory)
        {
            GameObject newButton = Instantiate(buttonTemplate) as GameObject;
            newButton.SetActive(true);

            newButton.GetComponent<InventoryButton>().SetIcon(newItem.iconSprite);
            newButton.transform.SetParent(buttonTemplate.transform.parent, false);
        }
    }

    public class WaifuItem
    {
        public Sprite iconSprite;
    }
}
