
using UnityEngine;

public class ClockPivot2 : MonoBehaviour
{
    public GameObject earthPivot;
    public float speed;
    public int flag;
    

    
    void Update()
    {
         var x = earthPivot.transform.localPosition.x;
       
        
        flag = 1;
        
        if(flag == 1)
        {earthPivot.transform.Rotate(0,speed*Time.deltaTime,0);
        flag = 0;
        Debug.Log(flag);
        }

        if(flag == 0)
        {earthPivot.transform.Rotate(0,0.001f*Time.deltaTime,0);
        Debug.Log(flag);
        flag = 1;
        }
 
 
       

        
}
}
