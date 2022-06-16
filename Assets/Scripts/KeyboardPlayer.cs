using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardPlayer : MonoBehaviour
{
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        var dx = Input.GetAxis("Horizontal");
        var dz = Input.GetAxis("Vertical");
        Debug.Log($"dx = {dx}, dz = {dz}");
        // printf("dx = %f, dz = %f,dx,dz)

        var p = transform.localPosition;
        p.x += dx * Time.deltaTime;
        p.z += dz * Time.deltaTime;
        transform.localPosition = p;
    }
}
