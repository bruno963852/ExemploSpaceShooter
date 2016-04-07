using UnityEngine;
using System.Collections;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField] float _bulletDamage = 1;
    [SerializeField] private Transform _explosionPrefab;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<EnemyDestroy>().DoDamage(_bulletDamage);
            Destroy(gameObject);
            Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
        }        
    }
}
