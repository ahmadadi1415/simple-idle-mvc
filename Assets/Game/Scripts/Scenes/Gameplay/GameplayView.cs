using Agate.MVC.Base;
using SimpleIdle.Gameplay.Character;
using SimpleIdle.Gameplay.CharacterHolder;
using SimpleIdle.Gameplay.Resource;
using UnityEngine;

namespace SimpleIdle.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        [SerializeField] public CharacterHolderView CharacterHolderView;
        [SerializeField] public ResourceView ResourceView;
    }
}