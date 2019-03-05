using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SConvertZ
{
    /// <summary>
    /// 施工图转换竣工图属性类
    /// </summary>
  public  class CADTool
    {
      public void Convert()
        {
            frmConvert frm = new frmConvert();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                List<string> lsFiles = frm.ListFiles;
                string desPro = frm.ProDes;
                string desVal = frm.ValDes;
                string noPro = frm.ProNo;
                string oldVal = frm.OldVal;
                string newVal = frm.NewVal;
                bool isMultiple = frm.IsMultiple;

                string msg = "";
                foreach (string file in lsFiles)
                {
                    try
                    {
                        Document doc = Application.DocumentManager.Open(file);
                        Database db = doc.Database;
                        Editor ed = doc.Editor;
                        bool hasblock = true;//当前图纸是否有块
                        using (doc.LockDocument())
                        {
                            //获取最大的块
                            using (Transaction tr = db.TransactionManager.StartTransaction())
                            {
                                BlockTableRecord btRecord = (BlockTableRecord)tr.GetObject(SymbolUtilityServices.GetBlockModelSpaceId(db), OpenMode.ForRead);
                                List<BlockReference> lsBrf = new List<BlockReference>();
                                foreach (ObjectId id in btRecord)
                                {
                                    DBObject obj = tr.GetObject(id, OpenMode.ForRead);
                                    if (obj is BlockReference)
                                    {
                                        BlockReference brf = obj as BlockReference;
                                        lsBrf.Add(brf);
                                    }
                                }

                                if (lsBrf.Count > 0)
                                {
                                    foreach (BlockReference brf in lsBrf)
                                    {
                                        bool isFind = false;
                                        foreach (ObjectId id in brf.AttributeCollection)
                                        {
                                            AttributeReference att = tr.GetObject(id, OpenMode.ForWrite) as AttributeReference;
                                            if (att.Tag.Equals(desPro))//施工图
                                            {
                                                att.TextString = desVal;
                                                isFind = true;
                                            }
                                            else if (att.Tag.Equals(noPro))//图号
                                            {
                                                string no = att.TextString;
                                                if (no.Contains(oldVal))
                                                {
                                                    att.TextString = no.Replace(oldVal, newVal);
                                                    isFind = true;
                                                }
                                            }
                                        }
                                        if (isFind && !isMultiple)//如果是单图纸单图框就不需要继续循环类
                                        {
                                            break;
                                        }
                                    }
                                }
                                else//添加文件记录
                                {
                                    hasblock = false;
                                }
                                tr.Commit();
                            }
                        }
                        if (hasblock)
                        {
                            db.SaveAs(file, DwgVersion.Current);
                            doc.CloseAndSave(file);
                            msg += "✔ " + System.IO.Path.GetFileName(file) + " 转竣工图成功！\r\n";
                        }
                        else
                        {
                            doc.CloseAndDiscard();
                            msg += "0 " + System.IO.Path.GetFileName(file) + " 没有找到对应的属性！\r\n";
                        }
                    }
                    catch
                    {
                        msg += "× " + System.IO.Path.GetFileName(file) + " 转竣工图失败！\r\n";
                        continue;
                    }
                }
                System.Windows.Forms.MessageBox.Show(msg);
            }
        }

      /// <summary>
      /// 获取最大的块
      /// </summary>
      /// <param name="ref1"></param>
      /// <param name="ref2"></param>
      /// <returns></returns>
      private BlockReference GetMaxBlockReference(BlockReference ref1, BlockReference ref2)
      {
          double maxLRef1 = ref1.GeometricExtents.MaxPoint.Y - ref1.GeometricExtents.MinPoint.Y;
          double maxWRef1 = ref1.GeometricExtents.MaxPoint.X - ref1.GeometricExtents.MinPoint.X;

          double maxLRef2 = ref2.GeometricExtents.MaxPoint.Y - ref2.GeometricExtents.MinPoint.Y;
          double maxWRef2 = ref2.GeometricExtents.MaxPoint.X - ref2.GeometricExtents.MinPoint.X;

          if (maxLRef1 * maxWRef1 > maxLRef2 * maxWRef2)
          {
              return ref1;
          }
          else
          {
              return ref2;
          }
      }
    }
}
