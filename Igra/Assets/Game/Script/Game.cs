using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;



    class Game : MonoBehaviour
{
    private float cooldown = 30;
    public float cooldownAmount = 30;
    GameObject gameLogic;

    void Start()
    {
        gameLogic = GameObject.Find("GameLogic");

    }

    void Update()
        {
        /*  Ne radi iz nekog razloga.
            GameObject[] Targets = GameObject.FindGameObjectsWithTag("Target");
            int t = Targets.Length;
            if ( t == 4)
     */
            if (cooldown < 0)
            {
            gameLogic.GetComponent<GameLogic>().displayMenu();
            }
            cooldown -= Time.deltaTime;

        }
    
}
