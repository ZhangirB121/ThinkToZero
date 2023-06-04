using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Control;

public class OpenKalitka : MonoBehaviour, IRaycastable
{
    public CursorType GetCursorType()
    {
         return CursorType.Doors;
    }
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
}