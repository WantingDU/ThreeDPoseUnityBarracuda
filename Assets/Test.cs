using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Test : MonoBehaviour
{
    
    void Awake()
    {
        if (StaticVariables.VideoPath!=null)
        {
            print(StaticVariables.VideoPath);
            GameObject.Find("Video Player").GetComponent<VideoPlayer>().source = VideoSource.Url;
            GameObject.Find("Video Player").GetComponent<VideoPlayer>().url = StaticVariables.VideoPath;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
