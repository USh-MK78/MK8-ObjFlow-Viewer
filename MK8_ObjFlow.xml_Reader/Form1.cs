using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace MK8_ObjFlow.xml_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridViewの新規行を追加できないようにする
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;

            //dataGridView1の並び替えを無効化
            foreach(DataGridViewColumn DGV1 in dataGridView1.Columns)
            {
                DGV1.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //dataGridView2の並び替えを無効化
            foreach (DataGridViewColumn DGV2 in dataGridView2.Columns)
            {
                DGV2.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //tabcontrol1にAnchorを設定してサイズを自動的に調整する
            tabControl1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
        }

        private void openObjFlowxmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                Title = "Open ObjFlow.xml",
                InitialDirectory = @"C:\Users\User\Desktop",
                Filter = "xml file|*.xml"
            };

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            System.IO.FileStream fs1 = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read); //ファイルを開く
            System.Xml.Serialization.XmlSerializer s1 = new System.Xml.Serialization.XmlSerializer(typeof(MK8_ObjFlow.xml_Reader.ObjFlow_Xml.ObjFlow_Read_ROOT)); //ObjFlow_ROOT.cs
            MK8_ObjFlow.xml_Reader.ObjFlow_Xml.ObjFlow_Read_ROOT BYAML_XML_Model = (MK8_ObjFlow.xml_Reader.ObjFlow_Xml.ObjFlow_Read_ROOT)s1.Deserialize(fs1); //MK8_ObjFlow.xml_Reader.ObjFlow_Xml.ObjFlow_ROOTクラスの内容をデシリアライズ

            foreach (MK8_ObjFlow.xml_Reader.ObjFlow_Xml.Value_Array BYAML_XML_UMDL in BYAML_XML_Model.Value_Arrays) //foreachで繰り返し要素のあるXMLを読み込む
            {
                //dataGridViewに表示
                dataGridView1.Rows.Add(BYAML_XML_UMDL.AiReact,
                                       BYAML_XML_UMDL.CalcCut,
                                       BYAML_XML_UMDL.Clip,
                                       BYAML_XML_UMDL.ClipRadius,
                                       BYAML_XML_UMDL.ColOffsetY,
                                       BYAML_XML_UMDL.ColShape,
                                       BYAML_XML_UMDL.DemoCameraCheck,
                                       BYAML_XML_UMDL.LightSetting,
                                       BYAML_XML_UMDL.Lod1,
                                       BYAML_XML_UMDL.Lod2,
                                       BYAML_XML_UMDL.Lod_NoDisp,
                                       BYAML_XML_UMDL.MgrId,
                                       BYAML_XML_UMDL.ModelDraw,
                                       BYAML_XML_UMDL.ModelEffNo,
                                       BYAML_XML_UMDL.MoveBeforeSync,
                                       BYAML_XML_UMDL.NotCreate,
                                       BYAML_XML_UMDL.ObjId,
                                       BYAML_XML_UMDL.Offset,
                                       BYAML_XML_UMDL.Origin,
                                       BYAML_XML_UMDL.PackunEat,
                                       BYAML_XML_UMDL.PathType,
                                       BYAML_XML_UMDL.PylonReact,
                                       BYAML_XML_UMDL.VR);

                dataGridView2.Rows.Add(BYAML_XML_UMDL.ColSize.X_Val,
                                       BYAML_XML_UMDL.ColSize.Y_Val,
                                       BYAML_XML_UMDL.ColSize.Z_Val,
                                       BYAML_XML_UMDL.Items.Item_Value_Ary[0].ItemVal,
                                       BYAML_XML_UMDL.Items.Item_Value_Ary[1].ItemVal,
                                       BYAML_XML_UMDL.Items.Item_Value_Ary[2].ItemVal,
                                       BYAML_XML_UMDL.Items.Item_Value_Ary[3].ItemVal,
                                       BYAML_XML_UMDL.Items.Item_Value_Ary[4].ItemVal,
                                       BYAML_XML_UMDL.Items.Item_Value_Ary[5].ItemVal,
                                       BYAML_XML_UMDL.Items.Item_Value_Ary[6].ItemVal,
                                       BYAML_XML_UMDL.Items.Item_Value_Ary[7].ItemVal,
                                       BYAML_XML_UMDL.Items.Item_Value_Ary[8].ItemVal,
                                       BYAML_XML_UMDL.Items.Item_Value_Ary[9].ItemVal,
                                       BYAML_XML_UMDL.Items.Item_Value_Ary[10].ItemVal,
                                       BYAML_XML_UMDL.Items.Item_Value_Ary[11].ItemVal,
                                       BYAML_XML_UMDL.Items.Item_Value_Ary[12].ItemVal,
                                       BYAML_XML_UMDL.ItemObjs.ItemObj_Value_Ary[0].ItemObjVal,
                                       BYAML_XML_UMDL.ItemObjs.ItemObj_Value_Ary[1].ItemObjVal,
                                       BYAML_XML_UMDL.ItemObjs.ItemObj_Value_Ary[2].ItemObjVal,
                                       BYAML_XML_UMDL.ItemObjs.ItemObj_Value_Ary[3].ItemObjVal,
                                       BYAML_XML_UMDL.ItemObjs.ItemObj_Value_Ary[4].ItemObjVal,
                                       BYAML_XML_UMDL.ItemObjs.ItemObj_Value_Ary[5].ItemObjVal,
                                       BYAML_XML_UMDL.ItemObjs.ItemObj_Value_Ary[6].ItemObjVal,
                                       BYAML_XML_UMDL.ItemObjs.ItemObj_Value_Ary[7].ItemObjVal,
                                       BYAML_XML_UMDL.ItemObjs.ItemObj_Value_Ary[8].ItemObjVal,
                                       BYAML_XML_UMDL.ItemObjs.ItemObj_Value_Ary[9].ItemObjVal,
                                       BYAML_XML_UMDL.ItemObjs.ItemObj_Value_Ary[10].ItemObjVal,
                                       BYAML_XML_UMDL.ItemObjs.ItemObj_Value_Ary[11].ItemObjVal,
                                       BYAML_XML_UMDL.ItemObjs.ItemObj_Value_Ary[12].ItemObjVal,
                                       BYAML_XML_UMDL.Karts.Kart_Value_Ary[0].KartVal,
                                       BYAML_XML_UMDL.Karts.Kart_Value_Ary[1].KartVal,
                                       BYAML_XML_UMDL.Karts.Kart_Value_Ary[2].KartVal,
                                       BYAML_XML_UMDL.Karts.Kart_Value_Ary[3].KartVal,
                                       BYAML_XML_UMDL.KartObjs.KartObj_Value_Ary[0].KartObjVal,
                                       BYAML_XML_UMDL.KartObjs.KartObj_Value_Ary[1].KartObjVal,
                                       BYAML_XML_UMDL.KartObjs.KartObj_Value_Ary[2].KartObjVal,
                                       BYAML_XML_UMDL.KartObjs.KartObj_Value_Ary[3].KartObjVal,
                                       BYAML_XML_UMDL.Label.Label_String,
                                       BYAML_XML_UMDL.ResNames.ResName_Value_Ary[0].ResNameStr);
            }
            fs1.Close();
        }

        private void saveObjFlowxmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog()
            {
                Title = "Save ObjFlow.xml",
                InitialDirectory = @"C:\Users\User\Desktop",
                Filter = "xml file|*.xml"
            };

            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;

            List<ObjFlow_Xml.Value_Array> ValueAry = new List<ObjFlow_Xml.Value_Array>();
            for(int Count = 0; Count < dataGridView1.RowCount; Count++)
            {
                #region Item
                List<int> Item_Val_List = new List<int>();
                Item_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[3].Value.ToString()));
                Item_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[4].Value.ToString()));
                Item_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[5].Value.ToString()));
                Item_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[6].Value.ToString()));
                Item_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[7].Value.ToString()));
                Item_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[8].Value.ToString()));
                Item_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[9].Value.ToString()));
                Item_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[10].Value.ToString()));
                Item_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[11].Value.ToString()));
                Item_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[12].Value.ToString()));
                Item_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[13].Value.ToString()));
                Item_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[14].Value.ToString()));
                Item_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[15].Value.ToString()));

                List<ObjFlow_Xml.Item.Item_Value_Array> Clip_Value_List = new List<ObjFlow_Xml.Item.Item_Value_Array>();
                for (int ItemValueCount = 0; ItemValueCount < Item_Val_List.Count; ItemValueCount++)
                {
                    ObjFlow_Xml.Item.Item_Value_Array IVA = new ObjFlow_Xml.Item.Item_Value_Array()
                    {
                        ItemVal = Item_Val_List[ItemValueCount]
                    };

                    Clip_Value_List.Add(IVA);
                }
                #endregion

                #region ItemObj
                List<int> ItemObj_Val_List = new List<int>();
                ItemObj_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[16].Value.ToString()));
                ItemObj_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[17].Value.ToString()));
                ItemObj_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[18].Value.ToString()));
                ItemObj_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[19].Value.ToString()));
                ItemObj_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[20].Value.ToString()));
                ItemObj_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[21].Value.ToString()));
                ItemObj_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[22].Value.ToString()));
                ItemObj_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[23].Value.ToString()));
                ItemObj_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[24].Value.ToString()));
                ItemObj_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[25].Value.ToString()));
                ItemObj_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[26].Value.ToString()));
                ItemObj_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[27].Value.ToString()));
                ItemObj_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[28].Value.ToString()));

                List<ObjFlow_Xml.ItemObj.ItemObj_Value_Array> ItemObj_Value_List = new List<ObjFlow_Xml.ItemObj.ItemObj_Value_Array>();
                for (int ItemObjValueCount = 0; ItemObjValueCount < ItemObj_Val_List.Count; ItemObjValueCount++)
                {
                    ObjFlow_Xml.ItemObj.ItemObj_Value_Array ItemObjValAry = new ObjFlow_Xml.ItemObj.ItemObj_Value_Array()
                    {
                        ItemObjVal = ItemObj_Val_List[ItemObjValueCount]
                    };

                    ItemObj_Value_List.Add(ItemObjValAry);
                }
                #endregion

                #region Kart
                List<int> Kart_Val_List = new List<int>();
                Kart_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[29].Value.ToString()));
                Kart_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[30].Value.ToString()));
                Kart_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[31].Value.ToString()));
                Kart_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[32].Value.ToString()));

                List<ObjFlow_Xml.Kart.Kart_Value_Array> Kart_Value_List = new List<ObjFlow_Xml.Kart.Kart_Value_Array>();
                for (int KartValueCount = 0; KartValueCount < Kart_Val_List.Count; KartValueCount++)
                {
                    ObjFlow_Xml.Kart.Kart_Value_Array KartValAry = new ObjFlow_Xml.Kart.Kart_Value_Array
                    {
                        KartVal = Kart_Val_List[KartValueCount]
                    };

                    Kart_Value_List.Add(KartValAry);
                }
                #endregion

                #region KartObj
                List<int> KartObj_Val_List = new List<int>();
                KartObj_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[33].Value.ToString()));
                KartObj_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[34].Value.ToString()));
                KartObj_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[35].Value.ToString()));
                KartObj_Val_List.Add(int.Parse(dataGridView2.Rows[Count].Cells[36].Value.ToString()));

                List<ObjFlow_Xml.KartObj.KartObj_Value_Array> KartObj_Value_List = new List<ObjFlow_Xml.KartObj.KartObj_Value_Array>();
                for (int KartObjValueCount = 0; KartObjValueCount < KartObj_Val_List.Count; KartObjValueCount++)
                {
                    ObjFlow_Xml.KartObj.KartObj_Value_Array KartObjValAry = new ObjFlow_Xml.KartObj.KartObj_Value_Array
                    {
                        KartObjVal = KartObj_Val_List[KartObjValueCount]
                    };

                    KartObj_Value_List.Add(KartObjValAry);
                }
                #endregion

                #region ResName
                List<string> ResName_Val_List = new List<string>();
                ResName_Val_List.Add(dataGridView2.Rows[Count].Cells[38].Value.ToString());

                List<ObjFlow_Xml.ResName.ResName_Value_Array> ResName_Value_List = new List<ObjFlow_Xml.ResName.ResName_Value_Array>();
                for (int ResNameValueCount = 0; ResNameValueCount < ResName_Val_List.Count; ResNameValueCount++)
                {
                    ObjFlow_Xml.ResName.ResName_Value_Array ResNameValAry = new ObjFlow_Xml.ResName.ResName_Value_Array
                    {
                        ResNameStr_Value_Type = "string",
                        ResNameStr = ResName_Val_List[ResNameValueCount]
                    };

                    ResName_Value_List.Add(ResNameValAry);
                }
                #endregion

                #region ObjFlow_ROOT
                ObjFlow_Xml.Value_Array value_Array = new ObjFlow_Xml.Value_Array
                {
                    AiReact = int.Parse(dataGridView1.Rows[Count].Cells[0].Value.ToString()),
                    CalcCut = Convert.ToBoolean(((DataGridViewCheckBoxCell)dataGridView1.Rows[Count].Cells[1]).Value),
                    Clip = Convert.ToBoolean(((DataGridViewCheckBoxCell)dataGridView1.Rows[Count].Cells[2]).Value),
                    ClipRadius = dataGridView1.Rows[Count].Cells[3].Value.ToString(),
                    ColOffsetY = dataGridView1.Rows[Count].Cells[4].Value.ToString(),
                    ColShape = int.Parse(dataGridView1.Rows[Count].Cells[5].Value.ToString()),
                    DemoCameraCheck = Convert.ToBoolean(((DataGridViewCheckBoxCell)dataGridView1.Rows[Count].Cells[6]).Value),

                    LightSetting = int.Parse(dataGridView1.Rows[Count].Cells[7].Value.ToString()),
                    Lod1 = dataGridView1.Rows[Count].Cells[8].Value.ToString(),
                    Lod2 = dataGridView1.Rows[Count].Cells[9].Value.ToString(),
                    Lod_NoDisp = dataGridView1.Rows[Count].Cells[10].Value.ToString(),
                    MgrId = int.Parse(dataGridView1.Rows[Count].Cells[11].Value.ToString()),
                    ModelDraw = int.Parse(dataGridView1.Rows[Count].Cells[12].Value.ToString()),
                    ModelEffNo = int.Parse(dataGridView1.Rows[Count].Cells[13].Value.ToString()),
                    MoveBeforeSync = Convert.ToBoolean(((DataGridViewCheckBoxCell)dataGridView1.Rows[Count].Cells[14]).Value),
                    NotCreate = Convert.ToBoolean(((DataGridViewCheckBoxCell)dataGridView1.Rows[Count].Cells[15]).Value),
                    ObjId = int.Parse(dataGridView1.Rows[Count].Cells[16].Value.ToString()),
                    Offset = dataGridView1.Rows[Count].Cells[17].Value.ToString(),
                    Origin = int.Parse(dataGridView1.Rows[Count].Cells[18].Value.ToString()),
                    PackunEat = Convert.ToBoolean(((DataGridViewCheckBoxCell)dataGridView1.Rows[Count].Cells[19]).Value),
                    PathType = int.Parse(dataGridView1.Rows[Count].Cells[20].Value.ToString()),
                    PylonReact = int.Parse(dataGridView1.Rows[Count].Cells[21].Value.ToString()),
                    VR = Convert.ToBoolean(((DataGridViewCheckBoxCell)dataGridView1.Rows[Count].Cells[22]).Value),
                    ColSize = new ObjFlow_Xml.ColSize_Val
                    {
                        X_Val = dataGridView2.Rows[Count].Cells[0].Value.ToString(),
                        Y_Val = dataGridView2.Rows[Count].Cells[1].Value.ToString(),
                        Z_Val = dataGridView2.Rows[Count].Cells[2].Value.ToString()
                    },
                    Items = new ObjFlow_Xml.Item
                    {
                        Item_Value_Type = "array",
                        Item_Value_Ary = Clip_Value_List
                    },
                    ItemObjs = new ObjFlow_Xml.ItemObj
                    {
                        ItemObj_Value_Type = "array",
                        ItemObj_Value_Ary = ItemObj_Value_List
                    },
                    Karts = new ObjFlow_Xml.Kart
                    {
                        Kart_Value_Type = "array",
                        Kart_Value_Ary = Kart_Value_List
                    },
                    KartObjs = new ObjFlow_Xml.KartObj
                    {
                        KartObj_Value_Type = "array",
                        KartObj_Value_Ary = KartObj_Value_List
                    },
                    Label = new ObjFlow_Xml.Label
                    {
                        Label_Type = "string",
                        Label_String = dataGridView2.Rows[Count].Cells[37].Value.ToString()
                    },
                    ResNames = new ObjFlow_Xml.ResName
                    {
                        ResName_Value_Type = "string",
                        ResName_Value_Ary = ResName_Value_List
                    }
                };
                #endregion

                ValueAry.Add(value_Array);
            }

            ObjFlow_Xml.ObjFlow_Read_ROOT YAMLROOT = new ObjFlow_Xml.ObjFlow_Read_ROOT
            {
                yaml_Type = "array",
                Value_Arrays = ValueAry
            };

            //Delete Namespaces
            var xns = new XmlSerializerNamespaces();
            xns.Add(string.Empty, string.Empty);

            System.Xml.Serialization.XmlSerializer serializer = new XmlSerializer(typeof(ObjFlow_Xml.ObjFlow_Read_ROOT));
            System.IO.StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, new System.Text.UTF8Encoding(false));
            serializer.Serialize(sw, YAMLROOT, xns);
            sw.Close();
        }

        private void addRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dataGridView1とdataGridView2に新規行を追加
            dataGridView1.Rows.Add();
            dataGridView2.Rows.Add();
        }

        private void deleteRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tabcontrol1のIndexを取得して処理を分岐
            if(tabControl1.SelectedIndex == 0)
            {
                //選択している行を取得(dataGridView1)
                foreach (DataGridViewRow SelectRows1 in dataGridView1.SelectedRows)
                {
                    //dataGridView2の同じ行を選択する
                    dataGridView2.Rows[SelectRows1.Index].Selected = true;
                    //dataGridView1の選択した行を削除
                    dataGridView1.Rows.RemoveAt(SelectRows1.Index);
                    //dataGridView2の選択した行を削除()
                    dataGridView2.Rows.RemoveAt(SelectRows1.Index + 1);
                }

            }
            else if(tabControl1.SelectedIndex == 1)
            {
                //選択している行を取得(dataGridView2)
                foreach (DataGridViewRow SelectRows2 in dataGridView2.SelectedRows)
                {
                    //dataGridView1の同じ行を選択する
                    dataGridView1.Rows[SelectRows2.Index].Selected = true;
                    //dataGridView2の選択した行を削除
                    dataGridView2.Rows.RemoveAt(SelectRows2.Index);
                    //dataGridView1の選択した行を削除
                    dataGridView1.Rows.RemoveAt(SelectRows2.Index + 1);
                }
            }
        }
    }
}
