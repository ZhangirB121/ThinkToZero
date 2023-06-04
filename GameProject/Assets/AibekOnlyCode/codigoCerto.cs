using UnityEngine;

public class codigoCerto : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public void Open()
    {
        _animator.SetBool("entry", true);
    }

    void LigarLuz()
    {
        Debug.Log("testing");
        Open();
        Debug.Log("Success");
    }

    void Anoitecer()
    {
        transform.rotation = Quaternion.Euler(new Vector3(180, 0, 0));
    }
}

