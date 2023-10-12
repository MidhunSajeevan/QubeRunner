using UnityEngine;

public class colliderbehaviour : MonoBehaviour
{
    public GameObject gameOverScreen;
    public playerBehaviour movement;
    void OnCollisionEnter(Collision colinfo)
{
if(colinfo.collider.tag == "obstacle")
{
            gameOverScreen.SetActive(true);
            movement.enabled=false;
              FindObjectOfType<GameManager>().EndGame();
              
}
}
}
