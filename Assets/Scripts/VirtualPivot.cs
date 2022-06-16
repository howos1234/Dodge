
using UnityEngine;

public class VirtualPivot : MonoBehaviour
{
    public GameObject testGameObject;
    public VirtualPivotTest testGameObjectVpt;
   
    void Start()
    {
        
    }

   
    void Update()
    {
        //transform.Rotate(0,5,0);
        GetComponent<Transform>().Rotate(0,5,0);
        GetComponent<VirtualPivotTest>().value=100;

        testGameObject.GetComponent<VirtualPivotTest>().value = 200;

        testGameObjectVpt.value = 300;
    }
}
