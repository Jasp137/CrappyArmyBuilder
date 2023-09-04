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

    public void InstantiateTooltip(){
        Instantiate(tooltip);
        Debug.Log("Initiated Tooltip");
    }

    public void DestroyTooltip(){
        Destroy(tooltip);
    }

    public static void Show(string information,string content, string header = "") {
        current.tooltip.SetText(information, content, header);
        current.tooltip.gameObject.SetActive(true);
    }

    public static void Hide() {
        current.tooltip.gameObject.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData) {
        tooltipRaycast = true;
    }
    public void OnPointerExit(PointerEventData eventData) {
        tooltipRaycast = false;
    }
}
