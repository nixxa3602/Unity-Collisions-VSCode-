
using UnityEngine;

public class playercollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision info)
    {
        if (info.collider.tag=="Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();

        }
        
    }

}
