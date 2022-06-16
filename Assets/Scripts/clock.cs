using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{

    public EarthPivot hourpivot;
    public EarthPivot minpivot;
    public EarthPivot secpivot;

    // Start is called before the first frame update
    void Start()
    {

        var now = System.DateTime.Now;

        var hour = now.Hour;
        var min = now.Minute;
        var sec = now.Second;

        var totalsecond = sec + min * 60 + hour * 3600;

        /*hourpivot.transform.Rotate(0,totalsecond/3600.0f*30,0);
        minpivot.transform.Rotate(0,totalsecond/60.0f*6,0);
        secpivot.transform.Rotate(0,totalsecond*6,0);*/

        secpivot.RotateBySecond(totalsecond);
        minpivot.RotateBySecond(totalsecond);
        hourpivot.RotateBySecond(totalsecond);

    }

}
