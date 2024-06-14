using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Swing : MonoBehaviour
{
    [SerializeField]
    private float _startForce = 10f;

    private Rigidbody _rigidbody;    

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();        
    }

    public void AddForce()
    {
        _rigidbody.AddForce(new Vector3(_startForce, 0, 0));
    }
    
}
