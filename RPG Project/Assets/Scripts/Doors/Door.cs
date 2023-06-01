using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Doors
{
    public class Door : MonoBehaviour
    {
        private bool _isOpened;
        [SerializeField] private Animator _animator;

    

        public void Open()
        {

            _animator.SetBool("isOpened", true);
            _isOpened = !_isOpened;
   
        }
    }

}
