using UnityEngine;
using System.Collections;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] private float _minXPosition = -6;
    [SerializeField] private float _maxXPosition = 6;
    [SerializeField] private float _minSpeed = 2;
    [SerializeField] private float _maxSpeed = 6;
    [SerializeField] private float _minInterval = 0.2f;
    [SerializeField] private float _maxInterval = 0.4f;

    [SerializeField] private GameObject[] _enemyPrefabs;

	// Use this for initialization
	void Start ()
    {
	    StartGenerating();
	}

    public void StartGenerating()
    {
        GenerateEnemy();
    }

    public void StopGenerating()
    {
        CancelInvoke("GenerateEnemy");
    }

    private void GenerateEnemy()
    {
        var enemy = Instantiate(GetRandomEnemy(), transform.position + Vector3.right * Random.Range(_minXPosition, _maxXPosition), Quaternion.identity) as GameObject;
        enemy.GetComponent<Rigidbody2D>().velocity = Vector2.down * Random.Range(_minSpeed, _maxSpeed);

        Invoke("GenerateEnemy", Random.Range(_minInterval, _maxInterval));
    }

    private GameObject GetRandomEnemy()
    {
        return _enemyPrefabs[Random.Range(0, _enemyPrefabs.Length - 1)];
    }

}
