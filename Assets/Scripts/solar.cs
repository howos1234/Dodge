using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solar : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject planet;
    public GameObject planetPrefab;
    List<GameObject> planetList = new List<GameObject>();

    public Transform pivotPrefab;
    // Start is called before the first frame update
    
    
    public void creatplanet()
    {
        //var pivot1 = Instantiate(pivotPrefab);
        var planet1 = Instantiate(planetPrefab);
        var x = Random.Range(10,30);
        planetList.Add(planet1);                                        
        
    }

    void Update()
    {
        foreach(var planet1 in planetList)
        {
            var x = Random.Range(1.0f,5);
            planet1.transform.Rotate(0,x,0);

        }
    }

    public void destroybutton()
    {
        var count = planetList.Count;

        if(count <=0){
            return;
        }
        Destroy(planetList[count-1]);
        planetList.RemoveAt(count-1);
    }
}
