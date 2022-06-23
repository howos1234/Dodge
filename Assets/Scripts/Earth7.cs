
using UnityEngine;

public class Earth : MonoBehaviour
{
    public GameObject earth;

    void Start()
    {
        
    }

   
    void Update()
    {
        earth.transform.Rotate(0,5,0);
    }
}
