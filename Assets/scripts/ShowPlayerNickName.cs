using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
public class ShowPlayerNickName : MonoBehaviourPunCallbacks
{
    public Text nickName;
    // Start is called before the first frame update
    void Start()
    {
        nickName.text = photonView.Owner.NickName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
