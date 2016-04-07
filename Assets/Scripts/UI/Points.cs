using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    private Text _points;
	// Use this for initialization
	void Start ()
	{
	    _points = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    _points.text = string.Format("{0:D7}", GameManager.instance.Points);
	}
}
