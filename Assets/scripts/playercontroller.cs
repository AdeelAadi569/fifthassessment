using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    private Rigidbody playerrb;
    public GameObject player;
    public GameObject[] prefab;
    public GameObject spawnpos,movepos;
    public int counter;
    public bool chkempty;
    GameObject prefabbal;
    int i;
    // Start is called before the first frame update
    void Start()
    {
         int i=Random.Range(0,prefab.Length);
       
        chkempty=true;
    }

    // Update is called once per frame
    void Update()
    {
        counter=FindObjectsOfType<ballmovement>().Length;
        if(chkempty==true)
        {
            Spawn();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
              prefabbal.transform.position=movepos.transform.position;
              Rigidbody rbbal=prefabbal.GetComponent<Rigidbody>();
              rbbal.AddForce(transform.up*15f,ForceMode.Impulse);
              chkempty=true;
        }
        
        if(Input.GetKey(KeyCode.D)){
           transform.Rotate(Vector3.back*10);
        }
        if(Input.GetKey(KeyCode.A)){
            transform.Rotate(Vector3.forward*10);
        }
        if (transform.rotation.z>=50)
        {
            Debug.Log("rotation freez");
            transform.Rotate(transform.rotation.x,transform.rotation.y,50);
        }
         if (transform.rotation.z<=-50)
        {
            Debug.Log("rotation freez");
            transform.Rotate(transform.rotation.x,transform.rotation.y,-50);
        }
       
    }
    public void Spawn(){
         i=Random.Range(0,prefab.Length);
        prefabbal= Instantiate(prefab[i],spawnpos.transform.position,transform.rotation);
        chkempty=false;
    }
}
