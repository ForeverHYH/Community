using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private static Microsoft.Office.Interop.Excel.Application app;
        private object missing = Missing.Value;//用于调用带默认参数的方法
        public event ProgressHandler SavedEvent;
        public delegate void ProgressHandler();

        private void Save( string savePath, String name, String community, String comments)
        {
            app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = false;//设置Excel窗口不可见
            app.DisplayAlerts = false;//
            app.AlertBeforeOverwriting = false;//关闭修改之后是否保存

            Workbook book = app.Workbooks.Open(savePath, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);//打开拷贝的副本
            Worksheet sheet = book.Sheets[1] as Worksheet;//得到Excel的第一个sheet
            Microsoft.Office.Interop.Excel.Range range = sheet.UsedRange;
            int j = sheet.Rows.Count;
            
            sheet.Cells[j+1, 1] = name;//在单元格的原有内容上追加内容
            sheet.Cells[j+1, 2] = community;
            sheet.Cells[j+1, 3] = comments;
            book.Save();//保存Excel
        }
 
        public void postData(String name, String community, String comments)
        {
            var str = string.Format("{0},{1},{2}", name, community, comments);
            Debug.Write(str);
            Save(@"C:\test\info.xls", name, community, comments);
            //File.AppendAllText(@"C:\test\info.csv", str);
            StreamWriter writer = new StreamWriter(@"C:\test\info.csv", true, Encoding.GetEncoding("GB2312"));
            writer.WriteLine(str);//content为要写入的内容
            writer.Flush();
            writer.Close();

          
        }




    }
}
