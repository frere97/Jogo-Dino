using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsSpawner : MonoBehaviour
{
    public GameObject obstaculo;
    //tempo que o timer precisa atingir
    float TempoMaxTimer;
    float Timer;
    public Vector2 Randomrange = new Vector2(2f, 6f);
    // Start is called before the first frame update
    void Start()
    {
        TempoMaxTimer = Random.Range(Randomrange.x, Randomrange.y);
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer > TempoMaxTimer)
        {

            Instantiate(obstaculo, this.transform.position, Quaternion.identity);
            Timer = 0;
            TempoMaxTimer = Random.Range(Randomrange.x, Randomrange.y);
        }
    }

   
}
