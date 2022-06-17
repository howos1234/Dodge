
using UnityEngine;

public class ClockPivot2 : MonoBehaviour
{
    public GameObject earthPivot;
    public float speed;
    //float Sumsecond=0;
   
    

    
    void Update()
    {

        /*Sumsecond += 1*Time.deltaTime;
        if(Sumsecond==1)
        {
            earthPivot.transform.Rotate(0,6,0);
            Sumsecond = 0;
        } */
        earthPivot.transform.Rotate(0,speed*Time.deltaTime,0);
       

        
 
 
       

        
}
}
