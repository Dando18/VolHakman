using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesScript : MonoBehaviour
{

    public int lives = 3;


    public void Hurt()
    {
        lives = Mathf.Clamp(lives - 1, 0, 100);
    }

    public int GetLives()
    {
        return lives;
    }


    void OnGUI()
    {
        GUI.Label(new Rect(0, 0, Screen.width, Screen.height), "Lives: " + lives + "\nScore: " + GetComponent<EatScript>().GetScore() + 
            ((lives <= 0) ? "\nYou're Dead!" : ""));
    }
}