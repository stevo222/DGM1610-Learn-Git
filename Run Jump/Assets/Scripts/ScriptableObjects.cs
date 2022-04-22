using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableObjects : MonoBehaviour
{
    public int value;
    // Start is called before the first frame update
   public void UpdateValue(int number)
    {
        value += number;
    }

    public void ReplaceValue(int number)
    {
        value = number;
    }

   // public void DisplayImage(Image img)
    //{
       // img.fillAmount = value;
    //}

   // public void DisplayNumber(Text txt)
    //{
      //  txt.text = value.ToString();
   // }
}
