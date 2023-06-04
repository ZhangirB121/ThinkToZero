using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPad2 : MonoBehaviour
{
    [SerializeField] private Text Ans;
    [SerializeField] private Animator Door = null;

    private string Answer = "7311";
    
    public void Number2(int number)
    {
        Ans.text += number.ToString();
    }
    public void Delete2()
    {
        Ans.text = null;
    }

    public void Execute2(){
        if(Ans.text == Answer)
        {
            Ans.text = "Correct";
            Door.Play("New Animation2", 0, 0.0f);
        }
        else
        {
            Ans.text = "Invalid";
        }
    }

}