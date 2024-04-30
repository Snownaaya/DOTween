using DG.Tweening;
using UnityEngine;

public class Colorizer : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private Material _material;
    [SerializeField] private float _duration;
    [SerializeField] private int _loop;

    private void Start() => _material.DOColor(_color, _duration).SetLoops(_loop, LoopType.Yoyo);
}
