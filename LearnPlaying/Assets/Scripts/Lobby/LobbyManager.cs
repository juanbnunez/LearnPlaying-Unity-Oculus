using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyManager : MonoBehaviour
{
    private int enterCount = 0;
    private int exitCount = 0;

    /// <summary>
    /// Activate zone methods
    /// </summary>
    public void Activate()
    {
        enterCount++;
        Debug.Log($"Lobby Zone - Entries: {enterCount}");
    }

    /// <summary>
    /// Deactivate zone methods 
    /// </summary>
    public void Deactivate()
    {
        exitCount++;
        Debug.Log($"Lobby Zone - Exits: {exitCount}");
    }
}