using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EyebrowSkinWrap : MonoBehaviour
{
    public SkinnedMeshRenderer eyebrow;
    public SkinnedMeshRenderer baseMesh;
    public CharCustomization charCust;

    public List<Slider> sliderNames = new List<Slider>();
    private Slider relevantSlider;

    // Start is called before the first frame update
    void Start()
    {
        eyebrow = this.gameObject.GetComponent<SkinnedMeshRenderer>();
        charCust = FindObjectOfType<CharCustomization>();

    }

    // Update is called once per frame

    void LateUpdate()
    {

        for (int i = 0; i < sliderNames.Count; i++)
        {
            if (sliderNames[i].name == "Brow_Width")
            {
                relevantSlider = sliderNames[i];
                relevantSlider.onValueChanged.AddListener(delegate { WarpBrowWidth(); });
            }

            if (sliderNames[i].name == "Brow_Rotation")
            {
                relevantSlider = sliderNames[i];
                relevantSlider.onValueChanged.AddListener(delegate { WrapBrowRotation(); });
            }

            if (sliderNames[i].name == "Neck_Height")
            {
                relevantSlider = sliderNames[i];
                relevantSlider.onValueChanged.AddListener(delegate { WrapNeckHeight(); });
            }

            if (sliderNames[i].name == "Brow_Height")
            {
                relevantSlider = sliderNames[i];
                relevantSlider.onValueChanged.AddListener(delegate { WrapBrowHeight(); });
            }

            if (sliderNames[i].name == "Head_Width")
            {
                relevantSlider = sliderNames[i];
                relevantSlider.onValueChanged.AddListener(delegate { WrapHeadWidth(); });
            }

            if (sliderNames[i].name == "Head_Depth")
            {
                relevantSlider = sliderNames[i];
                relevantSlider.onValueChanged.AddListener(delegate { WrapHeadDepth(); });
            }

            if (sliderNames[i].name == "Brow_Depth")
            {
                relevantSlider = sliderNames[i];
                relevantSlider.onValueChanged.AddListener(delegate { WrapBrowDepth(); });
            }

            if (sliderNames[i].name == "Base_Bodyfat")
            {
                relevantSlider = sliderNames[i];
                relevantSlider.onValueChanged.AddListener(delegate { WarpBrowBodyFat(); });
            }

            if (sliderNames[i].name == null)
            {
                relevantSlider = sliderNames[0];
            }
        }
    }

    public void WarpBrowWidth()
    {
        eyebrow.SetBlendShapeWeight(eyebrow.sharedMesh.GetBlendShapeIndex("BrowWrap_BrowWidth Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Brow_Width Max")));
        eyebrow.SetBlendShapeWeight(eyebrow.sharedMesh.GetBlendShapeIndex("BrowWrap_BrowWidth Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Brow_Width Min")));

    }
    public void WrapBrowRotation()
    {
        eyebrow.SetBlendShapeWeight(eyebrow.sharedMesh.GetBlendShapeIndex("BrowWrap_BrowRotation Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Brow_Rotation Max")));
        eyebrow.SetBlendShapeWeight(eyebrow.sharedMesh.GetBlendShapeIndex("BrowWrap_BrowRotation Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Brow_Rotation Min")));
    }

    public void WrapNeckHeight()
    {
        eyebrow.SetBlendShapeWeight(eyebrow.sharedMesh.GetBlendShapeIndex("BrowWrap_NeckHeight Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Neck_Height Max")));
        eyebrow.SetBlendShapeWeight(eyebrow.sharedMesh.GetBlendShapeIndex("BrowWrap_NeckHeight Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Neck_Height Min")));
    }

    public void WrapBrowHeight()
    {
        eyebrow.SetBlendShapeWeight(eyebrow.sharedMesh.GetBlendShapeIndex("BrowWrap_BrowHeight Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Brow_Height Max")));
        eyebrow.SetBlendShapeWeight(eyebrow.sharedMesh.GetBlendShapeIndex("BrowWrap_BrowHeight Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Brow_Height Min")));
    }

    public void WrapHeadWidth()
    {
        eyebrow.SetBlendShapeWeight(eyebrow.sharedMesh.GetBlendShapeIndex("BrowWrap_HeadWidth Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Head_Width Max")));
        eyebrow.SetBlendShapeWeight(eyebrow.sharedMesh.GetBlendShapeIndex("BrowWrap_HeadWidth Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Head_Width Min")));
    }

    public void WrapHeadDepth()
    {
        eyebrow.SetBlendShapeWeight(eyebrow.sharedMesh.GetBlendShapeIndex("BrowWrap_HeadDepth Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Head_Depth Max")));
        eyebrow.SetBlendShapeWeight(eyebrow.sharedMesh.GetBlendShapeIndex("BrowWrap_HeadDepth Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Head_Depth Min")));
    }

    public void WrapBrowDepth()
    {
        eyebrow.SetBlendShapeWeight(eyebrow.sharedMesh.GetBlendShapeIndex("BrowWrap_BrowDepth Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Brow_Depth Max")));
        eyebrow.SetBlendShapeWeight(eyebrow.sharedMesh.GetBlendShapeIndex("BrowWrap_BrowDepth Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Brow_Depth Min")));
    }

    public void WarpBrowBodyFat()
    {
        eyebrow.SetBlendShapeWeight(eyebrow.sharedMesh.GetBlendShapeIndex("BrowWrap_BodyFat Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Body_Bodyfat Max")));
        eyebrow.SetBlendShapeWeight(eyebrow.sharedMesh.GetBlendShapeIndex("BrowWrap_Bodyfat Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Brow_Bodyfat Min")));
    }
}
