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
                                       BYAML_XML_UMDL.Items[0].ItemVal,
                                       BYAML_XML_UMDL.Items[1].ItemVal,
                                       BYAML_XML_UMDL.Items[2].ItemVal,
                                       BYAML_XML_UMDL.Items[3].ItemVal,
                                       BYAML_XML_UMDL.Items[4].ItemVal,
                                       BYAML_XML_UMDL.Items[5].ItemVal,
                                       BYAML_XML_UMDL.Items[6].ItemVal,
                                       BYAML_XML_UMDL.Items[7].ItemVal,
                                       BYAML_XML_UMDL.Items[8].ItemVal,
                                       BYAML_XML_UMDL.Items[9].ItemVal,
                                       BYAML_XML_UMDL.Items[10].ItemVal,
                                       BYAML_XML_UMDL.Items[11].ItemVal,
                                       BYAML_XML_UMDL.Items[12].ItemVal,
                                       BYAML_XML_UMDL.ItemObjs[0].ItemObjVal,
                                       BYAML_XML_UMDL.ItemObjs[1].ItemObjVal,
                                       BYAML_XML_UMDL.ItemObjs[2].ItemObjVal,
                                       BYAML_XML_UMDL.ItemObjs[3].ItemObjVal,
                                       BYAML_XML_UMDL.ItemObjs[4].ItemObjVal,
                                       BYAML_XML_UMDL.ItemObjs[5].ItemObjVal,
                                       BYAML_XML_UMDL.ItemObjs[6].ItemObjVal,
                                       BYAML_XML_UMDL.ItemObjs[7].ItemObjVal,
                                       BYAML_XML_UMDL.ItemObjs[8].ItemObjVal,
                                       BYAML_XML_UMDL.ItemObjs[9].ItemObjVal,
                                       BYAML_XML_UMDL.ItemObjs[10].ItemObjVal,
                                       BYAML_XML_UMDL.ItemObjs[11].ItemObjVal,
                                       BYAML_XML_UMDL.ItemObjs[12].ItemObjVal,
                                       BYAML_XML_UMDL.Karts[0].KartVal,
                                       BYAML_XML_UMDL.Karts[1].KartVal,
                                       BYAML_XML_UMDL.Karts[2].KartVal,
                                       BYAML_XML_UMDL.Karts[3].KartVal,
                                       BYAML_XML_UMDL.KartObjs[0].KartObjVal,
                                       BYAML_XML_UMDL.KartObjs[1].KartObjVal,
                                       BYAML_XML_UMDL.KartObjs[2].KartObjVal,
                                       BYAML_XML_UMDL.KartObjs[3].KartObjVal,
                                       BYAML_XML_UMDL.Label.Label_Val_String,
                                       BYAML_XML_UMDL.ResNames[0].ResNameStr);
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

            int DGV1RowsCount = dataGridView1.RowCount;
            int DGV2RowsCount = dataGridView2.RowCount;

            XDocument ObjFlow_BYAML = new XDocument();
            ObjFlow_BYAML.Declaration = new XDeclaration("1.0", "utf-8", "");
            XElement yaml_ROOT = new XElement("yaml");
            yaml_ROOT.Add(new XAttribute("type", "array"));

            int ForCount = 0;
            for(ForCount = 0; ForCount < DGV1RowsCount; ForCount++)
            {
                //valueタグ
                XElement yaml_Value = new XElement("value");
                //AiReact(int)
                yaml_Value.Add(new XAttribute("AiReact", int.Parse(dataGridView1.Rows[ForCount].Cells[0].Value.ToString())));
                //CalcCut(bool)
                DataGridViewCheckBoxCell ch1 = (DataGridViewCheckBoxCell)dataGridView1.Rows[ForCount].Cells[1];
                yaml_Value.Add(new XAttribute("CalcCut", Convert.ToBoolean(ch1.Value)));
                //Clip(bool)
                DataGridViewCheckBoxCell ch2 = (DataGridViewCheckBoxCell)dataGridView1.Rows[ForCount].Cells[2];
                yaml_Value.Add(new XAttribute("Clip", Convert.ToBoolean(ch2.Value)));
                //ClipRadius
                yaml_Value.Add(new XAttribute("ClipRadius", dataGridView1.Rows[ForCount].Cells[3].Value.ToString()));
                //ColOffsetY
                yaml_Value.Add(new XAttribute("ColOffsetY", dataGridView1.Rows[ForCount].Cells[4].Value.ToString()));
                //ColShape(int)
                yaml_Value.Add(new XAttribute("ColShape", int.Parse(dataGridView1.Rows[ForCount].Cells[5].Value.ToString())));
                //DemoCameraCheck(bool)
                DataGridViewCheckBoxCell ch3 = (DataGridViewCheckBoxCell)dataGridView1.Rows[ForCount].Cells[6];
                yaml_Value.Add(new XAttribute("DemoCameraCheck", Convert.ToBoolean(ch3.Value)));
                //LightSetting(int)
                yaml_Value.Add(new XAttribute("LightSetting", int.Parse(dataGridView1.Rows[ForCount].Cells[7].Value.ToString())));
                //Lod1
                yaml_Value.Add(new XAttribute("Lod1", dataGridView1.Rows[ForCount].Cells[8].Value.ToString()));
                //Lod2
                yaml_Value.Add(new XAttribute("Lod2", dataGridView1.Rows[ForCount].Cells[9].Value.ToString()));
                //Lod_NoDisp
                yaml_Value.Add(new XAttribute("Lod_NoDisp", dataGridView1.Rows[ForCount].Cells[10].Value.ToString()));
                //MgrId
                yaml_Value.Add(new XAttribute("MgrId", int.Parse(dataGridView1.Rows[ForCount].Cells[11].Value.ToString())));
                //ModelDraw
                yaml_Value.Add(new XAttribute("ModelDraw", int.Parse(dataGridView1.Rows[ForCount].Cells[12].Value.ToString())));
                //ModelEffNo
                yaml_Value.Add(new XAttribute("ModelEffNo", int.Parse(dataGridView1.Rows[ForCount].Cells[13].Value.ToString())));
                //MoveBeforeSync
                DataGridViewCheckBoxCell ch4 = (DataGridViewCheckBoxCell)dataGridView1.Rows[ForCount].Cells[14];
                yaml_Value.Add(new XAttribute("MoveBeforeSync", Convert.ToBoolean(ch4.Value)));
                //NotCreate
                DataGridViewCheckBoxCell ch5 = (DataGridViewCheckBoxCell)dataGridView1.Rows[ForCount].Cells[15];
                yaml_Value.Add(new XAttribute("NotCreate", Convert.ToBoolean(ch5.Value)));
                //ObjId
                yaml_Value.Add(new XAttribute("ObjId", int.Parse(dataGridView1.Rows[ForCount].Cells[16].Value.ToString())));
                //Offset
                yaml_Value.Add(new XAttribute("Offset", dataGridView1.Rows[ForCount].Cells[17].Value.ToString()));
                //Origin
                yaml_Value.Add(new XAttribute("Origin", int.Parse(dataGridView1.Rows[ForCount].Cells[18].Value.ToString())));
                //PackunEat
                DataGridViewCheckBoxCell ch6 = (DataGridViewCheckBoxCell)dataGridView1.Rows[ForCount].Cells[19];
                yaml_Value.Add(new XAttribute("PackunEat", Convert.ToBoolean(ch6.Value)));
                //PathType
                yaml_Value.Add(new XAttribute("PathType", int.Parse(dataGridView1.Rows[ForCount].Cells[20].Value.ToString())));
                //PylonReact
                yaml_Value.Add(new XAttribute("PylonReact", int.Parse(dataGridView1.Rows[ForCount].Cells[21].Value.ToString())));
                //VR
                DataGridViewCheckBoxCell ch7 = (DataGridViewCheckBoxCell)dataGridView1.Rows[ForCount].Cells[22];
                yaml_Value.Add(new XAttribute("VR", Convert.ToBoolean(ch7.Value)));

                yaml_ROOT.Add(yaml_Value);

                //dataGridView2の内容を書き込む
                //ColSizeタグ(yaml_Valueタグ内に追加)
                XElement yaml_ColSize = new XElement("ColSize");
                yaml_ColSize.Add(new XAttribute("X", dataGridView2.Rows[ForCount].Cells[0].Value.ToString()));
                yaml_ColSize.Add(new XAttribute("Y", dataGridView2.Rows[ForCount].Cells[1].Value.ToString()));
                yaml_ColSize.Add(new XAttribute("Z", dataGridView2.Rows[ForCount].Cells[2].Value.ToString()));
                yaml_Value.Add(yaml_ColSize);

                //Itemタグ(yaml_Valueタグ内に追加)
                XElement yaml_Item = new XElement("Item");
                yaml_Item.Add(new XAttribute("type", "array"));
                yaml_Item.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[3].Value.ToString()));
                yaml_Item.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[4].Value.ToString()));
                yaml_Item.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[5].Value.ToString()));
                yaml_Item.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[6].Value.ToString()));
                yaml_Item.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[7].Value.ToString()));
                yaml_Item.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[8].Value.ToString()));
                yaml_Item.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[9].Value.ToString()));
                yaml_Item.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[10].Value.ToString()));
                yaml_Item.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[11].Value.ToString()));
                yaml_Item.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[12].Value.ToString()));
                yaml_Item.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[13].Value.ToString()));
                yaml_Item.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[14].Value.ToString()));
                yaml_Item.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[15].Value.ToString()));
                yaml_Value.Add(yaml_Item);

                //ItemObjタグ(yaml_Valueタグ内に追加)
                XElement yaml_ItemObj = new XElement("ItemObj");
                yaml_ItemObj.Add(new XAttribute("type", "array"));
                yaml_ItemObj.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[16].Value.ToString()));
                yaml_ItemObj.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[17].Value.ToString()));
                yaml_ItemObj.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[18].Value.ToString()));
                yaml_ItemObj.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[19].Value.ToString()));
                yaml_ItemObj.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[20].Value.ToString()));
                yaml_ItemObj.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[21].Value.ToString()));
                yaml_ItemObj.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[22].Value.ToString()));
                yaml_ItemObj.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[23].Value.ToString()));
                yaml_ItemObj.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[24].Value.ToString()));
                yaml_ItemObj.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[25].Value.ToString()));
                yaml_ItemObj.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[26].Value.ToString()));
                yaml_ItemObj.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[27].Value.ToString()));
                yaml_ItemObj.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[28].Value.ToString()));
                yaml_Value.Add(yaml_ItemObj);

                //Kartタグ(yaml_Valueタグ内に追加)
                XElement yaml_Kart = new XElement("Kart");
                yaml_Kart.Add(new XAttribute("type", "array"));
                yaml_Kart.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[29].Value.ToString()));
                yaml_Kart.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[30].Value.ToString()));
                yaml_Kart.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[31].Value.ToString()));
                yaml_Kart.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[32].Value.ToString()));
                yaml_Value.Add(yaml_Kart);

                //KartObjタグ(yaml_Valueタグ内に追加)
                XElement yaml_KartObj = new XElement("KartObj");
                yaml_KartObj.Add(new XAttribute("type", "array"));
                yaml_KartObj.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[33].Value.ToString()));
                yaml_KartObj.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[34].Value.ToString()));
                yaml_KartObj.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[35].Value.ToString()));
                yaml_KartObj.Add(new XElement("value", dataGridView2.Rows[ForCount].Cells[36].Value.ToString()));
                yaml_Value.Add(yaml_KartObj);

                XElement yaml_Label = new XElement("Label");
                yaml_Label.Add(new XAttribute("type", "string"));
                yaml_Label.Add(new XText(dataGridView2.Rows[ForCount].Cells[37].Value.ToString()));
                yaml_Value.Add(yaml_Label);

                //ResNameタグ(yaml_Valueタグ内に追加)
                XElement yaml_ResName = new XElement("ResName");
                yaml_ResName.Add(new XAttribute("type", "array"));
                //valueタグを追加
                XElement yaml_ResName_Value = new XElement("value", dataGridView2.Rows[ForCount].Cells[38].Value.ToString());
                yaml_ResName_Value.Add(new XAttribute("type", "string"));
                yaml_ResName.Add(yaml_ResName_Value);

                //KartObjタグ(yaml_Valueタグ内に追加)
                yaml_Value.Add(yaml_ResName);
            }

            ObjFlow_BYAML.Add(yaml_ROOT);
            ObjFlow_BYAML.Save(saveFileDialog1.FileName);
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
