using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Button pause,resume,restart;
    public Text gameover,score;
    public static int counter=0;
    public GameObject[] prefabballs;
    public  GameObject pos;
    
    public GameObject[] prefab;
    int i; 
    public GameObject wall;
   // GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        score.text="Score :"+counter;
        Spawn(5);
        //StartCoroutine("MoveWall");
        InvokeRepeating("MoveWall",3,4);
    }

    // Update is called once per frame
    void Update()
    {
     //    go=GameObject.FindGameObjectWithTag("red");
        
    }
    public void Pause(){
        pause.gameObject.SetActive(false);
        resume.gameObject.SetActive(true);
        restart.gameObject.SetActive(true);
        Time.timeScale=0;
    }
    public void Resume(){
        pause.gameObject.SetActive(true);
        restart.gameObject.SetActive(false);
        resume.gameObject.SetActive(false);
        Time.timeScale=1;
    }
    public void Restart(){
        SceneManager.LoadScene(0);
    }
    public void GameOver(){
        gameover.text="GameOver";
    }
    public void Spawn(int sp){
        Debug.Log("SPawn");
        i=Random.Range(0,prefabballs.Length);
        for(int j=0;j<=sp;j+=1){
        Instantiate(prefabballs[i],pos.transform.position,prefabballs[i].transform.rotation);
        }
    }
    public void MoveWall(){
        //yield return new WaitForSeconds(2);
        wall.transform.position=new Vector3(wall.transform.position.x,wall.transform.position.y,wall.transform.position.z-2);
       //  go.transform.position=new Vector3(go.transform.position.x,go.transform.position.y,go.transform.position.z-2);
    }
    public void Score(){
        counter+=5;
        score.text="Score :"+counter;
    }
}
