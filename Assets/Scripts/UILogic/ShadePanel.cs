using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShadePanel : MonoBehaviour
{
    [SerializeField, Range(0, 2)] private float _shadingSpeed;
    [SerializeField] private Image _shadingPlane;
    [SerializeField] private float _maxAlpha;

    protected bool _shadeComplete;

    private Color _panelColor;
    private float _alpha;

    public void PlayAnim()
    {
        _panelColor = _shadingPlane.color;
        _alpha = 0;
        _shadeComplete = false;
        StartCoroutine(Anim());
    }

    public void PlayBackAnim()
    {
        _panelColor = _shadingPlane.color;
        _alpha = _maxAlpha;
        StartCoroutine(BackAnim());
    }

    private IEnumerator Anim()
    {
        while (_alpha < _maxAlpha)
        {
            _alpha += _shadingSpeed * Time.deltaTime;
            _panelColor.a = Mathf.Clamp01(_alpha);
            _shadingPlane.color = _panelColor;

            yield return new WaitForEndOfFrame();
        }

        _shadeComplete = true;
    }

    private IEnumerator BackAnim()
    {
        while (_alpha > 0)
        {
            _alpha -= _shadingSpeed * Time.deltaTime;
            _panelColor.a = Mathf.Clamp01(_alpha);
            _shadingPlane.color = _panelColor;

            yield return new WaitForEndOfFrame();
        }

        gameObject.SetActive(false);
    }
}
