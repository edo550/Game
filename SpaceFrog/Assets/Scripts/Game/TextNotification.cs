using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextNotification : MonoBehaviour
{
    
    private void Start()
    {
        NotificationManager.Instance.SetNewNotification("This is a test");
    }

    private void Update()
    {
        if(Time.time > 5f)
        {
            NotificationManager.Instance.SetNewNotification("bfjdsjafnjabsndjbnj");
            Destroy(this);
        }
    }


}
