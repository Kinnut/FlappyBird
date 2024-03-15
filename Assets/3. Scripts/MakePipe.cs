using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float timeDiff;

    float timer = 3;
    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff )
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = new Vector3(5, Random.Range(-2.25f, 2.25f), 0);
            timer = 0;

            Destroy(newPipe, 7);
        }
    }
}
