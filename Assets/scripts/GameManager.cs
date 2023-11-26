
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  
    public float Delay_victory = 1f;
    bool Endgame = false;
    public GameObject CompleteUi;
    [SerializeField]
    private GameObject gameover;
    [SerializeField]
    playerBehaviour _playerBehaviur;
    private bool _isgameComplete = false;
    private LevelComplete _levelComplete;
    public bool IsGameComplete
    {  get { return _isgameComplete; } 
        set { _isgameComplete = value; }
    }
    //private void Awake()
    //{
    //    _playerBehaviur = GameObject.FindGameObjectWithTag("Player").GetComponent<playerBehaviour>();
    //}
    public void completeLevel(string PlayerName)
    {
        _levelComplete = CompleteUi.GetComponent<LevelComplete>();
        _levelComplete.text.text = PlayerName;
        IsGameComplete = true;
        CompleteUi.SetActive(true);
    }
    public void EndGame()
    {
        if (Endgame == false)
        {
          
            Endgame = true;
            Debug.Log("Game over");
            gameover.SetActive(true);
            Invoke("Restart", Delay_victory);
            
        }

     
    }
    public void Restart()
    {
        _playerBehaviur.IsPlayerAlive = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
    public void Quit()
    {
        Application.Quit();
       
    }
}
