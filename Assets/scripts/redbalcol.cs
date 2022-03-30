using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redbalcol : MonoBehaviour
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
        if(col.gameObject.tag=="red"){
            Debug.Log("collided with red ball");
            Destroy(col.gameObject);
            gamemangr.Score();
            Destroy(gameObject);
        }
        
    }
}
