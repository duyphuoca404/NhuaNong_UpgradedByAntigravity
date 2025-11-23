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
		return SupportLogic.GetNextNiemChi(inputString);
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
		if (!ValidateData(lue1, lue2))
		{
			return result;
		}
        
        string silo1Name = lue1.GetColumnValue("MaSilo").ToString();
        string silo2Name = lue2.GetColumnValue("MaSilo").ToString();
        
        return SupportLogic.CalculateSiloValue(silo1Name, silo2Name, nhomSilo);
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
		return SupportLogic.CheckSiloLogic(bllst, maSilo);
	}

	public static string SecondToHour(int sec)
	{
		return SupportLogic.SecondToHour(sec);
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
		SupportLogic.CloseWordApplications();
	}

	public static string[] ReadWordFile(string filePath)
	{
		return SupportLogic.ReadWordFile(filePath);
	}

	public static void WriteToExcel(string filePath, string[] lines)
	{
		SupportLogic.WriteToExcel(filePath, lines);
	}

	public static void ReadTableFromWordAndWriteToExcel(string wordFile, string excelFile)
	{
		SupportLogic.ReadTableFromWordAndWriteToExcel(wordFile, excelFile);
	}

	public static void ReadTextFromWordAndWriteToExcel(string wordFile, string excelFile)
	{
		SupportLogic.ReadTextFromWordAndWriteToExcel(wordFile, excelFile);
	}

	public static double GenerateFakeValue(decimal realValue, decimal lowerError, decimal upperError)
	{
		return SupportLogic.GenerateFakeValue(realValue, lowerError, upperError);
	}

	public static double GenerateFakeValueADD(decimal realValue)
	{
		return SupportLogic.GenerateFakeValueADD(realValue);
	}
}
