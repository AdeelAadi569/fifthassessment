using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameoverpoint : MonoBehaviour
{
    public Text gameover;
    private GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm=GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider col){
        if(col.gameObject.tag=="wall"){
            Debug.Log("ruk ja");
            gameover.text="Game Over";
            Time.timeScale=0;
        }
    }
}
