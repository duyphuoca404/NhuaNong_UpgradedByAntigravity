// Decompiled with JetBrains decompiler
// Type: NhuaNong.Utils.Converter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Reflection;

#nullable disable
namespace NhuaNong.Utils
{
  public class Converter
  {
    private const string FIELDNAME = "FieldName";
    private const string FIELDCODE = "FieldCode";

    public static BindingList<T> ConvertToBindingList<T>(List<T> lstT) where T : class
    {
      BindingList<T> bindingList = new BindingList<T>();
      foreach (T obj in lstT)
        bindingList.Add(obj);
      return bindingList;
    }

    public static List<T> ConvertToList<T>(BindingList<T> blstT) where T : class
    {
      List<T> list = new List<T>();
      foreach (T obj in (Collection<T>) blstT)
        list.Add(obj);
      return list;
    }

    public BindingList<T> ConvertDataTableToBindingList<T>(DataTable dataTable) where T : class
    {
      BindingList<T> bindingList = new BindingList<T>();
      PropertyInfo[] properties = typeof (T).GetProperties();
      foreach (DataRow row in (InternalDataCollectionBase) dataTable.Rows)
      {
        T instance = Activator.CreateInstance<T>();
        foreach (PropertyInfo propertyInfo in properties)
        {
          if (dataTable.Columns.Contains(propertyInfo.Name) && row[propertyInfo.Name] != DBNull.Value)
            propertyInfo.SetValue((object) instance, row[propertyInfo.Name]);
        }
        bindingList.Add(instance);
      }
      return bindingList;
    }

    public static DataTable ToDataTable<T>(List<T> items)
    {
      DataTable dataTable = new DataTable(typeof (T).Name);
      PropertyInfo[] properties = typeof (T).GetProperties(BindingFlags.Instance | BindingFlags.Public);
      foreach (PropertyInfo propertyInfo in properties)
      {
        Type coreType = Converter.GetCoreType(propertyInfo.PropertyType);
        dataTable.Columns.Add(propertyInfo.Name, coreType);
      }
      foreach (T obj in items)
      {
        object[] objArray = new object[properties.Length];
        for (int index = 0; index < properties.Length; ++index)
          objArray[index] = properties[index].GetValue((object) obj, (object[]) null);
        dataTable.Rows.Add(objArray);
      }
      return dataTable;
    }

    public static bool IsNullable(Type t)
    {
      if (!t.IsValueType)
        return true;
      return t.IsGenericType && t.GetGenericTypeDefinition() == typeof (Nullable<>);
    }

    public static Type GetCoreType(Type t)
    {
      return t != (Type) null && Converter.IsNullable(t) && t.IsValueType ? Nullable.GetUnderlyingType(t) : t;
    }

    public static List<FieldCode> EnumToListFieldCode<EnumType>(bool hasEmptyObject)
    {
      Type type = typeof (EnumType);
      Array values = Enum.GetValues(typeof (EnumType));
      Array names = (Array) Enum.GetNames(typeof (EnumType));
      List<FieldCode> listFieldCode = new List<FieldCode>();
      if (hasEmptyObject)
        listFieldCode.Add(new FieldCode() { ID = -1 });
      for (int index = 0; index < values.Length; ++index)
      {
        FieldCode fieldCode = new FieldCode();
        fieldCode.ID = Convert.ToInt32(values.GetValue(index));
        fieldCode.Code = names.GetValue(index).ToString();
        if (((IEnumerable<object>) type.GetField(fieldCode.Code).GetCustomAttributes(typeof (DisplayAttribute), false)).FirstOrDefault<object>() is DisplayAttribute displayAttribute)
        {
          fieldCode.Description = displayAttribute.GetName();
          fieldCode.DisplayText = fieldCode.Description;
        }
        else
          fieldCode.DisplayText = fieldCode.Code;
        listFieldCode.Add(fieldCode);
      }
      return listFieldCode;
    }

    public static BitArray ConvertByteToBitArray(byte n)
    {
      BitArray bitArray = new BitArray(8);
      int num1 = 8;
      int num2 = 0;
      for (; num1 > 0; --num1)
      {
        bitArray.Set(num2++, ((int) n & 1) == 1);
        n >>= 1;
      }
      return bitArray;
    }

    public static byte ConvertBitArrayToByte(BitArray flags)
    {
      int length = flags.Length / 8;
      if (flags.Length % 8 != 0)
        ++length;
      byte[] numArray = new byte[length];
      int num = 0;
      int index1 = 0;
      for (int index2 = 0; index2 < flags.Length; ++index2)
      {
        if (flags[index2])
          numArray[index1] |= (byte) (1 << num);
        ++num;
        if (num == 8)
        {
          num = 0;
          ++index1;
        }
      }
      return numArray[0];
    }
  }
}
