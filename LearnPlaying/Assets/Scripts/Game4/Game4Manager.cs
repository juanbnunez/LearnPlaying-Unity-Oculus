using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game4Manager : MonoBehaviour
{
    private int enterCount = 0;
    private int exitCount = 0;

    /// <summary>
    /// Activate zone methods
    /// </summary>
    public void Activate()
    {
        enterCount++;
        Debug.Log($"Zone 4 - Entries: {enterCount}");
    }

    /// <summary>
    /// Deactivate zone methods 
    /// </summary>
    public void Deactivate()
    {
        exitCount++;
        Debug.Log($"Zone 4 - Exits: {exitCount}");
    }
}