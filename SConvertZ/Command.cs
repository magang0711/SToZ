using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/***
 *  获取图框上的 属性 将施工图上的 施工图改为竣工图 将图号上的属性值 S替换成Z
 * **/
[assembly: CommandClass(typeof(SConvertZ.Command))]
namespace SConvertZ
{
    public class Command
    {
        [CommandMethod("SZ")]
        public static void SToZ()
        {
            CADTool tool = new CADTool();
            tool.Convert();
        }
    }
}
