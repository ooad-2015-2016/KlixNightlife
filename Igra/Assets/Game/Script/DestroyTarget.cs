using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DestroyTarget : MonoBehaviour
{

  
     public AudioClip shotSound;
    public GameObject gameLogic;

    // Use this for initialization
    void Start()
    {
        gameLogic = GameObject.Find("GameLogic");

    }
    // Update is called once per frame
    void Update()
    {

    }
    

    void OnMouseDown ()
    {
        AudioSource.PlayClipAtPoint(shotSound, gameLogic.transform.position, 1f);
        Destroy(gameObject);
        gameLogic.GetComponent<GameLogic>().dodajScore();
    }
}
