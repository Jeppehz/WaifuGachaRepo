using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaifuStoreButton : MonoBehaviour
{
    public void MoveToStore(string level)
    {
        SceneManager.LoadScene(level);
    }
}
