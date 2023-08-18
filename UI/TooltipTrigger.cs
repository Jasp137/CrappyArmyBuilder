using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TooltipTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

    private static LTDescr delay;
    
    public string header;

    [Multiline()]
    public string content; // Game info
    
    [Multiline()]
    public string information; // Real Life additional Info

    public void OnPointerEnter(PointerEventData eventData) {
        
        //Delay with LeanTween Plugin
        delay = LeanTween.delayedCall(0.7f, () => {
            TooltipSystem.Show(information, content, header);
        });
    }

    //Stop Tooltip when Mouse leaves Trigger
    public void OnPointerExit(PointerEventData eventData) {
        LeanTween.cancel(delay.uniqueId);
        TooltipSystem.Hide();
    }
}
