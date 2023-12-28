using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TooltipTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

    private static LTDescr delay;
    private static LTDescr delay2;

<<<<<<< HEAD
=======
    private GameObject TooltipCanvas;

>>>>>>> 495c2f7dbddfcaac2df47d2561cb144ccb0edb3d
    private bool objectRaycast;
    public static bool freezeTooltip;

    public string header; //Title

    [Multiline()]
    public string content; // Game info
    
    [Multiline()]
    public string information; // Real Life additional Info

    public string Link1;

    public string Link2;

    public string Link3;


    private void Awake() {
        freezeTooltip = false;
        TooltipCanvas = GameObject.Find("Tooltip-Canvas");
        Debug.Log(TooltipCanvas+", Tooltip Canvas");
    }

    public void OnPointerEnter(PointerEventData eventData) {
        objectRaycast = true;
        //Delay with LeanTween Plugin
        delay = LeanTween.delayedCall(0.5f, () => {
            TooltipSystem.Show(information, content, header);
        });
        delay2 = LeanTween.delayedCall(1f, () => {
            freezeTooltip = true;
        });
    }

    //Stop Tooltip when Mouse leaves Trigger
    public void OnPointerExit(PointerEventData eventData) {
        objectRaycast = false;
        CheckRaycast();
    }

    public void CheckRaycast() {
        if(objectRaycast == false && TooltipSystem.tooltipRaycast == false) {
    //	    LeanTween.cancel(delay.uniqueId);
            TooltipSystem.Hide();
            freezeTooltip = false;
        }
    }
}
