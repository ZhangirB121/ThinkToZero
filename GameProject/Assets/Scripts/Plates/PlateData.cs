using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Plates
{
    public class PlateData : MonoBehaviour
    {
        [SerializeField] private int digit;
        [SerializeField] private Animator _animator;

        public int GetDigit()
        {
            return digit;
        }

        public void PressPlate()
        {
        _animator.SetBool("IsPressed", true);
        }

        public void DisablePlate()
        {
         _animator.SetBool("IsPressed", false);
        }
    }
}
