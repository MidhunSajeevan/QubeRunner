using UnityEngine;
using Photon.Pun;
public class Camerabehaviour : MonoBehaviourPunCallbacks
{
     public Transform player;
      public Vector3 offset;
    private void Start()
    {
        
        if(!photonView.IsMine)
        {
            gameObject.SetActive(false);
        }
    }
    void Update()
    {
        transform.position=player.position + offset;
    
    }
}
