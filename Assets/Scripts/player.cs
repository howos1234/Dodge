using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 지정된 조이스틱에서 입력 조작 방향값을 이용해 움직인다.
public class player : MonoBehaviour
{
    public Joystick joystick;

    void Update()
    {
       
        var dx = joystick.NormalizedDirection.x;
        var dz = joystick.NormalizedDirection.y;
        var pos = transform.localPosition;
        pos.x +=dx * Time.deltaTime;
        pos.z +=dz * Time.deltaTime;
        transform.localPosition = pos;
    }
    
}
