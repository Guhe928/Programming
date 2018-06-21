using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAMEMANAGERS : MonoBehaviour {
    void EndGame ()
    {
        Debug.Log("GAMEOVER");
    }




    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
    }
    
}
