
using UnityEngine;

public class EarthPivot : MonoBehaviour
{
    public GameObject earthPivot;
    public float speed;

    
    void Update()
    {
        //earth pivot gameobject의 transform 컴포넌트를 조작하여 y축으로 회전시킨다.
        //gameobject의 참조를 가져온다.
        //가져온 참조 오브젝트, earth pivot의 transform 컴포넌트를 가져온다.
        //transform 컴포넌트의 y축 회전 값을 증가시킨다.
        
        var x = earthPivot.transform.localPosition.x;
        //x = 100;
        Debug.Log(x);

        //localposiotion 전체를 바꾸는 방법
        
        /*var p = earthPivot.transform.localPosition;
        p.x = 100;

        earthPivot.transform.localPosition = p;
        */

        // 회전은 3차원벡터 타입이 아니다. 4차원 벡터 이고, 직접조작하기 까다롭다.
        //var r = earthPivot.transform.localRotation;

        // Rotate 메소드를 이용해서 회전시키자. (단위는 도)
        earthPivot.transform.Rotate(0,speed,0);

        

    }
}
