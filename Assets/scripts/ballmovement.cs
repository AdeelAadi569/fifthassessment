using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmovement : MonoBehaviour
{
    private playercontroller plyrcontrlr;
    // Start is called before the first frame update
    void Start()
    {
        plyrcontrlr=GameObject.Find("Player").GetComponent<playercontroller>();
    }

    // Update is called once per frame
    void Update()
    {
      //  if(transform.position.x >= plyrcontrlr.spawnpos.transform.position.x){
        //    Debug.Log("xcvbnm,");
          //  plyrcontrlr.chkempty=true;

        //}
      //  transform.Translate(.up*10);
    }
}
