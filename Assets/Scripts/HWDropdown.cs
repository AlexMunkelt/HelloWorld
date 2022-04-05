using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HWDropdown : MonoBehaviour
{
    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDropdown()
    {
        switch (GetComponent<TMP_Dropdown>().value)
        {
            case 0:
                text.text = "Hallo Felix ;)";
                break;
            case 1:
                text.text = "Hallo Jacky ;)";
                break;

            default:
                break;
        }
    }
}
