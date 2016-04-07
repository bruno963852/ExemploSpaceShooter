using UnityEngine;
using System.Collections;

public class PlayerDestroy : MonoBehaviour
{
    [SerializeField] private GameObject _explosionPrefab;

    public void DoDamage(float damage)
    {
        GameManager.instance.PlayerLife -= damage;
        if (GameManager.instance.PlayerLife <= 0)
        {
            GameManager.instance.GameOverDelayed(2);
            GameManager.instance.SaveHighScore();
            Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
