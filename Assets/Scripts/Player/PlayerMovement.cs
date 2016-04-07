using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _maxSpeed = 5;
    private Rigidbody2D _rigidbody2D;
	// Use this for initialization
	void Start ()
	{
	    _rigidbody2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    _rigidbody2D.velocity = new Vector2(Input.GetAxis("Horizontal"), 0) * _maxSpeed;
	}
}
