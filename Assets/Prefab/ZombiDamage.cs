using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ZombiDamage : MonoBehaviour
{
    public int ZombiHP = 100;
    private static readonly int PRORERTY_COLOR = Shader.PropertyToID("_Color");
    /// <summary> モデルのRenderer </summary>
    [SerializeField]
    private Renderer _renderer;
    /// <summary> モデルのマテリアルの複製 </summary>
    private Material _material;

    private Sequence _Seq;

    private void Awake()
    {
        // materialにアクセスして自動生成されるマテリアルを保持
        _material = _renderer.material;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.tag == "Shell")
        {
            ZombiHP -= 10;
            Destroy(collision.gameObject);
        }

       if (ZombiHP <= 0)
        {
            Destroy(this.gameObject);

        }
      
    }
    private void HitFedeBlink(Color _color)
    {
        _Seq.Kill();
        _Seq = DOTween.Sequence();
        _Seq.Append(DOTween.To(() => Color.white, c => _material.SetColor(PRORERTY_COLOR, c), color, 0.1f));
        _Seq.Append(DOTween.To(() => color, c => _material.SetColor(PROPERTY_COLOR, c), Color.white, 0.1f));
        
    }

}

