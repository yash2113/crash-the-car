using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayere : MonoBehaviour
{
    public GameObject Player;
    public GameObject Follow;
    public float speed;
   
   

    // Start is called before the first frame update
   private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Follow = Player.transform.Find("camera constraint").gameObject;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        follow();

    }   
        
       private void follow()
    {
        gameObject.transform.position = Vector3.Lerp(transform.position, Follow.transform.position, Time.deltaTime * speed);
        gameObject.transform.LookAt(Player.gameObject.transform.position);  
    }
        
    
   
}
