using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabGroup : MonoBehaviour {

    public List<TabButton> tabButtons;
    public Color tabIdleBack;      //Sprite or Colour
    public Color tabIdleText;
    public Color tabHoverBack;     //Sprite or Colour
    public Color tabHoverText;
    public Color tabActiveBack;    //Sprite or Colour
    public Color tabActiveText;
    public TabButton selectedTab;
    public List<GameObject> objectsToSwap;

    public void Subsrcribe(TabButton button) {
        if(tabButtons == null) {
            tabButtons = new List<TabButton>();
        }
        tabButtons.Add(button);
    }

    public void OnTabEnter(TabButton button) {
        ResetTabs();
        if(selectedTab == null || button != selectedTab) {
            button.background.color = tabHoverBack;
            button.GetComponentInChildren<Text>().color = tabHoverText;
            //button.background.getChild[0].color = tabHoverText;
        }
    }

    public void OnTabExit(TabButton button) {
        ResetTabs();
    }

    public void OnTabSelected(TabButton button) {
        selectedTab = button;
        ResetTabs();
        //button.background.sprite = tabActive;
        button.background.color = tabActiveBack;
        button.GetComponentInChildren<Text>().color = tabActiveText;
        int index = button.transform.GetSiblingIndex();
        for(int i=0; i<objectsToSwap.Count; i++) {
            if (i==index) {
                objectsToSwap[i].SetActive(true);
            }
            else {
                objectsToSwap[i].SetActive(false);
            }
        }
    }

    public void ResetTabs() {
        foreach(TabButton button in tabButtons) {
            if(selectedTab != null && button == selectedTab) {
                continue;
                }
            //button.background.sprite = tabIdle;
            button.background.color = tabIdleBack;
            button.GetComponentInChildren<Text>().color = tabIdleText;

        }
    }
}
