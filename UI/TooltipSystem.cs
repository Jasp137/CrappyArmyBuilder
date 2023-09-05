using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class TooltipSystem : MonoBehaviour {
    
    private static TooltipSystem current;

    public static bool tooltipRaycast;

    public Tooltip tooltip;

    public void Awake() {
        current = this;
    }
/*
    public void InstantiateTooltip(){
        Instantiate(tooltip);
        Debug.Log("Initiated Tooltip");
    }

    public void DestroyTooltip(){
        Destroy(tooltip);
    }
*/
    public static void Show(string information,string content, string header = "") {
        Instantiate(current.tooltip);
        current.tooltip.SetText(information, content, header);
    }

    public static void Hide() {
        DestroyImmediate(current.tooltip, true);
    }

    public void OnPointerEnter(PointerEventData eventData) {
        tooltipRaycast = true;
    }
    public void OnPointerExit(PointerEventData eventData) {
        tooltipRaycast = false;
    }
}
