using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeController : MonoBehaviour
{
    public GameObject ui_shop;
    public GameObject ui_setting;
    public GameObject remove_ads;
    public bool isClick = false;
    public Animator settingAnim;
    private Vector3 movement;

    private void Start() {
        isClick = false;
        settingAnim.SetTrigger(isClick ? "isClick" : "");
    }
 
    public void playGame() {
        SceneManager.LoadScene("GamePlay");
    }

    public void btnSettingClick() {
        isClick = true;
        settingAnim.SetTrigger(isClick ? "isClick" : "");
    }

    public void openShop() {
        ui_shop.SetActive(true);
    }

    public void closeShop() {
        ui_shop.SetActive(false);
    }

    public void enableSound() {
            
    }

    public void disableSound() {
        
    }

    public void enableMusic() {
        
    }

    public void disableMusic() {
        
    }

}//class
