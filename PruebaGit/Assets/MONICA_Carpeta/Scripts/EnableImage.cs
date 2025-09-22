using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnableImage : MonoBehaviour
{
    public Image imagen;
    public Toggle toggleENABLE;

    public void EnableDisable()
    {
        if (toggleENABLE.isOn)
        {
            imagen.enabled = true;
        }
        else
        {
            imagen.enabled = false;
        }
    }
}
