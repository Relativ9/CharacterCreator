using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EyeLeftSkinWrap : MonoBehaviour
{
    public SkinnedMeshRenderer leftEye;
    public SkinnedMeshRenderer baseMesh;
    public CharCustomization charCust;

    public List<Slider> sliderNames = new List<Slider>();
    private Slider relevantSlider;

    // Start is called before the first frame update
    void Start()
    {
        leftEye = this.gameObject.GetComponent<SkinnedMeshRenderer>();
        charCust = FindObjectOfType<CharCustomization>();

    }

    // Update is called once per frame

    void LateUpdate()
    {

        for (int i = 0; i < sliderNames.Count; i++)
        {
            if (sliderNames[i].name == "Cheek_Depth")
            {
                relevantSlider = sliderNames[i];
                relevantSlider.onValueChanged.AddListener(delegate { WrapCheekDepth(); });
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

    public void WrapCheekDepth()
    {
        leftEye.SetBlendShapeWeight(leftEye.sharedMesh.GetBlendShapeIndex("LeftEyeWrap_CheekDepth Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Cheek_Depth Max")));
        leftEye.SetBlendShapeWeight(leftEye.sharedMesh.GetBlendShapeIndex("LeftEyeWrap_CheekDepth Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Cheek_Depth Min")));

    }
    public void WarpEyesDepth()
    {
        leftEye.SetBlendShapeWeight(leftEye.sharedMesh.GetBlendShapeIndex("LeftEyeWrap_EyeDepth Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Eyes_Depth Max")));
        leftEye.SetBlendShapeWeight(leftEye.sharedMesh.GetBlendShapeIndex("LeftEyeWrap_EyeDepth Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Eyes_Depth Min")));
    }

    public void WarpEyesHeight()
    {
        leftEye.SetBlendShapeWeight(leftEye.sharedMesh.GetBlendShapeIndex("LeftEyeWrap_EyeHeight Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Eyes_Height Max")));
        leftEye.SetBlendShapeWeight(leftEye.sharedMesh.GetBlendShapeIndex("LeftEyeWrap_EyeHeight Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Eyes_Height Min")));
    }

    public void WarpEyesRotated()
    {
        leftEye.SetBlendShapeWeight(leftEye.sharedMesh.GetBlendShapeIndex("LeftEyeWrap_EyeRotation Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Eyes_Rotated Max")));
        leftEye.SetBlendShapeWeight(leftEye.sharedMesh.GetBlendShapeIndex("LeftEyeWrap_EyeRotation Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Eyes_Rotated Min")));
    }

    public void WarpEyesWidth()
    {
        leftEye.SetBlendShapeWeight(leftEye.sharedMesh.GetBlendShapeIndex("LeftEyeWrap_EyeWidth Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Eyes_Wide Max")));
        leftEye.SetBlendShapeWeight(leftEye.sharedMesh.GetBlendShapeIndex("LeftEyeWrap_EyeWidth Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Eyes_Wide Min")));
    }

    public void WrapNeckHeight()
    {
        leftEye.SetBlendShapeWeight(leftEye.sharedMesh.GetBlendShapeIndex("LeftEyeWrap_NeckHeight Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Neck_Height Max")));
        leftEye.SetBlendShapeWeight(leftEye.sharedMesh.GetBlendShapeIndex("LeftEyeWrap_NeckHeight Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Neck_Height Min")));
    }
}
