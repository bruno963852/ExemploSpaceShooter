using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    private Image _lifeBar;
    private float _maxLife;

	// Use this for initialization
	void Start ()
	{
	    _lifeBar = GetComponent<Image>();
	    _maxLife = GameManager.instance.PlayerLife;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    _lifeBar.fillAmount = GameManager.instance.PlayerLife / _maxLife;
	}
}
