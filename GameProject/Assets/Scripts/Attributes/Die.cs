using System;
using GameDevTV.Utils;
using RPG.Core;
using GameDevTV.Saving;
using RPG.Stats;
using UnityEngine;
using UnityEngine.Events;

namespace RPG.Attributes
{
    public class Die : MonoBehaviour
    {
        public UnityEvent onDie;




        bool wasDeadLastFrame = false;

        private void Start() {
            
            IsDead();
        }


        public void IsDead()
        {
            Animator animator = GetComponent<Animator>();
            animator.SetTrigger("die");
            GetComponent<ActionScheduler>().CancelCurrentAction();
        }


    }
}