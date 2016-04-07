using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    private Text highScore;
	// Use this for initialization
	void Start ()
	{
	    highScore = GetComponent<Text>();
	    highScore.text = string.Format("{0:D7}", GameManager.instance.GetHighScore());
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
