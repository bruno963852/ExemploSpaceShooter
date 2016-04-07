using UnityEngine;
using System.Collections;

public class PlayerShot : MonoBehaviour
{
    [SerializeField] private Transform _shotPrefab;
    [SerializeField] private float _shotSpeed = 8;
    [SerializeField] private float _timeBetweenShots = 0.4f;
    [SerializeField] private AudioClip _shotSound;

    private AudioSource _audioSource;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

	// Update is called once per frame
	void Update ()
	{
	    if (Input.GetButtonDown("Jump"))
	    {
	        InvokeRepeating("Shoot", 0, _timeBetweenShots);
	    }
        if (Input.GetButtonUp("Jump"))
        {
            CancelInvoke("Shoot");
        }
    }

    private void Shoot()
    {
        var shot = Instantiate(_shotPrefab, transform.position, Quaternion.identity) as Transform;
        shot.GetComponent<Rigidbody2D>().velocity = Vector2.up * _shotSpeed;
        _audioSource.PlayOneShot(_shotSound);
    }
}
