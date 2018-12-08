using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIButton : MonoBehaviour {

        GameObject obj;
        void Start () {
                obj = GameObject.Find ("H2O");
        }
        
        // Update is called once per frame
        void OnGUI () {
                if (GUI.Button (new Rect (100f, 100f, 80f, 15f), "Нажми")) {
                        obj.SetActive(false);
                }
        }
}
