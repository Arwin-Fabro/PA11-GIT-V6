using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject[] SpawnObject;
    float PositionY;
    public int randomArray; // Array
     
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {



    }

    void SpawnObjects()
    {
        PositionY = Random.Range(4, -4f);
        randomArray = Random.Range(0, SpawnObject.Length);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        GameObject  temp = Instantiate(SpawnObject[randomArray], transform.position, transform.rotation) as GameObject;
        if (temp.transform.position.x <= -10)
        {
            print("Temp");
            Destroy(temp);
        }
    }
}
