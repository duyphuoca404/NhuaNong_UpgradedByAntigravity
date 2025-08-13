using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using NhuaNong.Data;

namespace NhuaNong.Utils;

public class Support
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

	public static void GetListSiloLogic(BindingList<ObjSilo> _blstSiloLogic, BindingList<ObjSilo> _blstSiloLogic1, LookUpEdit lue1, LookUpEdit lue2)
	{
		_blstSiloLogic1.Clear();
		foreach (ObjSilo item in _blstSiloLogic)
		{
			if (item.SiloID != (int)lue1.EditValue)
			{
				_blstSiloLogic1.Add(item);
			}
		}
		lue2.Properties.DataSource = _blstSiloLogic1;
	}

	public static void GetListSiloLogic(BindingList<ObjSilo> _blstSiloLogic, LookUpEdit lue1)
	{
		BindingList<ObjSilo> bindingList = new BindingList<ObjSilo>();
		foreach (ObjSilo item in _blstSiloLogic)
		{
			if (item.SiloID != (int)lue1.EditValue)
			{
				bindingList.Add(item);
			}
		}
		_blstSiloLogic.Clear();
		_blstSiloLogic = bindingList;
	}

	public static void UpdateListSiloLogic(BindingList<ObjSilo> _blstSiloLogic, string maSilo)
	{
		BindingList<ObjSilo> bindingList = new BindingList<ObjSilo>();
		foreach (ObjSilo item in _blstSiloLogic)
		{
			if (!(item.MaSilo == maSilo))
			{
				bindingList.Add(item);
			}
		}
		_blstSiloLogic.Clear();
		foreach (ObjSilo item2 in bindingList)
		{
			_blstSiloLogic.Add(item2);
		}
	}

	public static void SetValueSpinZero(SpinEdit spinEdit)
	{
		if (spinEdit != null && spinEdit.Value < 0m)
		{
			spinEdit.Value = 0m;
		}
	}

	public static void ResetValueLueLogic(LookUpEdit lue1, LookUpEdit lue2)
	{
		lue1.EditValue = null;
		lue2.EditValue = null;
	}

	public static double GetValueLogic(LookUpEdit lue1, LookUpEdit lue2, string nhomSilo)
	{
		double result = 0.0;
		string s = "";
		if (!ValidateData(lue1, lue2))
		{
			return result;
		}
		switch (nhomSilo)
		{
		case "AG":
			s = GetNumLogicSiloAG(lue1).ToString() + GetNumLogicSiloAG(lue2);
			break;
		case "CE":
			s = GetNumLogicSiloCE(lue1).ToString() + GetNumLogicSiloCE(lue2);
			break;
		case "AD":
			s = GetNumLogicSiloAD(lue1).ToString() + GetNumLogicSiloAD(lue2);
			break;
		}
		return double.Parse(s);
	}

	private static bool ValidateData(LookUpEdit lue1, LookUpEdit lue2)
	{
		bool result = true;
		if (lue1.EditValue == null)
		{
			lue1.ErrorText = "Silo is requied";
			result = false;
		}
		if (lue2.EditValue == null)
		{
			lue2.ErrorText = "Silo is requied";
			result = false;
		}
		return result;
	}

	private static int GetNumLogicSiloAG(LookUpEdit lueSiloLogic)
	{
		int result = 0;
		switch (lueSiloLogic.GetColumnValue("MaSilo").ToString())
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

	private static int GetNumLogicSiloCE(LookUpEdit lueSiloLogic)
	{
		int result = 0;
		switch (lueSiloLogic.GetColumnValue("MaSilo").ToString())
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

	private static int GetNumLogicSiloAD(LookUpEdit lueSiloLogic)
	{
		int result = 0;
		switch (lueSiloLogic.GetColumnValue("MaSilo").ToString())
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

	public static double SetUpLogic(LookUpEdit lue1, LookUpEdit lue2, string nhomSilo)
	{
		if (lue1.Text == string.Empty || lue2.Text == string.Empty)
		{
			return GetValueLogic(lue1, lue2, nhomSilo);
		}
		string arg = lue1.Text.ToString();
		string arg2 = lue2.Text.ToString();
		if (TramTromMessageBox.ShowYesNoDialog($"Xác nhận thực hiện thiết lập {arg} - LOGIC - {arg2} ?") != DialogResult.Yes)
		{
			return 0.0;
		}
		return GetValueLogic(lue1, lue2, nhomSilo);
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

	public static void PrintReport(string path)
	{
		try
		{
			Process.Start(new ProcessStartInfo
			{
				Verb = "print",
				FileName = path,
				CreateNoWindow = true,
				WindowStyle = ProcessWindowStyle.Hidden
			});
		}
		catch (Exception ex)
		{
			TramTromMessageBox.ShowErrorDialog(ex.ToString());
		}
	}

	public static void PrintReportNEW(string path)
	{
		try
		{
			string text = Path.GetExtension(path).ToLower();
			if (text != ".pdf" && text != ".doc" && text != ".docx")
			{
				TramTromMessageBox.ShowErrorDialog("Unsupported file format.");
				return;
			}
			if (text == ".pdf")
			{
				string pdfReaderPath = ConfigManager.TramTronConfig.PdfReaderPath;
				if (!File.Exists(pdfReaderPath))
				{
					TramTromMessageBox.ShowErrorDialog("Foxit Reader not found.");
					return;
				}
				ProcessStartInfo startInfo = new ProcessStartInfo
				{
					FileName = pdfReaderPath,
					Arguments = "/t \"" + path + "\"",
					CreateNoWindow = true,
					WindowStyle = ProcessWindowStyle.Hidden
				};
				using Process process = new Process
				{
					StartInfo = startInfo
				};
				process.Start();
				process.WaitForExit();
				return;
			}
			ProcessStartInfo startInfo2 = new ProcessStartInfo
			{
				FileName = path,
				Verb = "print",
				CreateNoWindow = true,
				WindowStyle = ProcessWindowStyle.Hidden
			};
			using Process process2 = new Process
			{
				StartInfo = startInfo2
			};
			process2.Start();
			process2.WaitForExit();
		}
		catch (Exception ex)
		{
			TramTromMessageBox.ShowErrorDialog(ex.ToString());
		}
	}

	public static void PrintReportPDF(string path)
	{
		try
		{
			string pdfReaderPath = ConfigManager.TramTronConfig.PdfReaderPath;
			if (!File.Exists(pdfReaderPath))
			{
				TramTromMessageBox.ShowErrorDialog("Foxit Reader not found.");
				return;
			}
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = pdfReaderPath,
				Arguments = "/t \"" + path + "\"",
				CreateNoWindow = true,
				WindowStyle = ProcessWindowStyle.Hidden
			};
			using Process process = new Process
			{
				StartInfo = startInfo
			};
			process.Start();
			process.WaitForExit();
		}
		catch (Exception ex)
		{
			TramTromMessageBox.ShowErrorDialog(ex.ToString());
		}
	}

	public static void PrintReportWord(string path)
	{
		try
		{
			if (!File.Exists(path))
			{
				TramTromMessageBox.ShowErrorDialog("Word file not found.");
				return;
			}
			Microsoft.Office.Interop.Word.Application obj = (Microsoft.Office.Interop.Word.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("000209FF-0000-0000-C000-000000000046")));
			Documents documents = obj.Documents;
			object FileName = path;
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
			XMLTransform = Type.Missing;
			NoEncodingDialog = Type.Missing;
			DocumentDirection = Type.Missing;
			OpenAndRepair = Type.Missing;
			Visible = Type.Missing;
			Encoding = Type.Missing;
			Format = Type.Missing;
			WritePasswordTemplate = Type.Missing;
			WritePasswordDocument = Type.Missing;
			Revert = Type.Missing;
			PasswordTemplate = Type.Missing;
			PasswordDocument = Type.Missing;
			AddToRecentFiles = Type.Missing;
			ReadOnly = Type.Missing;
			ConfirmConversions = Type.Missing;
			FileName = Type.Missing;
			object PrintZoomPaperWidth = Type.Missing;
			object PrintZoomPaperHeight = Type.Missing;
			document.PrintOut(ref XMLTransform, ref NoEncodingDialog, ref DocumentDirection, ref OpenAndRepair, ref Visible, ref Encoding, ref Format, ref WritePasswordTemplate, ref WritePasswordDocument, ref Revert, ref PasswordTemplate, ref PasswordDocument, ref AddToRecentFiles, ref ReadOnly, ref ConfirmConversions, ref FileName, ref PrintZoomPaperWidth, ref PrintZoomPaperHeight);
			PrintZoomPaperHeight = false;
			PrintZoomPaperWidth = Type.Missing;
			FileName = Type.Missing;
			document.Close(ref PrintZoomPaperHeight, ref PrintZoomPaperWidth, ref FileName);
			FileName = Type.Missing;
			PrintZoomPaperWidth = Type.Missing;
			PrintZoomPaperHeight = Type.Missing;
			obj.Quit(ref FileName, ref PrintZoomPaperWidth, ref PrintZoomPaperHeight);
			Marshal.ReleaseComObject(document);
			Marshal.ReleaseComObject(obj);
		}
		catch (Exception ex)
		{
			TramTromMessageBox.ShowErrorDialog(ex.ToString());
		}
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
}
