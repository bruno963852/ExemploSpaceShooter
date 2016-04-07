using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Assertions.Comparers;

public class EnemyDestroy : MonoBehaviour
{
    [SerializeField]
    private float _enemyHealth = 2;
    [SerializeField]
    private Transform _explosionPrefab;

    [SerializeField] private float _damageToPlayer = 3;
    [SerializeField] private int _points = 100;
   

    public void DoDamage(float damage)
    {
        _enemyHealth -= damage;
        if (_enemyHealth <= 0)
        {
            GameManager.instance.Points += _points;
            Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Player", StringComparison.OrdinalIgnoreCase))
        {
            other.GetComponent<PlayerDestroy>().DoDamage(_damageToPlayer);
            Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
