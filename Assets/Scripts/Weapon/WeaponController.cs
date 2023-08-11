using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponController : MonoBehaviour
{
    protected GameObject _player = null;
    public Define.Weapons weaponType;

    PlayerStat _playerStat;

    public int _damage = 1;
    public float _speed = 1;
    public int _level = 1;
    public float _force = 1;
    public int _penetrate = 1;
    public int _countPerCreate = 1;
    public float _cooldown = 1;


    public abstract int _weaponType { get; }

    private void Start()
    {
        _player = GameManager.Instance.playerObject;
        _playerStat = GameManager.Instance.player.GetComponent<PlayerStat>();
    }

    protected virtual void WeaponLevelUp()
    {
        if (_level > 5)
            _level = 5;

        //_damage = (int)(_weaponStat[_level].damage * ((float)(100 + _playerStat.Damage) / 100f));
        //_movSpeed = _weaponStat[_level].movSpeed;
        //_force = _weaponStat[_level].force;
        //_cooldown = _weaponStat[_level].cooldown * (100f / (100f + _playerStat.Cooldown));
        //_size = _weaponStat[_level].size;
        //_penetrate = _weaponStat[_level].penetrate;
        //_countPerCreate = _weaponStat[_level].countPerCreate + _playerStat.Amount;
    }


}
