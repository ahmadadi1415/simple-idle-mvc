using Agate.MVC.Base;
using UnityEngine;

namespace SimpleIdle.Gameplay.CharacterHolder
{
    public class CharacterHolderView : BaseView {
        [SerializeField] private Transform _itemContainer;
        [SerializeField] private GameObject _prefab;

        public GameObject CreateItemObject(string name)
        {
            GameObject itemObject = GameObject.Instantiate(_prefab, _itemContainer);
            itemObject.name = name;
            itemObject.SetActive(true);
            return itemObject;
        }
    }
}