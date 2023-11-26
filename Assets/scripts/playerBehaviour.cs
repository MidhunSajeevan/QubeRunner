using Unity.VisualScripting;
using UnityEngine;
using Photon.Pun;
public class playerBehaviour : MonoBehaviourPunCallbacks
{

    public Rigidbody rb;
    public float forwardforce=2000f;
    public float sideforce=1000f;
    private float speed = 30f;
    private bool _isPlayerAlive = true;
    GameManager gameManager;
    private float horizontalInput;
    private float verticalInput;
    public bool IsPlayerAlive
    {
        get { return _isPlayerAlive; }
        set { _isPlayerAlive= value; }
    }

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void FixedUpdate()
    {
        //check if the key is pressed, it return true if it is preede else false
        if (photonView.IsMine)
        {


            if (IsPlayerAlive)
            {

                horizontalInput = SimpleInput.GetAxis("Horizontal");
                verticalInput = SimpleInput.GetAxis("Vertical");
                rb.AddForce(0, 0, speed * verticalInput);
                rb.AddForce(speed * horizontalInput, 0, 0);
                if (SimpleInput.GetKey(KeyCode.UpArrow))
                {
                    rb.AddForce(0, 0, forwardforce * Time.deltaTime);

                }
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    rb.AddForce(0, 0, -forwardforce * Time.deltaTime);

                }
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    rb.AddForce(sideforce * Time.deltaTime, 0, 0);

                }
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    rb.AddForce(-sideforce * Time.deltaTime, 0, 0);

                }
            }
            if (rb.position.y < -1f && !gameManager.IsGameComplete)     
            {
                gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
               gameManager.EndGame();
            }
        }

    }
        private void OnCollisionEnter(Collision collision)
        {

            if (collision.collider.CompareTag("obstacle"))
            {
                FindObjectOfType<GameManager>().EndGame();
                IsPlayerAlive = false;
            }
        }
}
