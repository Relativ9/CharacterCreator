using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EyelashSkinWrap : MonoBehaviour
{
    public SkinnedMeshRenderer eyeLash;
    public SkinnedMeshRenderer baseMesh;
    public CharCustomization charCust;

    public List<Slider> sliderNames = new List<Slider>();
    private Slider relevantSlider;

    // Start is called before the first frame update
    void Start()
    {
        eyeLash = this.gameObject.GetComponent<SkinnedMeshRenderer>();
        charCust = FindObjectOfType<CharCustomization>();

    }

    // Update is called once per frame

    void LateUpdate()
    {

        for (int i = 0; i < sliderNames.Count; i++)
        {
            if (sliderNames[i].name == "Eyes_Corners")
            {
                relevantSlider = sliderNames[i];
                relevantSlider.onValueChanged.AddListener(delegate { WrapEyesCorners(); });
            }

            if (sliderNames[i].name == "Eyes_Depth")
            {
                relevantSlider = sliderNames[i];
                relevantSlider.onValueChanged.AddListener(delegate { WarpEyesDepth(); });
            }

            if (sliderNames[i].name == "Eyes_Height")
            {
                relevantSlider = sliderNames[i];
                relevantSlider.onValueChanged.AddListener(delegate { WarpEyesHeight(); });
            }

            if (sliderNames[i].name == "Eyes_Rotated")
            {
                relevantSlider = sliderNames[i];
                relevantSlider.onValueChanged.AddListener(delegate { WarpEyesRotated(); });
            }

            if (sliderNames[i].name == "Eyes_Shape")
            {
                relevantSlider = sliderNames[i];
                relevantSlider.onValueChanged.AddListener(delegate { WrapEyesShape(); });
            }

            if (sliderNames[i].name == "Eyes_Width")
            {
                relevantSlider = sliderNames[i];
                relevantSlider.onValueChanged.AddListener(delegate { WarpEyesWidth(); });
            }

            if (sliderNames[i].name == "Neck_Height")
            {
                relevantSlider = sliderNames[i];
                relevantSlider.onValueChanged.AddListener(delegate { WrapNeckHeight(); });
            }


            if (sliderNames[i].name == null)
            {
                relevantSlider = sliderNames[0];
            }
        }
    }

    public void WrapEyesCorners()
    {
        eyeLash.SetBlendShapeWeight(eyeLash.sharedMesh.GetBlendShapeIndex("LashWrap_EyeCorners Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Eyes_Corners Max")));
        eyeLash.SetBlendShapeWeight(eyeLash.sharedMesh.GetBlendShapeIndex("LashWrap_EyeCorners Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Eyes_Corners Min")));

    }
    public void WarpEyesDepth()
    {
        eyeLash.SetBlendShapeWeight(eyeLash.sharedMesh.GetBlendShapeIndex("LashWrap_EyeDepth Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Eyes_Depth Max")));
        eyeLash.SetBlendShapeWeight(eyeLash.sharedMesh.GetBlendShapeIndex("LashWrap_EyeDepth Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Eyes_Depth Min")));
    }

    public void WarpEyesHeight()
    {
        eyeLash.SetBlendShapeWeight(eyeLash.sharedMesh.GetBlendShapeIndex("LashWrap_EyeHeight Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Eyes_Height Max")));
        eyeLash.SetBlendShapeWeight(eyeLash.sharedMesh.GetBlendShapeIndex("LashWrap_EyeHeight Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Eyes_Height Min")));
    }

    public void WarpEyesRotated()
    {
        eyeLash.SetBlendShapeWeight(eyeLash.sharedMesh.GetBlendShapeIndex("LashWrap_EyeRotated Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Eyes_Rotated Max")));
        eyeLash.SetBlendShapeWeight(eyeLash.sharedMesh.GetBlendShapeIndex("LashWrap_EyeRotated Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Eyes_Rotated Min")));
    }

    public void WrapEyesShape()
    {
        eyeLash.SetBlendShapeWeight(eyeLash.sharedMesh.GetBlendShapeIndex("LashWrap_EyeShape Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Eyes_Shape Max")));
        eyeLash.SetBlendShapeWeight(eyeLash.sharedMesh.GetBlendShapeIndex("LashWrap_EyeShape Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Eyes_Shape Min")));
    }

    public void WarpEyesWidth()
    {
        eyeLash.SetBlendShapeWeight(eyeLash.sharedMesh.GetBlendShapeIndex("LashWrap_EyeWidth Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Eyes_Wide Max")));
        eyeLash.SetBlendShapeWeight(eyeLash.sharedMesh.GetBlendShapeIndex("LashWrap_EyeWidth Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Eyes_Wide Min")));
    }

    public void WrapNeckHeight()
    {
        eyeLash.SetBlendShapeWeight(eyeLash.sharedMesh.GetBlendShapeIndex("LashWrap_NeckHeight Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Neck_Height Max")));
        eyeLash.SetBlendShapeWeight(eyeLash.sharedMesh.GetBlendShapeIndex("LashWrap_NeckHeight Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Neck_Height Min")));
    }
}
