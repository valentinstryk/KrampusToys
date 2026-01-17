using System.Collections;
using DG.Tweening;
using KrToys;
using UnityEngine;
using UnityEngine.Rendering;

public class DoTweenAnim : MonoBehaviour
{
    public void Start()
    {
        transform
            .DORotate(new Vector3(0, 360, 0), 5f, RotateMode.LocalAxisAdd)
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Incremental);
    }
}