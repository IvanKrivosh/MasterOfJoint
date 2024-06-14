using UnityEngine;

public class Catapult : MonoBehaviour
{
    [SerializeField] 
    private SpringJoint _joint;

    private Rigidbody _connectedBody;

    private void Awake()
    {
        _connectedBody = _joint.connectedBody;
        DisableSpring();
    }

    public void Shoot()
    {
        EnableSpring();
    }

    public void Reload()
    {
        DisableSpring();
        _connectedBody.WakeUp();
    }

    private void DisableSpring()
    {
        _joint.connectedBody = null;
    }

    private void EnableSpring()
    {
        _joint.connectedBody = _connectedBody;
    }
}
