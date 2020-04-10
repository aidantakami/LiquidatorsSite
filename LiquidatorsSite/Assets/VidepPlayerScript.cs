using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VidepPlayerScript : MonoBehaviour
{

    private VideoPlayer vp;

    private string missionVid1 = "https://dl.dropboxusercontent.com/s/m670bb88tjsiww7/TheMission_P1_v1.mp4?dl=1";
    private string missionVid2 = "https://dl.dropboxusercontent.com/s/m670bb88tjsiww7/TheMission_P1_v1.mp4?dl=1";
    private string missionVid3 = "https://dl.dropbox.com/s/d6vkzzzpibyyej3/TheMission_P3_v1.mp4?dl=1";


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
           vp.url = missionVid2;
            missionTracker++;
        }
        else if(missionTracker == 1)
        {
            //darken button
            vp.url = missionVid3;
            missionTracker++;

        }
    }
}
