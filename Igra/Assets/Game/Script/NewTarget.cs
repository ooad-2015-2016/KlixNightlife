using UnityEngine;
using System.Collections;

public class NewTarget : MonoBehaviour
{
    public GameObject[] mete;//niz meta
    private float cooldown = -0.6f;//cooldown za kreiranje mete
    public float cooldownAmount = 0.5f;
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (cooldown < 0)
        {
            createMeta();
            cooldown = cooldownAmount;
        }
        cooldown -= Time.deltaTime;
    }
    public void createMeta()
    {
        Vector3 createPosition = new Vector3(Random.Range(40, 60), Random.Range(0, 8), -14);
        Quaternion rotation = Quaternion.Euler(5, 95, 5);
        GameObject targetObjekat = (GameObject)Instantiate(mete[(int)Random.Range(0, mete.Length)], createPosition, rotation);
        
    }
}
