using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGoal : MonoBehaviour {

    public GAMEMANAGERS gameManager;
    
    void OnTriggerEnter ()
    {
        gameManager.CompleteLevel();
    }
}
