using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public List<GameObject> hearts;
    public static int hp = 3;
    //public ChangeScene changeScene;
    //public AudioClip pigHurt;
    //public AudioClip gameOver;
    
    // Start is called before the first frame update
    void Start()
    {
        hp = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hurt()
    {
        hp--;
        hearts[hp].SetActive(false);
        if (hp == 0)
        {
            Invoke("GoDeathScene", 1);
        }
    } 

    public void GoDeathScene()
    {
        //changeScene.LoadDeath();
    }

}
