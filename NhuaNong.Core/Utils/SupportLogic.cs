using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using NhuaNong.Data;

namespace NhuaNong.Utils
{
    public class SupportLogic
    {
        public static string GetNextNiemChi(string inputString)
        {
            string result = "";
            string text = new string(inputString.SkipWhile((char c) => c == '0').ToArray());
            if (int.TryParse(text, out var result2))
            {
                result2++;
                return new string('0', inputString.Length - text.Length) + result2;
            }
            return result;
        }

        public static bool CheckSiloLogic(BindingList<ObjSilo> bllst, string maSilo)
        {
            bool result = true;
            foreach (ObjSilo item in bllst)
            {
                if (item.MaSilo != maSilo)
                {
                    result = false;
                }
            }
            return result;
        }

        public static string SecondToHour(int sec)
        {
            int num = sec / 3600;
            int num2 = sec % 3600 / 60;
            int num3 = sec % 60;
            return "PHẦN MỀM SẼ TỰ ĐỘNG CẬP NHẬT SAU: " + $"{num} Giờ, {num2} Phút, {num3} Giây";
        }

        public static void CloseWordApplications()
        {
            string[] array = new string[4] { "winword", "acrobat", "FoxitReader", "FoxitPhantomPDF" };
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                try
                {
                    string[] array2 = array;
                    foreach (string text in array2)
                    {
                        if (process.ProcessName.ToLower().Contains(text))
                        {
                            process.Kill();
                            Console.WriteLine("Đã đóng ứng dụng " + text + ".");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }
            Process[] processesByName = Process.GetProcessesByName("FoxitPDFReader");
            if (processesByName.Length != 0)
            {
                processesByName[0].Kill();
            }
        }

        public static string[] ReadWordFile(string filePath)
        {
            Microsoft.Office.Interop.Word.Application obj = (Microsoft.Office.Interop.Word.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("000209FF-0000-0000-C000-000000000046")));
            Documents documents = obj.Documents;
            object FileName = filePath;
            object ConfirmConversions = Type.Missing;
            object ReadOnly = Type.Missing;
            object AddToRecentFiles = Type.Missing;
            object PasswordDocument = Type.Missing;
            object PasswordTemplate = Type.Missing;
            object Revert = Type.Missing;
            object WritePasswordDocument = Type.Missing;
            object WritePasswordTemplate = Type.Missing;
            object Format = Type.Missing;
            object Encoding = Type.Missing;
            object Visible = Type.Missing;
            object OpenAndRepair = Type.Missing;
            object DocumentDirection = Type.Missing;
            object NoEncodingDialog = Type.Missing;
            object XMLTransform = Type.Missing;
            Document document = documents.Open(ref FileName, ref ConfirmConversions, ref ReadOnly, ref AddToRecentFiles, ref PasswordDocument, ref PasswordTemplate, ref Revert, ref WritePasswordDocument, ref WritePasswordTemplate, ref Format, ref Encoding, ref Visible, ref OpenAndRepair, ref DocumentDirection, ref NoEncodingDialog, ref XMLTransform);
            string text = document.Content.Text;
            XMLTransform = Type.Missing;
            NoEncodingDialog = Type.Missing;
            DocumentDirection = Type.Missing;
            document.Close(ref XMLTransform, ref NoEncodingDialog, ref DocumentDirection);
            DocumentDirection = Type.Missing;
            NoEncodingDialog = Type.Missing;
            XMLTransform = Type.Missing;
            obj.Quit(ref DocumentDirection, ref NoEncodingDialog, ref XMLTransform);
            return text.Split(new string[1] { Environment.NewLine }, StringSplitOptions.None);
        }

        public static void WriteToExcel(string filePath, string[] lines)
        {
            Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
            Workbook workbook = application.Workbooks.Add(Type.Missing);
            Worksheet worksheet = (dynamic)workbook.Worksheets[1];
            for (int i = 0; i < lines.Length; i++)
            {
                ((dynamic)worksheet.Cells[i + 1, 1]).Value = lines[i];
            }
            workbook.SaveAs(filePath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            workbook.Close(Type.Missing, Type.Missing, Type.Missing);
            application.Quit();
            Marshal.ReleaseComObject(worksheet);
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(application);
        }

        public static void ReadTableFromWordAndWriteToExcel(string wordFile, string excelFile)
        {
            Microsoft.Office.Interop.Word.Application obj = (Microsoft.Office.Interop.Word.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("000209FF-0000-0000-C000-000000000046")));
            Documents documents = obj.Documents;
            object FileName = wordFile;
            object ConfirmConversions = Type.Missing;
            object ReadOnly = Type.Missing;
            object AddToRecentFiles = Type.Missing;
            object PasswordDocument = Type.Missing;
            object PasswordTemplate = Type.Missing;
            object Revert = Type.Missing;
            object WritePasswordDocument = Type.Missing;
            object WritePasswordTemplate = Type.Missing;
            object Format = Type.Missing;
            object Encoding = Type.Missing;
            object Visible = Type.Missing;
            object OpenAndRepair = Type.Missing;
            object DocumentDirection = Type.Missing;
            object NoEncodingDialog = Type.Missing;
            object XMLTransform = Type.Missing;
            Document document = documents.Open(ref FileName, ref ConfirmConversions, ref ReadOnly, ref AddToRecentFiles, ref PasswordDocument, ref PasswordTemplate, ref Revert, ref WritePasswordDocument, ref WritePasswordTemplate, ref Format, ref Encoding, ref Visible, ref OpenAndRepair, ref DocumentDirection, ref NoEncodingDialog, ref XMLTransform);
            string text = document.Content.Text;
            XMLTransform = Type.Missing;
            NoEncodingDialog = Type.Missing;
            DocumentDirection = Type.Missing;
            document.Close(ref XMLTransform, ref NoEncodingDialog, ref DocumentDirection);
            DocumentDirection = Type.Missing;
            NoEncodingDialog = Type.Missing;
            XMLTransform = Type.Missing;
            obj.Quit(ref DocumentDirection, ref NoEncodingDialog, ref XMLTransform);
            string[] array = text.Split(new string[1] { Environment.NewLine }, StringSplitOptions.None);
            Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
            Workbook workbook = application.Workbooks.Add(Type.Missing);
            Worksheet worksheet = (dynamic)workbook.Worksheets[1];
            for (int i = 0; i < array.Length; i++)
            {
                string[] array2 = array[i].Split(new char[2] { '\t', ',' }, StringSplitOptions.None);
                for (int j = 0; j < array2.Length; j++)
                {
                    ((dynamic)worksheet.Cells[i + 1, j + 1]).Value = array2[j].Trim();
                }
            }
            workbook.SaveAs(excelFile, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            workbook.Close(Type.Missing, Type.Missing, Type.Missing);
            application.Quit();
            Marshal.ReleaseComObject(worksheet);
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(application);
        }

        public static void ReadTextFromWordAndWriteToExcel(string wordFile, string excelFile)
        {
            Microsoft.Office.Interop.Word.Application obj = (Microsoft.Office.Interop.Word.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("000209FF-0000-0000-C000-000000000046")));
            Documents documents = obj.Documents;
            object FileName = wordFile;
            object ConfirmConversions = Type.Missing;
            object ReadOnly = Type.Missing;
            object AddToRecentFiles = Type.Missing;
            object PasswordDocument = Type.Missing;
            object PasswordTemplate = Type.Missing;
            object Revert = Type.Missing;
            object WritePasswordDocument = Type.Missing;
            object WritePasswordTemplate = Type.Missing;
            object Format = Type.Missing;
            object Encoding = Type.Missing;
            object Visible = Type.Missing;
            object OpenAndRepair = Type.Missing;
            object DocumentDirection = Type.Missing;
            object NoEncodingDialog = Type.Missing;
            object XMLTransform = Type.Missing;
            Document document = documents.Open(ref FileName, ref ConfirmConversions, ref ReadOnly, ref AddToRecentFiles, ref PasswordDocument, ref PasswordTemplate, ref Revert, ref WritePasswordDocument, ref WritePasswordTemplate, ref Format, ref Encoding, ref Visible, ref OpenAndRepair, ref DocumentDirection, ref NoEncodingDialog, ref XMLTransform);
            string text = document.Content.Text;
            XMLTransform = Type.Missing;
            NoEncodingDialog = Type.Missing;
            DocumentDirection = Type.Missing;
            document.Close(ref XMLTransform, ref NoEncodingDialog, ref DocumentDirection);
            DocumentDirection = Type.Missing;
            NoEncodingDialog = Type.Missing;
            XMLTransform = Type.Missing;
            obj.Quit(ref DocumentDirection, ref NoEncodingDialog, ref XMLTransform);
            string[] array = text.Split(new string[1] { Environment.NewLine }, StringSplitOptions.None);
            Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
            Workbook workbook = application.Workbooks.Add(Type.Missing);
            Worksheet worksheet = (dynamic)workbook.Worksheets[1];
            for (int i = 0; i < array.Length; i++)
            {
                ((dynamic)worksheet.Cells[i + 1, 1]).Value = array[i];
            }
            workbook.SaveAs(excelFile, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            workbook.Close(Type.Missing, Type.Missing, Type.Missing);
            application.Quit();
            Marshal.ReleaseComObject(worksheet);
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(application);
        }

        public static double GenerateFakeValue(decimal realValue, decimal lowerError, decimal upperError)
        {
            decimal num = realValue * 0.005m;
            decimal num2 = lowerError + num;
            decimal num3 = upperError - num;
            Random random = new Random();
            double num4 = ((random.Next(2) != 0) ? ((double)num3 - random.NextDouble() * (double)(num3 - num2) * 0.1) : ((double)num2 + random.NextDouble() * (double)(num3 - num2) * 0.1));
            if (random.Next(2) != 0)
            {
                return (double)realValue - num4;
            }
            return (double)realValue + num4;
        }

        public static double GenerateFakeValueADD(decimal realValue)
        {
            Random random = new Random();
            double num = random.NextDouble();
            if (random.Next(2) == 0)
            {
                return (double)realValue + num;
            }
            return (double)realValue - num;
        }

        public static double CalculateSiloValue(string silo1Name, string silo2Name, string group)
        {
            string s = "";
            switch (group)
            {
                case "AG":
                    s = GetNumLogicSiloAG(silo1Name).ToString() + GetNumLogicSiloAG(silo2Name);
                    break;
                case "CE":
                    s = GetNumLogicSiloCE(silo1Name).ToString() + GetNumLogicSiloCE(silo2Name);
                    break;
                case "AD":
                    s = GetNumLogicSiloAD(silo1Name).ToString() + GetNumLogicSiloAD(silo2Name);
                    break;
            }
            return double.Parse(s);
        }

        private static int GetNumLogicSiloAG(string siloName)
        {
            int result = 0;
            switch (siloName)
            {
                case "Agg1":
                    result = 1;
                    break;
                case "Agg2":
                    result = 2;
                    break;
                case "Agg3":
                    result = 3;
                    break;
                case "Agg4":
                    result = 4;
                    break;
                case "Agg5":
                    result = 5;
                    break;
                case "Agg6":
                    result = 6;
                    break;
            }
            return result;
        }

        private static int GetNumLogicSiloCE(string siloName)
        {
            int result = 0;
            switch (siloName)
            {
                case "Ce1":
                    result = 1;
                    break;
                case "Ce2":
                    result = 2;
                    break;
                case "Ce3":
                    result = 3;
                    break;
                case "Ce4":
                    result = 4;
                    break;
                case "Ce5":
                    result = 5;
                    break;
            }
            return result;
        }

        private static int GetNumLogicSiloAD(string siloName)
        {
            int result = 0;
            switch (siloName)
            {
                case "Add1":
                    result = 1;
                    break;
                case "Add2":
                    result = 2;
                    break;
                case "Add3":
                    result = 3;
                    break;
                case "Add4":
                    result = 4;
                    break;
                case "Add5":
                    result = 5;
                    break;
                case "Add6":
                    result = 6;
                    break;
            }
            return result;
        }
    }
}
