using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    private float score = 0;
    private Text scoreText;
    private AudioSource source;
	// Use this for initialization
	void Start ()
    {
        scoreText = GetComponent<Text>();
        scoreText.text = "";

        source = GetComponent<AudioSource>();
    }
	
    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();

        if(source.isPlaying) source.Stop();
        source.Play();
    }
}
