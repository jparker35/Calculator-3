using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UserScript : MonoBehaviour
{
   public TMP_Text txt_output;
   string start_text = "";
   float value1 = 0f;
   float value2 = 0f;
   float answer;
   string operation;

    public void num1_pressed(){
        txt_output.text = txt_output.text + "1";
    }

     public void num2_pressed(){
        txt_output.text = txt_output.text + "2";
    }

     public void num3_pressed(){
        txt_output.text = txt_output.text + "3";
    }

     public void num4_pressed(){
        txt_output.text = txt_output.text + "4";
    }

     public void num5_pressed(){
        txt_output.text = txt_output.text + "5";
    }
    
     public void num6_pressed(){
        txt_output.text = txt_output.text + "6";
    }

     public void num7_pressed(){
        txt_output.text = txt_output.text + "7";
    }

     public void num8_pressed(){
        txt_output.text = txt_output.text + "8";
    }

     public void num9_pressed(){
        txt_output.text = txt_output.text + "9";
    }

     public void num0_pressed(){
        txt_output.text = txt_output.text + "0";
    }

    public void clear_pressed(){
        txt_output.text = start_text;
        value1 = 0f;
        value2 = 0f;
    }

    public void add_pressed(){
        operation = "+";
        float.TryParse(txt_output.text, out value1);
        txt_output.text = start_text;
    }

    public void sub_pressed(){
        operation = "-";
        float.TryParse(txt_output.text, out value1);
        txt_output.text = start_text; 
    }

    public void mult_pressed(){
        operation = "x";
        float.TryParse(txt_output.text, out value1);
        txt_output.text = start_text;
    }

    public void div_pressed(){
        operation = "/";
        float.TryParse(txt_output.text, out value1);
        txt_output.text = start_text;
    }

    public void equal_pressed(){
        if (operation == "+"){
            float.TryParse(txt_output.text, out value2);
            answer = value1 + value2;
            txt_output.text = answer.ToString();
        }
        else if (operation == "-"){
            float.TryParse(txt_output.text, out value2);
            answer = value1 - value2;
            txt_output.text = answer.ToString();
        }
        else if (operation == "x"){
            float.TryParse(txt_output.text, out value2);
            answer = value1 * value2;
            txt_output.text = answer.ToString();
        }
        else if (operation == "/"){
            float.TryParse(txt_output.text, out value2);
            answer = value1 / value2;
            txt_output.text = answer.ToString();
        }
        else {
            txt_output.text = txt_output.text;
        }
    }
}
