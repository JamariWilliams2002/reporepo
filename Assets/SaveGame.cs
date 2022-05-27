using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class SaveGame : MonoBehaviour
{
    public void Save()
    {
        PlayerPrefs.Save();
    }
}
