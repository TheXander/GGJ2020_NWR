﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelInfo : MonoBehaviour
{
    public int msgCount = 0;
    // Start is called before the first frame update
   public void addMessage()
    {
        msgCount++;

        Debug.Log(msgCount);
    }

    
}
