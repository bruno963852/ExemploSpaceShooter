using UnityEngine;
using System.Collections;
using System.Linq;

public class Destroyer : MonoBehaviour
{
    [SerializeField] private string[] _tagsToDestroy;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (_tagsToDestroy.Contains(other.tag))
        {
            Destroy(other.gameObject);
        }
    }
}
