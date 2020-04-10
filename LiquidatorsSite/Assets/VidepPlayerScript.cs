using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VidepPlayerScript : MonoBehaviour
{

    public VideoPlayer vp;

    private int missionTracker = 0;

    // Start is called before the first frame update
    void Start()
    {
        vp = gameObject.GetComponent<VideoPlayer>();
    }

    private void Update()
    {
        
    }

    public void TheMissionDown()
    {
        if(missionTracker == 0)
        {
           // vp.url =;
        }
    }
}
