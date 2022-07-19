using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFoot : MonoBehaviour

{
    AudioSource audioSrc;

    public void PlayerFootSteps()
    {
        if (!audioSrc.isPlaying)
        {
            audioSrc.Play();
        }
        else
        {
 //           audioSrc.Stop();
        }
    }

 //   public void Stop()
 //   {
 //       audioSrc.Stop();
 //   }
}
