using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// 지정된 조이스틱에서 입력 조작 방향값을 이용해 움직인다.
public class Player : MonoBehaviour
{
    public Joystick joystick;
    public TMP_Text score;
    int getcount = 0;

   
    void Update()
    {
        score.text=($"{getcount}");
        Debug.Log(getcount);
        var dx = joystick.NormalizedDirection.x;
        var dz = joystick.NormalizedDirection.y;
        var pos = transform.localPosition;
        pos.x +=dx * 5*Time.deltaTime;
        pos.z +=dz * 5*Time.deltaTime;
        transform.localPosition = pos;
    }
    
    //누군가와 충돌했다 충돌한 오브젝트의 collider 컴포넌트가 other 인자로 넘어온다.
    void OnTriggerEnter(Collider other)
    {
        Debug.Log($"충돌시작 : {other.name}");
        Destroy(other.gameObject);
        getcount+=1;
        
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log($"충돌끝 : {other.name}");
    }
}
