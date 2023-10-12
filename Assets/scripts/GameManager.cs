
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  
    public float Delay_victory = 1f;
    bool Endgame = false;
    public GameObject CompleteUi;
 
    public void completeLevel()
    {
        CompleteUi.SetActive(true);
    }
    public void EndGame()
    {
        if (Endgame == false)
        {
            Endgame = true;
            Debug.Log("Game over");
          
            Invoke("Restart", Delay_victory);

        }

     
    }
    public void Restart()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
}
