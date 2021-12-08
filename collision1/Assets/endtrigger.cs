
using UnityEngine;

public class endtrigger : MonoBehaviour
{
    public GameManager gamemanager;
   
     void OnCollisionEnter(Collision info)
    {
        if (info.collider.name == "player") { 
            gamemanager.CompleteLevel();
       }

    }
}
