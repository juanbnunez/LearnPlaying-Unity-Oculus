using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game3Manager : MonoBehaviour
{
    private int enterCount = 0;
    private int exitCount = 0;

    /// <summary>
    /// Activate zone methods
    /// </summary>
    public void Activate()
    {
        enterCount++;
        Debug.Log($"Zone 3 - Entries: {enterCount}");
    }

    /// <summary>
    /// Deactivate zone methods 
    /// </summary>
    public void Deactivate()
    {
        exitCount++;
        Debug.Log($"Zone 3 - Exits: {exitCount}");
    }
}