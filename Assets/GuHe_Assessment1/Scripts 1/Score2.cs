using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score2 : MonoBehaviour {

    public Transform player;
    public Text scoreText;

	// Update is called once per frame
	void Update () {
        scoreText.text = player.position.z.ToString("0");
    }
}
