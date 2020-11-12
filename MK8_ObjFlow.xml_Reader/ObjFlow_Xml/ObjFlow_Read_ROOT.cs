using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MK8_ObjFlow.xml_Reader.ObjFlow_Xml
{
    /// <summary>
    /// yamlルート
    /// </summary>
    [System.Xml.Serialization.XmlRoot("yaml")] //ルート要素
    public class ObjFlow_Read_ROOT
    {
        [System.Xml.Serialization.XmlAttribute("type")]
        public string yaml_Type { get; set; }

        /// <summary>
        /// value tag
        /// </summary>
        [System.Xml.Serialization.XmlElement("value")]
        public List<Value_Array> Value_Arrays { get; set; }
    }

    /// <summary>
    /// valueタグ(Array)
    /// </summary>
    [Serializable]
    public class Value_Array
    {
        /// <summary>
        ///  AiReact Attr
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("AiReact")]
        public int AiReact { get; set; }

        /// <summary>
        ///  CalcCut Attr
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("CalcCut")]
        public bool CalcCut { get; set; }

        /// <summary>
        ///  Clip Attr
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("Clip")]
        public bool Clip { get; set; }

        /// <summary>
        ///  ClipRadius Attr
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("ClipRadius")]
        public string ClipRadius { get; set; }


        /// <summary>
        ///  ColOffsetY Attr
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("ColOffsetY")]
        public string ColOffsetY { get; set; }

        /// <summary>
        ///  ColShape Attr
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("ColShape")]
        public int ColShape { get; set; }

        /// <summary>
        ///  DemoCameraCheck Attr
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("DemoCameraCheck")]
        public bool DemoCameraCheck { get; set; }

        /// <summary>
        ///  LightSetting Attr
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("LightSetting")]
        public int LightSetting { get; set; }

        /// <summary>
        /// Lod1 Attr
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("Lod1")]
        public string Lod1 { get; set; }

        /// <summary>
        /// Lod2 Attr
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("Lod2")]
        public string Lod2 { get; set; }

        /// <summary>
        /// Lod_NoDisp Attr
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("Lod_NoDisp")]
        public string Lod_NoDisp { get; set; }

        /// <summary>
        /// MgrId Attr
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("MgrId")]
        public int MgrId { get; set; }

        /// <summary>
        /// ModelDraw Attr
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("ModelDraw")]
        public int ModelDraw { get; set; }

        /// <summary>
        /// ModelEffNo Attr
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("ModelEffNo")]
        public int ModelEffNo { get; set; }

        /// <summary>
        /// MoveBeforeSync Attr
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("MoveBeforeSync")]
        public bool MoveBeforeSync { get; set; }

        /// <summary>
        /// NotCreate Attr
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("NotCreate")]
        public bool NotCreate { get; set; }

        /// <summary>
        /// ObjId Attr
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("ObjId")]
        public int ObjId { get; set; }

        /// <summary>
        /// Offset Attr
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("Offset")]
        public string Offset { get; set; }

        /// <summary>
        /// Origin Attr
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("Origin")]
        public int Origin { get; set; }

        /// <summary>
        /// PackunEat Attr
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("PackunEat")]
        public bool PackunEat { get; set; }

        /// <summary>
        /// PathType Attr
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("PathType")]
        public int PathType { get; set; }

        /// <summary>
        /// PylonReact Attr
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("PylonReact")]
        public int PylonReact { get; set; }

        /// <summary>
        /// VR Attr
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("VR")]
        public bool VR { get; set; }

        /// <summary>
        /// ColSize 
        /// </summary>
        [System.Xml.Serialization.XmlElement("ColSize")]
        public ColSize_Val ColSize { get; set; }

        /// <summary>
        /// Item
        /// </summary>
        [System.Xml.Serialization.XmlElement("Item")]
        public Item Items { get; set; }

        /// <summary>
        /// ItemObj Array
        /// </summary>
        [System.Xml.Serialization.XmlElement("ItemObj")]
        public ItemObj ItemObjs { get; set; }

        /// <summary>
        /// Kart Array
        /// </summary>
        [System.Xml.Serialization.XmlElement("Kart")]
        public Kart Karts { get; set; }

        /// <summary>
        /// KartObj Array
        /// </summary>
        [System.Xml.Serialization.XmlElement("KartObj")]
        public KartObj KartObjs { get; set; }

        /// <summary>
        /// Label
        /// </summary>
        [System.Xml.Serialization.XmlElement("Label")]
        public Label Label { get; set; }

        /// <summary>
        /// ResName Array
        /// </summary>
        [System.Xml.Serialization.XmlElement("ResName")]
        public ResName ResNames { get; set; }
    }

    /// <summary>
    /// ColSize_Val -> X, Y, Z
    /// </summary>
    [Serializable]
    public class ColSize_Val
    {
        /// <summary>
        /// ColSize_X_Val
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("X")]
        public string X_Val { get; set; }

        /// <summary>
        /// ColSize_Y_Val
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("Y")]
        public string Y_Val { get; set; }

        /// <summary>
        /// ColSize_Z_Val
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("Z")]
        public string Z_Val { get; set; }
    }

    public class Item
    {
        /// <summary>
        /// Item_Type
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("type")]
        public string Item_Value_Type { get; set; }

        /// <summary>
        /// Item -> value tag
        /// </summary>
        [System.Xml.Serialization.XmlElement("value")]
        public List<Item_Value_Array> Item_Value_Ary { get; set; }
        public class Item_Value_Array
        {
            /// <summary>
            /// Item_Value
            /// </summary>
            [System.Xml.Serialization.XmlText]
            public int ItemVal { get; set; }
        }
    }

    public class ItemObj
    {
        /// <summary>
        /// ItemObj_Type
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("type")]
        public string ItemObj_Value_Type { get; set; }

        /// <summary>
        /// ItemObj -> value tag
        /// </summary>
        [System.Xml.Serialization.XmlElement("value")]
        public List<ItemObj_Value_Array> ItemObj_Value_Ary { get; set; }
        public class ItemObj_Value_Array
        {
            /// <summary>
            /// ItemObj_Value
            /// </summary>
            [System.Xml.Serialization.XmlText]
            public int ItemObjVal { get; set; }
        }
    }

    public class Kart
    {
        /// <summary>
        /// Kart_Type
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("type")]
        public string Kart_Value_Type { get; set; }

        /// <summary>
        /// Kart -> value tag
        /// </summary>
        [System.Xml.Serialization.XmlElement("value")]
        public List<Kart_Value_Array> Kart_Value_Ary { get; set; }
        public class Kart_Value_Array
        {
            /// <summary>
            /// Kart_Value
            /// </summary>
            [System.Xml.Serialization.XmlText]
            public int KartVal { get; set; }
        }
    }

    public class KartObj
    {
        /// <summary>
        /// KartObj_Type
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("type")]
        public string KartObj_Value_Type { get; set; }

        /// <summary>
        /// KartObj -> value tag
        /// </summary>
        [System.Xml.Serialization.XmlElement("value")]
        public List<KartObj_Value_Array> KartObj_Value_Ary { get; set; }
        public class KartObj_Value_Array
        {
            /// <summary>
            /// KartObj_Value
            /// </summary>
            [System.Xml.Serialization.XmlText]
            public int KartObjVal { get; set; }
        }
    }

    /// <summary>
    /// Label tag
    /// </summary>
    [Serializable]
    public class Label
    {
        /// <summary>
        /// Label_Attr
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("type")]
        public string Label_Type { get; set; }

        /// <summary>
        /// Label_String
        /// </summary>
        [System.Xml.Serialization.XmlText]
        public string Label_String { get; set; }
    }

    public class ResName
    {
        /// <summary>
        /// ResName_Type
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("type")]
        public string ResName_Value_Type { get; set; }

        /// <summary>
        /// ResName -> value tag
        /// </summary>
        [System.Xml.Serialization.XmlElement("value")]
        public List<ResName_Value_Array> ResName_Value_Ary { get; set; }
        public class ResName_Value_Array
        {
            /// <summary>
            /// ResNameStr_Value_Attr
            /// </summary>
            [System.Xml.Serialization.XmlAttribute("type")]
            public string ResNameStr_Value_Type { get; set; }

            /// <summary>
            /// ResName_String
            /// </summary>
            [System.Xml.Serialization.XmlText]
            public string ResNameStr { get; set; }
        }
    }
}

