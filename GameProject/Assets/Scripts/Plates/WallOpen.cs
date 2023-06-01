using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Plates
{
    public class WallOpen : MonoBehaviour
    {
        
        private bool _WallOpened;
        [SerializeField] private Animator _animator;

        public void OpenWall()
        {
            _animator.SetBool("WallOpened", true);
            _WallOpened = !_WallOpened;

        }
    }

}
