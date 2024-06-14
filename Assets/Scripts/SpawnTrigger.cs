using UnityEngine;
using UnityEngine.Events;

public class SpawnTrigger : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _bucketCameBack;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Bucket>(out Bucket bucket))
        {
            _bucketCameBack.Invoke();
        }
    }
}
