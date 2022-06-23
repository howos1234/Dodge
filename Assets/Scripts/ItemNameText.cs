using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemNameText : MonoBehaviour
{
    public GameObject targetItem;
    public Camera mainCam;
    public Camera interaceCamera;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(targetItem == null)
        {
            Destroy(gameObject);
            return;
        }
        
        // 1. 아이템의 월드 좌표 가져오기
        var p =targetItem.transform.position;

        // 2. main camera를 이용하여 1을 스크린 좌표로 변환한다.
        var screenpoint = mainCam.WorldToScreenPoint(p);
        Vector3 worldPoint;
        // 3. 스크린 좌표를 ui좌표로 변환하기.
        var parentRt = transform.parent.GetComponent<RectTransform>();
        var valid = RectTransformUtility.ScreenPointToWorldPointInRectangle(parentRt,screenpoint,interaceCamera,out worldPoint);

        if(valid)
        {
            transform.position = worldPoint;
        }
    }
}