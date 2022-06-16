using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject item;
    public Transform itemposition;

    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<100;i++)
        {
            var planet = Instantiate(item,itemposition);
            var x = Random.Range(-50.0f,50);
            var z = Random.Range(-50.0f,50);
            planet.transform.localPosition = new Vector3(x,0,z);
        }
    }

    // Update is called once per frame
    
}
