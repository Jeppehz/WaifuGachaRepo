using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalMesos : MonoBehaviour
{
    public static int MesoCount;
    public GameObject MesoDisplay;
    public int InternalMeso;

    void Update ()
    {
        InternalMeso = MesoCount;
        MesoDisplay.GetComponent<Text>().text = "Mesos: " + InternalMeso;

    }
}
