// Decompiled with JetBrains decompiler
// Type: NhuaNong.Core.ISpecification`1
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Linq.Expressions;

#nullable disable
namespace NhuaNong.Core
{
  public interface ISpecification<T>
  {
    Expression<Func<T, bool>> EvalPredicate { get; }

    Func<T, bool> EvalFunc { get; }
  }
}
