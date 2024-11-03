using System;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    public string nameZone;
    public string tagFilter = "Player";
    public float detectionRadius = 5f; // Radio de detección
    private bool isInZone = false; // Variable para saber si el objeto ya está en la zona

    [SerializeField] UnityEvent OnEnterEvent;
    [SerializeField] UnityEvent OnExitEvent;

    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag(tagFilter);
        if (player != null)
        {
            float distance = Vector3.Distance(transform.position, player.transform.position);

            // Si está dentro del radio y no estaba previamente en la zona
            if (distance <= detectionRadius && !isInZone)
            {
                isInZone = true;
                Debug.Log($"{player.name} ha entrado en {nameZone}");
                OnEnterEvent.Invoke();
            }
            // Si está fuera del radio y estaba previamente en la zona
            else if (distance > detectionRadius && isInZone)
            {
                isInZone = false;
                Debug.Log($"{player.name} ha salido de {nameZone}");
                OnExitEvent.Invoke();
            }
        }
    }
}
