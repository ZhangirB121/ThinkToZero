using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Plates;

namespace RPG.Plates
{
    public class Plates : MonoBehaviour
    {
        private WallOpen wallOpen;
        [SerializeField] private bool openTrigger = false;

        private bool _IsPressed;
        [SerializeField] private Animator _animator;

        private void Start()
        {
            wallOpen = GetComponentInChildren<WallOpen>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if (openTrigger)
                {
                    wallOpen.OpenWall();
                    PressPlate();
                }
            }
        }

        private void PressPlate()
        {
        _animator.SetBool("IsPressed", true);
        _IsPressed = !_IsPressed;
        }
    }

}
