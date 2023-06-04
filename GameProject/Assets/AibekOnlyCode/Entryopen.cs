using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entryopen : MonoBehaviour
{
    private bool _entry;
    [SerializeField] private Animator _animator;

    public void Open()
    {
        _animator.SetBool("entry", true);
    }

}
