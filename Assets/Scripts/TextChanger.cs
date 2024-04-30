using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("Replace text", _duration))
                .Append(_text.DOText("\n Insert text", _duration).SetRelative())
                .Append(_text.DOText("Iterate over text", _duration, true, ScrambleMode.All));
    }
}
