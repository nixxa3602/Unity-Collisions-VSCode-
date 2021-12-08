
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{   
    bool x= false;
    float restartdelay = 1f;
    public GameObject completelevelUI;
    public void GameOver()
    {
        if (x == false)
        {
            Debug.Log("GAME OVER");
            x = true;
            Invoke("Restart", restartdelay);

        }
    }

    public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name );
        }
        
    public void CompleteLevel()
    {
        completelevelUI.SetActive(true);
        x = true;


    }
   
}
