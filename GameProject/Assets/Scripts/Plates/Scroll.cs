using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Control;

public class Scroll : MonoBehaviour, IRaycastable
{
    public bool HandleRaycast(PlayerController callingController)
    {
        return true;
    }
    
    public GameObject uiPanel; 

    private bool isUIOpen = false;

    private void OnMouseDown()
    {
        if (!isUIOpen)
        {
            uiPanel.SetActive(true); 
            isUIOpen = true;
        }
        else
        {
            uiPanel.SetActive(false); 
            isUIOpen = false;
        }
    }

    // Добавляем заглушку для метода GetCursorType()
    public CursorType GetCursorType()
    {
        return CursorType.Dialogue;
    }
}
