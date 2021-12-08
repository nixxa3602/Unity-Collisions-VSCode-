
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public Transform playerscore;
    public Text Score;
    void Update()
    {
        Score.text= playerscore.position.z.ToString("0");
        
    }

     
    
        
    
}
