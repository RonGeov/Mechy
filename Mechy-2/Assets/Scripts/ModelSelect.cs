using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class ModelSelect : MonoBehaviour
{
    public TextMeshProUGUI selection;
    // Start is called before the first frame update
    public void DropDown(int val)
    {
        if(val == 1)
        {
            SceneManager.LoadScene("scan");
        }
        if(val == 2)
        {
            SceneManager.LoadScene("Ritz");
        }
    }

   
}
