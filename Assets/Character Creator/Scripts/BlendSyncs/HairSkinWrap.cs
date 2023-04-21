using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HairSkinWrap : MonoBehaviour
{
    public SkinnedMeshRenderer hair;
    public SkinnedMeshRenderer baseMesh;
    public CharCustomization charCust;

    public List<Slider> sliderNames = new List<Slider>();
    private Slider relevantSlider;

    // Start is called before the first frame update
    void Start()
    {
        hair = this.gameObject.GetComponent<SkinnedMeshRenderer>();
        charCust = FindObjectOfType<CharCustomization>();

    }

    // Update is called once per frame

    void LateUpdate()
    {

        for (int i = 0; i < sliderNames.Count; i++)
        {

            if (sliderNames[i].name == "Neck_Height")
            {
                relevantSlider = sliderNames[i];
                relevantSlider.onValueChanged.AddListener(delegate { WrapNeckHeight(); });
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

            if (sliderNames[i].name == "Head_Height")
            {
                relevantSlider = sliderNames[i];
                relevantSlider.onValueChanged.AddListener(delegate { WrapHeadHeight(); });
            }

            if (sliderNames[i].name == "Head_Shape")
            {
                relevantSlider = sliderNames[i];
                relevantSlider.onValueChanged.AddListener(delegate { WrapHeadShape(); });
            }

            if (sliderNames[i].name == null)
            {
                relevantSlider = sliderNames[0];
            }
        }
    }

    public void WrapNeckHeight()
    {
        hair.SetBlendShapeWeight(hair.sharedMesh.GetBlendShapeIndex("HairWrap_NeckHeight Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Neck_Height Max")));
        hair.SetBlendShapeWeight(hair.sharedMesh.GetBlendShapeIndex("HairWrap_NeckHeight Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Neck_Height Min")));
    }

    public void WrapHeadWidth()
    {
        hair.SetBlendShapeWeight(hair.sharedMesh.GetBlendShapeIndex("HairWrap_HeadWidth Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Head_Width Max")));
        hair.SetBlendShapeWeight(hair.sharedMesh.GetBlendShapeIndex("HairWrap_HeadWidth Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Head_Width Min")));
    }

    public void WrapHeadDepth()
    {
        hair.SetBlendShapeWeight(hair.sharedMesh.GetBlendShapeIndex("HairWrap_HeadDepth Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Head_Depth Max")));
        hair.SetBlendShapeWeight(hair.sharedMesh.GetBlendShapeIndex("HairWrap_HeadDepth Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Head_Depth Min")));
    }

    public void WrapHeadHeight()
    {
        hair.SetBlendShapeWeight(hair.sharedMesh.GetBlendShapeIndex("HairWrap_HeadHeight Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Head_Height Max")));
        hair.SetBlendShapeWeight(hair.sharedMesh.GetBlendShapeIndex("HairWrap_HeadHeight Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Head_Height Min")));
    }

    public void WrapHeadShape()
    {
        hair.SetBlendShapeWeight(hair.sharedMesh.GetBlendShapeIndex("HairWrap_HeadShape Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Head_Shape Max")));
        hair.SetBlendShapeWeight(hair.sharedMesh.GetBlendShapeIndex("HairWrap_HeadShape Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Head_Shape Min")));
    }
}
