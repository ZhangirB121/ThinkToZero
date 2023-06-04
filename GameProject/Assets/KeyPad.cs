using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPad : MonoBehaviour
{
    [SerializeField] private Text Ans;
    [SerializeField] private Animator Door = null;

    private string Answer = "1357";
    
    public void Number(int number)
    {
        Ans.text += number.ToString();
    }

    public void Delete()
    {
        Ans.text = null;
    }

    public void Execute(){
        if(Ans.text == Answer)
        {
            Ans.text = "Correct";
            Door.Play("New Animation", 0, 0.0f);
        }
        else
        {
            Ans.text = "Invalid";
        }
    }

}