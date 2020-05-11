using System;
using UnityEngine;
using UnityEngine.Video;

public class VidepPlayerScript : MonoBehaviour
{

    private VideoPlayer vp;

    private string crewVid1 = "https://dl.dropbox.com/s/68addszz2wrf1w7/F_TheCrew_P1_small.mp4?dl=1";
    private string crewVid2 = "https://dl.dropbox.com/s/tnoz3mtklem7137/F_TheCrew_P2_small.mp4?dl=1";

    private string missionVid1 = "https://dl.dropbox.com/s/ctvciybnior9bh3/F_TheMission_P1_small.mp4?dl=1";
    private string missionVid2 = "https://dl.dropbox.com/s/h8i8ly3wg1b65yn/F_TheMission_P2_small.mp4?dl=1";
    private string missionVid3 = "https://dl.dropbox.com/s/784qlv0u3ddrc22/F_TheMission_P3_small.mp4?dl=1";


    private int scrollProgress = 0;

    //Home screen = 0
    //The Crew = 1
    // 
    private int currentlyActivePage = 0;

    // Start is called before the first frame update
    void Start()
    {
        vp = gameObject.GetComponent<VideoPlayer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ScrollDown();
        }

        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ScrollUp();
        }
    }

    public void TheCrewPressed()
    {
        vp.url = crewVid1;
        ResetPageVariables();
        currentlyActivePage = 1;
    }

    public void TheMissionPressed()
    {
        vp.url = crewVid1;
        ResetPageVariables();
        currentlyActivePage = 2;
    }

    public void TheCrewScroll()
    {
        if(scrollProgress == 0)
        {
           vp.url = crewVid1;
        }
        else if(scrollProgress == 1)
        {
            vp.url = crewVid2;
        }
        else if(scrollProgress == 2)
        {
            scrollProgress--;
        }
        else if(scrollProgress == -1)
        {
            scrollProgress++;
        }
    }

    private void TheMissionScroll()
    {
        if (scrollProgress == 0)
        {
            vp.url = missionVid1;
        }
        else if (scrollProgress == 1)
        {
            vp.url = missionVid2;
        }
        else if (scrollProgress == 2)
        {
            vp.url = missionVid3;
        }
        else if (scrollProgress == 3)
        {
            scrollProgress--;
        }
        else if(scrollProgress == -1)
        {
            scrollProgress++;
        }
    }

    public void ScrollDown()
    {
        scrollProgress++;


        if(currentlyActivePage == 1)
        {
            TheCrewScroll();
        }
        else if(currentlyActivePage == 2)
        {
            TheMissionScroll();
        }
    }


    public void ScrollUp()
    {
        scrollProgress--;


        if (currentlyActivePage == 1)
        {
            TheCrewScroll();
        }
        else if (currentlyActivePage == 2)
        {
            TheMissionScroll();
        }


    }


    private void ResetPageVariables()
    {
        scrollProgress = 0;
    }
}
