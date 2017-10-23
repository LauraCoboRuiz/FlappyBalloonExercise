using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    private ScoreUI scoreUI;

    void Start()
    {
        scoreUI = GameObject.Find("Score").GetComponent<ScoreUI>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            //Sumar puntuación
            scoreUI.AddScore();
        }
    }
}
