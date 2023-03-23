using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public TextMeshProUGUI text;
    int count = 0;

    public void ButtonClicked()
    {
        if(GetComponent<ButtonScript>() != null)
        {
            count++;
        }
        
    }

 
   
}
