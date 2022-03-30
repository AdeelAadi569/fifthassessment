using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowbalcol : MonoBehaviour
{
    private GameManager gamemangr;
    void Start(){
        gamemangr=GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    
 public void OnCollisionEnter(Collision col){
     if(col.gameObject.tag=="yellow"){
         Destroy(gameObject);
         gamemangr.Score();
         Destroy(col.gameObject);

     }
 }
}