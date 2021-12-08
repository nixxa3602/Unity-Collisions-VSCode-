
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 xyz;
    void Update()
    {
        transform.position = player.position+ xyz;
        
    }
}
