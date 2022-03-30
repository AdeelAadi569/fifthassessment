using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bluebalcol : MonoBehaviour
{
     private GameManager gamemangr;
    // Start is called before the first frame update
    void Start()
    {
        gamemangr=GameObject.Find("GameManager").GetComponent<GameManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision col){
        if(col.transform.tag=="blue"){
            Destroy(gameObject);
             gamemangr.Score();
            Destroy(col.gameObject);
        }
    }
}
