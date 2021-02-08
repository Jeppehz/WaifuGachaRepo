using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyAWaifu : MonoBehaviour
{
    public GameObject textBox;
    public GameObject statusBox;
    public List<GameObject> waifuText;
    public int[] table =
    {
        60, //small
        30, //medium
        10 //large 
    };

    public int total;
    public int randomNumber;

    private void Start()
    {
        foreach (var item in table)
        {
            total += item;
        }
    }


    public void ClickBuy()
    {

        if (GlobalMesos.MesoCount <= 9)
        {
            statusBox.GetComponent<Text>().text = "You don't have enough meso to perform that transaction.";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else
        {
            GlobalMesos.MesoCount -= 10;
            statusBox.GetComponent<Text>().text = "You got a Waifu!";
            statusBox.GetComponent<Animation>().Play("StatusAnim");

                randomNumber = Random.Range(0, total);

                for(int i = 0; i < table.Length; i++)
                {
                    waifuText[i].SetActive(false);
                    if (randomNumber <= table[i])
                    {
                        waifuText[i].SetActive(true);
                        return;
                    }
                    else
                    {
                        randomNumber -= table[i];
                    }
                }

            //randomNumber = 49

            //is 49 < 60
            //small

            //randomNumber = 61
            //is 61 <= 60
            //no = ??
            //61 - 60 = 1
            //1 <= 30?
            //yes = medium

            //randomNumber = 92
            //is 92 <= 60
            //92 - 60
            //32 <= 30?
            //no. 32 - 30 = 2
            //2 <= 10?
            //yes = large
        }
    }
}

