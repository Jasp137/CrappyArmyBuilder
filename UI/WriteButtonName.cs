using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]
public class WriteButtonName : MonoBehaviour
{
    public Text TabText;
    //private Text TabText = gameObject.GetComponent<Text>();
    //Called when Script attached and not in Playmode
    private void Update() {
        if (Application.isEditor) {
        TabText = gameObject.GetComponent<Text>();
        TabText.text = gameObject.name;
        }
    }
    // Start is called before the first frame update
}
