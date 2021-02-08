using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectionButton : MonoBehaviour
{
    public void MoveToCollection(string level)
    {
        SceneManager.LoadScene(level);
    }
}
