using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class BackgroundManagerScript : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _livingRoomBG, _KitchenBG, _garageBG, _frontYardBG;
    [SerializeField] private  List<Sprite> _livingRoomSprites;
    [SerializeField] private  List<Sprite> _kitchenSprites;
    [SerializeField] private  List<Sprite> _garageSprites;
    [SerializeField] private  List<Sprite> _frontYardSprites;

    [SerializeField] private FrontYardUpgradeHouseManager frontYardUpgradeHouseManager;

    private byte _houseLevel;
    private void Start()
    {
        _houseLevel = frontYardUpgradeHouseManager.GetHouseLevel();

    }
    public void DisplayHouseLevel()
    {
        _houseLevel = frontYardUpgradeHouseManager.GetHouseLevel();
        if(_houseLevel > 3) return;
        _livingRoomBG.sprite = _livingRoomSprites[_houseLevel];
        _KitchenBG.sprite = _kitchenSprites[_houseLevel];
        _garageBG.sprite = _garageSprites[_houseLevel];
        _frontYardBG.sprite = _frontYardSprites[_houseLevel];
    }

}
