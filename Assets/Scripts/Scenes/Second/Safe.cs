﻿using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

public class Safe : MonoBehaviour
{
    private BoxCollider2D _collider;
    public Items ItemId;
    public AudioSource SafeOpenAudio;

    void Start ()
    {
        _collider = GetComponent<BoxCollider2D>();
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!Equipment.Instance.HaveInInventory(Items.KEY_1))
            {
                Popup.Instance.ShowPopup(HelperEnums.GetItemTip(ItemTips.SAFE));
                return;
            }

            Equipment.Instance.AddToInventory(ItemId);
            Equipment.Instance.RemoveFromInventory(Items.KEY_1);
            SafeOpenAudio.Play();
            _collider.enabled = false;
        }
    }
}
