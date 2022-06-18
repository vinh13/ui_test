using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingController : MonoBehaviour
{
    public Sprite OffSpriteSound;
    public Sprite OnSpriteSound;
    public Sprite OffSpriteVibrate;
    public Sprite OnSpriteVibrate;
    public Button btn_sound;
    public Button btn_vibrate;
 
    void Start() {
          btn_sound.image.sprite = OnSpriteSound;
          btn_vibrate.image.sprite = OnSpriteVibrate;
    }

    public void ChangeImageSound(){
        if (btn_sound.image.sprite == OnSpriteSound)
            btn_sound.image.sprite = OffSpriteSound;
        else {
            btn_sound.image.sprite = OnSpriteSound;
        }
    }

    public void changeImageVibrate() {
         if (btn_vibrate.image.sprite == OnSpriteVibrate)
            btn_vibrate.image.sprite = OffSpriteVibrate;
        else {
            btn_vibrate.image.sprite = OnSpriteVibrate;
        }
    }
}
