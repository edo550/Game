using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopMenu : MonoBehaviour
{
    /*
    public static ShopMenu MC;
    public GameObject[] buttonLocks;
    public Button[] unlockedButtons;


    void Start()
    {
        SetUpStore();
    }

    private void OnEnable()
    {
        MC = this;
    }

    public void SetUpStore()
    {
        for(int i = 0; i < PersistentData.PD.allSkins.Length; i++)
        {
            buttonLocks[i].SetActive(!PersistentData.PD.allSkins[i]);
            unlockedButtons[i].interactable = PersistentData.PD.allSkins[i];
        }
    }

    public void UnlockSkin(int index)
    {
        PersistentData.PD.allSkins[index] = true;
        PlayFabControllor.PFC.SetUserData(PersistentData.PD.SkinsDataToString());
        SetUpStore();
    }
    public void SetMySkin(int wichSkin)
    {
        PersistentData.PD.mySkin = whichSkin;
    }
    */
    
    Player p = new Player();
    PlayerCombat pc = new PlayerCombat();
   
    void Life()
    {
        p.LifeUp();
        Debug.Log("vita +10");
    }
    public void Kick()
    {
        pc.KickUp();
        Debug.Log("Kick +5");
    }
    public void Jump()
    {
        Debug.Log("Jump +5");
    }
    public void Night()
    {

    }
 
}
