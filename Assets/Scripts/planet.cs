using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject planet1;

    public Transform pivot;


    void Start()
    {
        var planet2 = Instantiate(planet1,pivot);
        var x = Random.Range(10,200);
        var y = Random.Range(5.0f,20);
        planet2.transform.localPosition = new Vector3(0,0,x);
        planet2.transform.localScale = new Vector3(y,y,y);

    }

    // Update is called once per frame
    void Update()
    {
        planet1.transform.Rotate(0,5,0);    
    }
}
