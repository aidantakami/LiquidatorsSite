using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VidepPlayerScript : MonoBehaviour
{

    [SerializeField] public Text getInvolvedText;
    [SerializeField] public Text scrollText;

    private VideoPlayer vp;

    private string briefingVid1 = "https://dl.dropbox.com/s/yjl0iin8yxqmuj8/F_Briefing_P1_small.mp4?dl=1";

    private string crewVid1 = "https://dl.dropbox.com/s/68addszz2wrf1w7/F_TheCrew_P1_small.mp4?dl=1";
    private string crewVid2 = "https://dl.dropbox.com/s/tnoz3mtklem7137/F_TheCrew_P2_small.mp4?dl=1";

    private string intelVid1 = "https://dl.dropbox.com/s/9d7ztnoqva9s3t0/F_Intel_P1_small.mp4?dl=1";
    private string intelVid2 = "https://dl.dropbox.com/s/e0neq0yzpzrdq76/F_Intel_P2_small.mp4?dl=1";
    private string intelVid3 = "https://dl.dropbox.com/s/0ndyseygj1djdmo/F_Intel_P3_small_borderless.mp4?dl=1";

    private string missionVid1 = "https://dl.dropbox.com/s/ctvciybnior9bh3/F_TheMission_P1_small.mp4?dl=1";
    private string missionVid2 = "https://dl.dropbox.com/s/h8i8ly3wg1b65yn/F_TheMission_P2_small.mp4?dl=1";
    private string missionVid3 = "https://dl.dropbox.com/s/784qlv0u3ddrc22/F_TheMission_P3_small.mp4?dl=1";

    private string aboutVid1 = "https://dl.dropbox.com/s/5a0rip40og6p3fq/F_About_P1_small.mp4?dl=1";



    private int scrollProgress = 0;

    //Home screen = 0
    //The Crew = 1
    // 
    private int currentlyActivePage = 0;

    // Start is called before the first frame update
    void Start()
    {
        vp = gameObject.GetComponent<VideoPlayer>();
        BriefingPressed();
        vp.SetDirectAudioMute(ushort.MinValue, false);
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

    public void BriefingPressed()
    {
        vp.url = briefingVid1;
        ResetPageVariables();
        currentlyActivePage = 1;
        vp.SetDirectAudioMute(ushort.MinValue, false);
    }


    public void TheMissionPressed()
    {
        vp.url = crewVid1;
        ResetPageVariables();
        currentlyActivePage = 2;
        vp.SetDirectAudioMute(ushort.MinValue, true);
        scrollText.gameObject.SetActive(true);
    }

    public void IntelPressed()
    {
        vp.url = intelVid1;
        ResetPageVariables();
        currentlyActivePage = 3;
        vp.SetDirectAudioMute(ushort.MinValue, true);
        scrollText.gameObject.SetActive(true);

    }

    public void TheCrewPressed()
    {
        vp.url = crewVid1;
        ResetPageVariables();
        currentlyActivePage = 4;
        vp.SetDirectAudioMute(ushort.MinValue, true);
        scrollText.gameObject.SetActive(true);

    }

    public void GetInvolvedPressed()
    {
        ResetPageVariables();
        getInvolvedText.gameObject.SetActive(true);
        vp.Stop();
        currentlyActivePage = 5;
        vp.SetDirectAudioMute(ushort.MinValue, true);

    }

    public void AboutPressed()
    {
        vp.url = aboutVid1;
        ResetPageVariables();
        currentlyActivePage = 6;
        vp.SetDirectAudioMute(ushort.MinValue, true);

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


    public void IntelScroll()
    {
        if(scrollProgress == 0)
        {
            vp.url = intelVid1;
        }
        else if(scrollProgress == 1)
        {
            vp.url = intelVid2;
        }
        else if(scrollProgress == 2)
        {
            vp.url = intelVid3;
        }
        else if (scrollProgress == 3)
        {
            scrollProgress--;
        }
        else if (scrollProgress == -1)
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


    public void TheBriefingScroll()
    {

    }

    public void AboutScroll()
    {

    }

    public void ScrollDown()
    {
        scrollProgress++;


        if(currentlyActivePage == 1)
        {
            TheBriefingScroll();
        }
        else if(currentlyActivePage == 2)
        {
            TheMissionScroll();
        }
        else if(currentlyActivePage == 3)
        {
            IntelScroll();
        }
        else if(currentlyActivePage == 4)
        {
            TheCrewScroll();
        }
        else if(currentlyActivePage == 5)
        {
            //Get Involved Scroll
        }
        else if (currentlyActivePage == 6)
        {
            AboutScroll();
        }
    }


    public void ScrollUp()
    {
        scrollProgress--;


        if (currentlyActivePage == 1)
        {
            TheBriefingScroll();
        }
        else if (currentlyActivePage == 2)
        {
            TheMissionScroll();
        }
        else if (currentlyActivePage == 3)
        {
            IntelScroll();
        }
        else if (currentlyActivePage == 4)
        {
            TheCrewScroll();
        }
        else if (currentlyActivePage == 5)
        {
            //Get Involved Scroll
        }
        else if (currentlyActivePage == 6)
        {
            AboutScroll();
        }


    }


    private void ResetPageVariables()
    {
        scrollProgress = 0;
        getInvolvedText.gameObject.SetActive(false);
        scrollText.gameObject.SetActive(false);
    }
}
