using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockPivot3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject clockPivot;
    public float speed;
    float sumSecond=0;
    
    void Update()
    {
        sumSecond += Time.deltaTime;
        
        if(sumSecond > 1 && sumSecond < 2)
        {
           clockPivot.transform.Rotate(0,6,0);
           sumSecond = 0;
        }

        else if(sumSecond > 2)
        {
            var del = (int)sumSecond;
            for(int i=0;i<del;i++)
            {
                clockPivot.transform.Rotate(0,6,0);
            }
            sumSecond = 0;
        }
    }
}
