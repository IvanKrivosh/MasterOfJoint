using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private Transform _point;
    [SerializeField]
    private GameObject _bullet; 

    public void CreateBullet()
    {
        Instantiate(_bullet, _point);
    }
   
}
